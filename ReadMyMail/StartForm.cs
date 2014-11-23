#region Author

/*************************************************************************************************
 *************************************************************************************************
 ** Author:   Brenton E. A. Bates                                                               **
 ** Date:     10/20/2014                                                                        **
 ** Purpose:  Application has the ability to access an email server and pull received emails    **
 ** Contact:  mailto:brentonbates@gmail.com                                                     **
 **                                                                                             **
 **                                                                                             **
 *************************************************************************************************
 *************************************************************************************************/

#endregion Author

#region IMAP Help

// nuget ImapS22: https://www.nuget.org/packages/S22.Imap/
// Install-Package S22.Imap: https://github.com/smiley22/S22.Imap
// Look here for help using the library: https://github.com/smiley22/S22.Imap/blob/master/Examples.md

#endregion IMAP Help

#region References

using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using S22.Imap;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

#endregion References

namespace ReadMyMail
{
    public partial class StartForm : RadForm
    {
        #region Public Variables
       
        public ImapClient EmailClient = null;
        public ICollection<MailMessage> InboxMessages; 
        public CredentialsForm CredentialsForm = new CredentialsForm();
        public InboxPreviewForm InboxPreviewForm = new InboxPreviewForm();
        //public IEnumerable<MailMessage> MailMessages;

        public int HighestPercentageReached = 0;
        public string Password = null;
        public const int SslPort = 993;
        public string EmailAddress = null;
        public string SelectedHostName = null;
        public const string GmailHostName = "imap.gmail.com";
        public const string MsnHostName = "imap-mail.outlook.com";

        public DateTime Begin, End;
        public TimeSpan TimeSpan = new TimeSpan();
        public BackgroundWorker MyBackgroundWorker;
        
        #endregion Constant Variables

        #region StartForm Initialization
        public StartForm()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
            ThemeResolutionService.ApplicationThemeName = windows8Theme1.ThemeName;
        }

        private void InitializeBackgroundWorker()
        {
            MyBackgroundWorker = new BackgroundWorker { WorkerReportsProgress = true, WorkerSupportsCancellation = true };

            MyBackgroundWorker.DoWork += new DoWorkEventHandler(MyBackgroundWorker1_DoWork);

            MyBackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(MyBackgroundWorker1_RunWorkerCompleted);

            MyBackgroundWorker.ProgressChanged += new ProgressChangedEventHandler(MyBackgroundWorker1_ProgressChanged);
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            progressBar.Visible = false;
            waitCancelButton.Visible = false;
            progressLabel.Visible = false;
        }

        #endregion

        #region BackgroundWorker Events
        protected void MyBackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }

        protected void MyBackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            
            e.Result = BindInboxPreviewForm(worker, e);            
        }

        protected void MyBackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           //LOADING HAS STOPPED...
            End = DateTime.Now;
            TimeSpan = End - Begin;

            ProgressBarStop();

            if ((e.Cancelled == true))
            {
                if (EmailClient != null)
                {
                    EmailClient.Logout();
                    MessageBox.Show("You have been logged out.");
                    CredentialsForm.Show();
                }
            }
            else if (e.Error != null)
            {
                MessageBox.Show(("Error: " + e.Error.Message));
            }
            else
            { //Successful Retrieve of Messages
                //TODO: Fix show of properties for InboxPreviewForm Login Panel: dateLabel, emailLabel, hostLabel 
                progressBar.Text = "Finished!";
                MessageBox.Show("Elapsed time while loading: " + TimeSpan.TotalSeconds + " seconds");
                InboxPreviewForm.Show();

                var loginEmailTxtBox = CredentialsForm.Controls.Find("loginEmailTxtBox", true).FirstOrDefault() as RadTextBox;
                var inboxHostLabel = InboxPreviewForm.Controls.Find("inboxHostLabel", true).FirstOrDefault() as RadLabel ?? new RadLabel() { Name = "inboxHostLabel" };
                var inboxLoginLabel = InboxPreviewForm.Controls.Find("inboxLoginLabel", true).FirstOrDefault() as RadLabel ?? new RadLabel() { Name = "inboxLoginLabel" };

                //Inbox Form Login Panel
                inboxLoginLabel.Text = loginEmailTxtBox.Text;
                inboxLoginLabel.Visible = true;
                inboxHostLabel.Text = SelectedHostName.Contains("gmail") ? "Google" : "Microsoft";

                var inboxDateLabel = InboxPreviewForm.Controls.Find("inboxDateLabel", true).FirstOrDefault() as RadLabel;
                inboxDateLabel.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                inboxDateLabel.Visible = true;
            }
        }
        #endregion 

        #region ProgressBar
        private void ProgressBarStart()
        {
            progressBar.WaitingBarElement.TextElement.TextAlignment = ContentAlignment.MiddleCenter;
            progressBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;

            var dash = progressBar.WaitingBarElement.SeparatorElement;
            dash.NumberOfColors = 2;
            dash.BackColor = Color.Orange;
            dash.BackColor2 = Color.Yellow;
            dash.SweepAngle = 45;
            dash.StepWidth = 15;
            dash.SeparatorWidth = 10;
            dash.GradientPercentage = 0.25f;

            progressBar.Text = "Loading... Please Wait";

            progressBar.StartWaiting();
            progressLabel.Visible = true;
            progressBar.Visible = true;
            progressBar.ShowText = true;

            waitCancelButton.Enabled = true;
            waitCancelButton.Visible = true;
        }

        private void ProgressBarStop()
        {
            //progressBar.Hide();
            progressBar.StopWaiting();
            progressBar.ResetWaiting();
            progressBar.Text = string.Empty;
            waitCancelButton.Enabled = false;
        }
#endregion

        #region Tile Click Events
        private void credentialsLiveTile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedHostName))
            {
                MessageBox.Show("You must select a Email Provider by clicking one upon the Start page",
                "Host Not Chosen",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
                return;
            }

            var credFormSelectedHostLabel = CredentialsForm.Controls.Find("selectedHostLabel", true).FirstOrDefault() as RadLabel
                                            ??
                                            new RadLabel()
                                            {
                                                Name = "selectedHostLabel"
                                            };


            credFormSelectedHostLabel.Text = SelectedHostName.Contains("gmail") ? "Google" : "Microsoft";

            var dialogresult = CredentialsForm.ShowDialog();

            switch (dialogresult)
            {
                case DialogResult.OK:
                    try
                    {
                        if (!MyBackgroundWorker.IsBusy)
                        {
                            //Go get Inbox Messages (DoWork)
                            MyBackgroundWorker.RunWorkerAsync();

                            ProgressBarStart();

                            //Manual start of timer
                            Begin = DateTime.Now;
                        }

                    }
                    catch (Exception ex)
                    {
                        if (ex.Source != null)
                            throw new Exception("The program has encountered an error please see the Inner Exception", ex);
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case DialogResult.Cancel:
                    //TODO: Something useful here
                    break;
            }

        }

        private void outlookLiveTile_Click(object sender, EventArgs e)
        {
            SelectedHostName = MsnHostName;
        }

        private void googleLiveTile_Click(object sender, EventArgs e)
        {
            SelectedHostName = GmailHostName;
        }
#endregion

        private ICollection<MailMessage> BindInboxPreviewForm(BackgroundWorker worker, DoWorkEventArgs e)
        {
            if (worker.CancellationPending)
                e.Cancel = true;
            
            //Credentials Form Controls
            var loginEmailTxtBox = CredentialsForm.Controls.Find("loginEmailTxtBox", true).FirstOrDefault() as RadTextBox;
            var loginPasswordTxtBox = CredentialsForm.Controls.Find("loginPasswordTxtBox", true).FirstOrDefault() as RadTextBox;

            var inboxGridView = InboxPreviewForm.Controls.Find("inboxGridView", true).FirstOrDefault() as RadGridView ?? new RadGridView() { Name = "inboxGridView" };

            if (loginEmailTxtBox == null || loginPasswordTxtBox == null || string.IsNullOrEmpty(SelectedHostName))
                throw new Exception("You must enter valid credentials and choose an Email Provider in order to Read Your Mail.");

            using (EmailClient = new ImapClient(SelectedHostName, SslPort, loginEmailTxtBox.Text, loginPasswordTxtBox.Text, AuthMethod.Login, true))
            {
                MessageBox.Show("Successful Connection Establised @ " + DateTime.Now.TimeOfDay);
                
                //Returning IEnumerable<uint> List of mail ids  
                var messageIds = EmailClient.Search(SearchCondition.All());

                //Returning an IEnumerable<MailMessage> as a List of messages
                InboxMessages = EmailClient.GetMessages(messageIds, FetchOptions.NoAttachments).ToList();

                //TODO: Decoding can be timely, need to slim down object for preview
                //Provide decoding for message properties being displayed
                //foreach (var message in InboxMessages)
                //{
                //    //TODO: Will need more decoding to remove html, prolly regex
                //    WebUtility.HtmlDecode(message.Body.ToString(CultureInfo.InvariantCulture));
                //}

                //Bind Datagrid
                inboxGridView.DataSource = InboxMessages;

                return InboxMessages;
            }
        }

        private void signatureLinkLabel_MouseHover(object sender, EventArgs e)
        {
            switch (signatureLinkLabel.Font.Style)
            {
                case FontStyle.Italic:
                    signatureLinkLabel.Font = new Font(signatureLinkLabel.Font, FontStyle.Strikeout);
                    break;
                case FontStyle.Bold:
                    signatureLinkLabel.Font = new Font(signatureLinkLabel.Font, FontStyle.Italic);
                    break;
                case FontStyle.Regular:
                    signatureLinkLabel.Font = new Font(signatureLinkLabel.Font, FontStyle.Strikeout);
                    break;
                case FontStyle.Strikeout:
                    signatureLinkLabel.Font = new Font(signatureLinkLabel.Font, FontStyle.Bold);
                    break;
            }
        }

        private void waitCancelButton_Click(object sender, EventArgs e)
        {
            // Cancel the asynchronous operation. 
            MyBackgroundWorker.CancelAsync();

            // Disable the Cancel button.
            waitCancelButton.Enabled = false;
        }
    }
}