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
#endregion

#region References
using System;
using System.ComponentModel;
using System.Windows.Forms;

#endregion

namespace ReadMyMail
{
    public partial class CredentialsForm : Telerik.WinControls.UI.RadForm
    {
        public CredentialsForm()
        {
            InitializeComponent();
        }

        private void loginEmailTxtBox_Validating(object sender, CancelEventArgs e)
        {
            loginOkButton.Enabled = true;
            var passedValidation = ValidateEmailTxtBox();
            
            if (passedValidation == false)
            {
                loginOkButton.Enabled = false;
            }
        }

        private void loginPasswordTxtBox_Validating(object sender, CancelEventArgs e)
        {
            loginOkButton.Enabled = true;
            var passedValidation = ValidatePasswordTxtBox();

            if (passedValidation == false)
            {
                loginOkButton.Enabled = false;
            }
        }
        

        private void loginOkButton_Click(object sender, EventArgs e)
        {
            if (!loginEmailTxtBox.Text.Contains("@") || loginPasswordTxtBox.Text.Length <= 3)
            {
                MessageBox.Show("Please enter a valid email address and password to login.");
            }
            
        }

        #region Validate Fields
        private bool ValidateEmailTxtBox()
        {
            var passedValidation = true;

            if (string.IsNullOrEmpty(loginEmailTxtBox.Text))
            {
                loginErrorProvider.SetError(loginEmailTxtBox, "Please enter your full email address");
                passedValidation = false;
            }
            else
                loginErrorProvider.SetError(loginEmailTxtBox, "");

            return passedValidation;
        }

        private bool ValidatePasswordTxtBox()
        {
            var passedValidation = true;

            if (string.IsNullOrEmpty(loginPasswordTxtBox.Text))
            {
                loginErrorProvider.SetError(loginPasswordTxtBox, "Please enter your password");
                passedValidation = false;
            }
            else
                loginErrorProvider.SetError(loginPasswordTxtBox, "");

            return passedValidation;
        }
        #endregion
      
    }
}
