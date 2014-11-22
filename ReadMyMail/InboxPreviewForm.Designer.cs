namespace ReadMyMail
{
    partial class InboxPreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InboxPreviewForm));
            this.inboxInfoPanel = new Telerik.WinControls.UI.RadCollapsiblePanel();
            this.inboxDateLabel = new Telerik.WinControls.UI.RadLabel();
            this.inboxHostLabel = new Telerik.WinControls.UI.RadLabel();
            this.inboxLoginLabel = new Telerik.WinControls.UI.RadLabel();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.inboxGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.inboxInfoPanel)).BeginInit();
            this.inboxInfoPanel.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxHostLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxLoginLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // inboxInfoPanel
            // 
            this.inboxInfoPanel.AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            this.inboxInfoPanel.Location = new System.Drawing.Point(-4, 1);
            this.inboxInfoPanel.Name = "inboxInfoPanel";
            // 
            // inboxInfoPanel.PanelContainer
            // 
            this.inboxInfoPanel.PanelContainer.Controls.Add(this.inboxDateLabel);
            this.inboxInfoPanel.PanelContainer.Controls.Add(this.inboxHostLabel);
            this.inboxInfoPanel.PanelContainer.Controls.Add(this.inboxLoginLabel);
            this.inboxInfoPanel.PanelContainer.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inboxInfoPanel.PanelContainer.Size = new System.Drawing.Size(797, 53);
            // 
            // 
            // 
            this.inboxInfoPanel.RootElement.Text = "";
            this.inboxInfoPanel.Size = new System.Drawing.Size(799, 81);
            this.inboxInfoPanel.TabIndex = 0;
            this.inboxInfoPanel.Text = "Login Credentials";
            this.inboxInfoPanel.VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.inboxInfoPanel.GetChildAt(0))).ExpandDirection = Telerik.WinControls.UI.RadDirection.Down;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.inboxInfoPanel.GetChildAt(0))).AnimationType = Telerik.WinControls.UI.CollapsiblePanelAnimationType.Slide;
            ((Telerik.WinControls.UI.RadCollapsiblePanelElement)(this.inboxInfoPanel.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.CollapsiblePanelLayoutElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(1))).HorizontalHeaderAlignment = Telerik.WinControls.UI.RadHorizontalAlignment.Left;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(1))).VerticalHeaderAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center;
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(1))).Text = "Login Dashboard";
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(1))).Font = new System.Drawing.Font("Buxton Sketch", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ((Telerik.WinControls.UI.CollapsiblePanelHeaderElement)(this.inboxInfoPanel.GetChildAt(0).GetChildAt(1))).Shape = null;
            // 
            // inboxDateLabel
            // 
            this.inboxDateLabel.Location = new System.Drawing.Point(354, 18);
            this.inboxDateLabel.Name = "inboxDateLabel";
            this.inboxDateLabel.Size = new System.Drawing.Size(84, 18);
            this.inboxDateLabel.TabIndex = 2;
            this.inboxDateLabel.Text = "inboxDateLabel";
            this.inboxDateLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inboxHostLabel
            // 
            this.inboxHostLabel.Location = new System.Drawing.Point(699, 18);
            this.inboxHostLabel.Name = "inboxHostLabel";
            this.inboxHostLabel.Size = new System.Drawing.Size(84, 18);
            this.inboxHostLabel.TabIndex = 1;
            this.inboxHostLabel.Text = "inboxHostLabel";
            this.inboxHostLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inboxLoginLabel
            // 
            this.inboxLoginLabel.Location = new System.Drawing.Point(15, 18);
            this.inboxLoginLabel.Name = "inboxLoginLabel";
            this.inboxLoginLabel.Size = new System.Drawing.Size(88, 18);
            this.inboxLoginLabel.TabIndex = 0;
            this.inboxLoginLabel.Text = "inboxLoginLabel";
            this.inboxLoginLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // inboxGridView
            // 
            this.inboxGridView.Location = new System.Drawing.Point(-3, 106);
            this.inboxGridView.Name = "inboxGridView";
            this.inboxGridView.Size = new System.Drawing.Size(797, 407);
            this.inboxGridView.TabIndex = 1;
            this.inboxGridView.Text = "inboxGridView";
            // 
            // InboxPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.inboxGridView);
            this.Controls.Add(this.inboxInfoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InboxPreviewForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inbox";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.InboxPreviewForm_Load);
            this.inboxInfoPanel.PanelContainer.ResumeLayout(false);
            this.inboxInfoPanel.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inboxInfoPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxDateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxHostLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxLoginLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inboxGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadCollapsiblePanel inboxInfoPanel;
        private Telerik.WinControls.UI.RadLabel inboxDateLabel;
        private Telerik.WinControls.UI.RadLabel inboxHostLabel;
        private Telerik.WinControls.UI.RadLabel inboxLoginLabel;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
        private Telerik.WinControls.UI.RadGridView inboxGridView;
    }
}
