namespace ReadMyMail
{
    partial class CredentialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialsForm));
            this.credentialsPanel = new Telerik.WinControls.UI.RadPanel();
            this.loginCancelButton = new Telerik.WinControls.UI.RadButton();
            this.loginOkButton = new Telerik.WinControls.UI.RadButton();
            this.loginPasswordTxtBox = new Telerik.WinControls.UI.RadTextBox();
            this.loginEmailTxtBox = new Telerik.WinControls.UI.RadTextBox();
            this.passwordLabel = new Telerik.WinControls.UI.RadLabel();
            this.emailLabel = new Telerik.WinControls.UI.RadLabel();
            this.loginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.loginHostLabel = new Telerik.WinControls.UI.RadLabel();
            this.selectedHostLabel = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.credentialsPanel)).BeginInit();
            this.credentialsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginOkButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPasswordTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEmailTxtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHostLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedHostLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // credentialsPanel
            // 
            this.credentialsPanel.Controls.Add(this.selectedHostLabel);
            this.credentialsPanel.Controls.Add(this.loginHostLabel);
            this.credentialsPanel.Controls.Add(this.loginCancelButton);
            this.credentialsPanel.Controls.Add(this.loginOkButton);
            this.credentialsPanel.Controls.Add(this.loginPasswordTxtBox);
            this.credentialsPanel.Controls.Add(this.loginEmailTxtBox);
            this.credentialsPanel.Controls.Add(this.passwordLabel);
            this.credentialsPanel.Controls.Add(this.emailLabel);
            this.credentialsPanel.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credentialsPanel.Location = new System.Drawing.Point(3, 2);
            this.credentialsPanel.Name = "credentialsPanel";
            this.credentialsPanel.Size = new System.Drawing.Size(313, 156);
            this.credentialsPanel.TabIndex = 0;
            this.credentialsPanel.Text = "Login";
            this.credentialsPanel.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loginCancelButton
            // 
            this.loginCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginCancelButton.Location = new System.Drawing.Point(191, 125);
            this.loginCancelButton.Name = "loginCancelButton";
            this.loginCancelButton.Size = new System.Drawing.Size(60, 24);
            this.loginCancelButton.TabIndex = 5;
            this.loginCancelButton.Text = "Cancel";
            // 
            // loginOkButton
            // 
            this.loginOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginOkButton.Location = new System.Drawing.Point(74, 125);
            this.loginOkButton.Name = "loginOkButton";
            this.loginOkButton.Size = new System.Drawing.Size(60, 24);
            this.loginOkButton.TabIndex = 4;
            this.loginOkButton.Text = "OK";
            this.loginOkButton.Click += new System.EventHandler(this.loginOkButton_Click);
            // 
            // loginPasswordTxtBox
            // 
            this.loginPasswordTxtBox.Location = new System.Drawing.Point(74, 64);
            this.loginPasswordTxtBox.MaxLength = 100;
            this.loginPasswordTxtBox.Name = "loginPasswordTxtBox";
            this.loginPasswordTxtBox.Size = new System.Drawing.Size(177, 20);
            this.loginPasswordTxtBox.TabIndex = 3;
            this.loginPasswordTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.loginPasswordTxtBox_Validating);
            // 
            // loginEmailTxtBox
            // 
            this.loginEmailTxtBox.Location = new System.Drawing.Point(74, 27);
            this.loginEmailTxtBox.MaxLength = 100;
            this.loginEmailTxtBox.Name = "loginEmailTxtBox";
            this.loginEmailTxtBox.Size = new System.Drawing.Size(177, 20);
            this.loginEmailTxtBox.TabIndex = 2;
            this.loginEmailTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.loginEmailTxtBox_Validating);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(12, 64);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 18);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(32, 27);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 18);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // loginErrorProvider
            // 
            this.loginErrorProvider.ContainerControl = this;
            // 
            // loginHostLabel
            // 
            this.loginHostLabel.Location = new System.Drawing.Point(17, 97);
            this.loginHostLabel.Name = "loginHostLabel";
            this.loginHostLabel.Size = new System.Drawing.Size(50, 18);
            this.loginHostLabel.TabIndex = 1;
            this.loginHostLabel.Text = "Provider:";
            // 
            // selectedHostLabel
            // 
            this.selectedHostLabel.Location = new System.Drawing.Point(74, 97);
            this.selectedHostLabel.Name = "selectedHostLabel";
            this.selectedHostLabel.Size = new System.Drawing.Size(119, 18);
            this.selectedHostLabel.TabIndex = 6;
            this.selectedHostLabel.Text = "Select A Email Provider";
            ((Telerik.WinControls.UI.RadLabelElement)(this.selectedHostLabel.GetChildAt(0))).Text = "Select A Email Provider";
            ((Telerik.WinControls.UI.RadLabelElement)(this.selectedHostLabel.GetChildAt(0))).Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CredentialsForm
            // 
            this.AcceptButton = this.loginOkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.loginCancelButton;
            this.ClientSize = new System.Drawing.Size(321, 163);
            this.Controls.Add(this.credentialsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CredentialsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Enter Your Credentials";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.credentialsPanel)).EndInit();
            this.credentialsPanel.ResumeLayout(false);
            this.credentialsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginOkButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPasswordTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginEmailTxtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginHostLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedHostLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel credentialsPanel;
        private Telerik.WinControls.UI.RadTextBox loginPasswordTxtBox;
        private Telerik.WinControls.UI.RadTextBox loginEmailTxtBox;
        private Telerik.WinControls.UI.RadLabel passwordLabel;
        private Telerik.WinControls.UI.RadLabel emailLabel;
        private Telerik.WinControls.UI.RadButton loginCancelButton;
        private Telerik.WinControls.UI.RadButton loginOkButton;
        private System.Windows.Forms.ErrorProvider loginErrorProvider;
        private Telerik.WinControls.UI.RadLabel selectedHostLabel;
        private Telerik.WinControls.UI.RadLabel loginHostLabel;
    }
}
