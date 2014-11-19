namespace ReadMyMail
{
    partial class WaitingForm
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
            this.waitingBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitCancelButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.waitingBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // waitingBar
            // 
            this.waitingBar.Location = new System.Drawing.Point(2, 29);
            this.waitingBar.Name = "waitingBar";
            this.waitingBar.Size = new System.Drawing.Size(264, 24);
            this.waitingBar.TabIndex = 0;
            this.waitingBar.Text = "waitingBar";
            // 
            // waitCancelButton
            // 
            this.waitCancelButton.Location = new System.Drawing.Point(75, 59);
            this.waitCancelButton.Name = "waitCancelButton";
            this.waitCancelButton.Size = new System.Drawing.Size(110, 24);
            this.waitCancelButton.TabIndex = 1;
            this.waitCancelButton.Text = "Cancel";
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 90);
            this.Controls.Add(this.waitCancelButton);
            this.Controls.Add(this.waitingBar);
            this.Name = "WaitingForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Loading.... Please Wait";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.waitingBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWaitingBar waitingBar;
        private Telerik.WinControls.UI.RadButton waitCancelButton;
    }
}
