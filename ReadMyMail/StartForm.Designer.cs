namespace ReadMyMail
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.tileGroupElement1 = new Telerik.WinControls.UI.TileGroupElement();
            this.outlookLiveTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.liveTileFrameElement1 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.liveTileFrameElement2 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.liveTileFrameElement3 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.googleLiveTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.liveTileFrameElement6 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.liveTileFrameElement7 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.tileGroupElement2 = new Telerik.WinControls.UI.TileGroupElement();
            this.credentialsLiveTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.liveTileFrameElement4 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.liveTileFrameElement5 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.tileGroupElement3 = new Telerik.WinControls.UI.TileGroupElement();
            this.contactLiveTile = new Telerik.WinControls.UI.RadLiveTileElement();
            this.liveTileFrameElement8 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.liveTileFrameElement9 = new Telerik.WinControls.UI.LiveTileFrameElement();
            this.signatureLinkLabel = new System.Windows.Forms.LinkLabel();
            this.progressBar = new Telerik.WinControls.UI.RadWaitingBar();
            this.waitCancelButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitCancelButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Location = new System.Drawing.Point(2, 31);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(461, 287);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "Start";
            this.radPageView1.ThemeName = "ControlDefault";
            ((Telerik.WinControls.UI.RadPageViewLabelElement)(this.radPageView1.GetChildAt(0).GetChildAt(2))).Text = "Start";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.radPanorama1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(40F, 28F);
            this.radPageViewPage1.Location = new System.Drawing.Point(10, 37);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(440, 239);
            this.radPageViewPage1.Text = "Start";
            // 
            // radPanorama1
            // 
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.tileGroupElement1,
            this.tileGroupElement2,
            this.tileGroupElement3});
            this.radPanorama1.Location = new System.Drawing.Point(3, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.ShowGroups = true;
            this.radPanorama1.Size = new System.Drawing.Size(511, 246);
            this.radPanorama1.TabIndex = 0;
            this.radPanorama1.Text = "radPanorama1";
            this.radPanorama1.ThemeName = "ControlDefault";
            // 
            // tileGroupElement1
            // 
            this.tileGroupElement1.AccessibleDescription = "tileGroupElement1";
            this.tileGroupElement1.AccessibleName = "tileGroupElement1";
            this.tileGroupElement1.Font = new System.Drawing.Font("Lindsey", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileGroupElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.outlookLiveTile,
            this.googleLiveTile});
            this.tileGroupElement1.Name = "tileGroupElement1";
            this.tileGroupElement1.RowsCount = 2;
            this.tileGroupElement1.Text = "Email";
            this.tileGroupElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // outlookLiveTile
            // 
            this.outlookLiveTile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.outlookLiveTile.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outlookLiveTile.BorderBottomWidth = 3F;
            this.outlookLiveTile.BorderInnerColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.outlookLiveTile.ContentChangeInterval = 1000;
            this.outlookLiveTile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.liveTileFrameElement1,
            this.liveTileFrameElement2,
            this.liveTileFrameElement3});
            this.outlookLiveTile.Name = "outlookLiveTile";
            this.outlookLiveTile.Shape = null;
            this.outlookLiveTile.Text = "";
            this.outlookLiveTile.TransitionType = Telerik.WinControls.UI.ContentTransitionType.SlideRight;
            this.outlookLiveTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.outlookLiveTile.Click += new System.EventHandler(this.outlookLiveTile_Click);
            // 
            // liveTileFrameElement1
            // 
            this.liveTileFrameElement1.AccessibleDescription = "Hotmail";
            this.liveTileFrameElement1.AccessibleName = "Hotmail";
            this.liveTileFrameElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement1.Font = new System.Drawing.Font("Segoe Condensed", 18F, System.Drawing.FontStyle.Italic);
            this.liveTileFrameElement1.Name = "liveTileFrameElement1";
            this.liveTileFrameElement1.Text = "Hotmail";
            this.liveTileFrameElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement2
            // 
            this.liveTileFrameElement2.AccessibleDescription = "Outlook";
            this.liveTileFrameElement2.AccessibleName = "Outlook";
            this.liveTileFrameElement2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement2.Name = "liveTileFrameElement2";
            this.liveTileFrameElement2.Text = "Outlook";
            this.liveTileFrameElement2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement3
            // 
            this.liveTileFrameElement3.AccessibleDescription = "MSN";
            this.liveTileFrameElement3.AccessibleName = "MSN";
            this.liveTileFrameElement3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement3.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.liveTileFrameElement3.Name = "liveTileFrameElement3";
            this.liveTileFrameElement3.Text = "MSN";
            this.liveTileFrameElement3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // googleLiveTile
            // 
            this.googleLiveTile.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.googleLiveTile.BorderBottomWidth = 3F;
            this.googleLiveTile.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            this.googleLiveTile.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(4)))));
            this.googleLiveTile.BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(50)))), ((int)(((byte)(245)))));
            this.googleLiveTile.BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(248)))), ((int)(((byte)(59)))));
            this.googleLiveTile.BorderGradientStyle = Telerik.WinControls.GradientStyles.Gel;
            this.googleLiveTile.BorderInnerColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(2)))), ((int)(((byte)(43)))));
            this.googleLiveTile.ContentChangeInterval = 1000;
            this.googleLiveTile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.liveTileFrameElement6,
            this.liveTileFrameElement7});
            this.googleLiveTile.Name = "googleLiveTile";
            this.googleLiveTile.Row = 1;
            this.googleLiveTile.Text = "";
            this.googleLiveTile.TransitionType = Telerik.WinControls.UI.ContentTransitionType.SlideUp;
            this.googleLiveTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.googleLiveTile.Click += new System.EventHandler(this.googleLiveTile_Click);
            // 
            // liveTileFrameElement6
            // 
            this.liveTileFrameElement6.AccessibleDescription = "Google";
            this.liveTileFrameElement6.AccessibleName = "Google";
            this.liveTileFrameElement6.BorderBottomWidth = 10F;
            this.liveTileFrameElement6.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            this.liveTileFrameElement6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(5)))), ((int)(((byte)(44)))));
            this.liveTileFrameElement6.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(0)))), ((int)(((byte)(230)))));
            this.liveTileFrameElement6.BorderColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(255)))), ((int)(((byte)(5)))));
            this.liveTileFrameElement6.BorderColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(236)))), ((int)(((byte)(17)))));
            this.liveTileFrameElement6.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.liveTileFrameElement6.Name = "liveTileFrameElement6";
            this.liveTileFrameElement6.Text = "Google";
            this.liveTileFrameElement6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement7
            // 
            this.liveTileFrameElement7.AccessibleDescription = "Gmail";
            this.liveTileFrameElement7.AccessibleName = "Gmail";
            this.liveTileFrameElement7.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement7.Font = new System.Drawing.Font("Miramonte", 15.75F);
            this.liveTileFrameElement7.Name = "liveTileFrameElement7";
            this.liveTileFrameElement7.Text = "Gmail";
            this.liveTileFrameElement7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // tileGroupElement2
            // 
            this.tileGroupElement2.AccessibleDescription = "tileGroupElement2";
            this.tileGroupElement2.AccessibleName = "tileGroupElement2";
            this.tileGroupElement2.AutoSize = false;
            this.tileGroupElement2.Bounds = new System.Drawing.Rectangle(0, 0, 200, 153);
            this.tileGroupElement2.Font = new System.Drawing.Font("Lindsey", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileGroupElement2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.credentialsLiveTile});
            this.tileGroupElement2.Name = "tileGroupElement2";
            this.tileGroupElement2.Text = "Credentials";
            this.tileGroupElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // credentialsLiveTile
            // 
            this.credentialsLiveTile.AutoSize = false;
            this.credentialsLiveTile.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.credentialsLiveTile.BorderBottomWidth = 3F;
            this.credentialsLiveTile.Bounds = new System.Drawing.Rectangle(0, 0, 166, 90);
            this.credentialsLiveTile.ContentChangeInterval = 1000;
            this.credentialsLiveTile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.liveTileFrameElement4,
            this.liveTileFrameElement5});
            this.credentialsLiveTile.Name = "credentialsLiveTile";
            this.credentialsLiveTile.Text = "";
            this.credentialsLiveTile.TransitionType = Telerik.WinControls.UI.ContentTransitionType.SlideLeft;
            this.credentialsLiveTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.credentialsLiveTile.Click += new System.EventHandler(this.credentialsLiveTile_Click);
            // 
            // liveTileFrameElement4
            // 
            this.liveTileFrameElement4.AccessibleDescription = "Email Address";
            this.liveTileFrameElement4.AccessibleName = "Email Address";
            this.liveTileFrameElement4.BorderBoxStyle = Telerik.WinControls.BorderBoxStyle.FourBorders;
            this.liveTileFrameElement4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement4.Font = new System.Drawing.Font("Eras Bold ITC", 14.25F);
            this.liveTileFrameElement4.Name = "liveTileFrameElement4";
            this.liveTileFrameElement4.Text = "Email Address";
            this.liveTileFrameElement4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement5
            // 
            this.liveTileFrameElement5.AccessibleDescription = "Password";
            this.liveTileFrameElement5.AccessibleName = "Password";
            this.liveTileFrameElement5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement5.Font = new System.Drawing.Font("Eras Bold ITC", 14.25F);
            this.liveTileFrameElement5.Name = "liveTileFrameElement5";
            this.liveTileFrameElement5.Text = "Password";
            this.liveTileFrameElement5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // tileGroupElement3
            // 
            this.tileGroupElement3.AccessibleDescription = "Contact";
            this.tileGroupElement3.AccessibleName = "Contact";
            this.tileGroupElement3.AutoSize = false;
            this.tileGroupElement3.Bounds = new System.Drawing.Rectangle(0, 0, 107, 152);
            this.tileGroupElement3.Font = new System.Drawing.Font("Lindsey", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tileGroupElement3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.contactLiveTile});
            this.tileGroupElement3.Name = "tileGroupElement3";
            this.tileGroupElement3.Text = "Contact";
            this.tileGroupElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // contactLiveTile
            // 
            this.contactLiveTile.AnimationFrames = 60;
            this.contactLiveTile.ContentChangeInterval = 2000;
            this.contactLiveTile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.liveTileFrameElement8,
            this.liveTileFrameElement9});
            this.contactLiveTile.Name = "contactLiveTile";
            this.contactLiveTile.Text = "";
            this.contactLiveTile.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement8
            // 
            this.liveTileFrameElement8.AccessibleDescription = "Support";
            this.liveTileFrameElement8.AccessibleName = "Support";
            this.liveTileFrameElement8.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement8.Name = "liveTileFrameElement8";
            this.liveTileFrameElement8.Text = "Support";
            this.liveTileFrameElement8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // liveTileFrameElement9
            // 
            this.liveTileFrameElement9.AccessibleDescription = "Donate";
            this.liveTileFrameElement9.AccessibleName = "Donate";
            this.liveTileFrameElement9.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(244)))), ((int)(((byte)(142)))));
            this.liveTileFrameElement9.BorderBottomWidth = 5F;
            this.liveTileFrameElement9.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.liveTileFrameElement9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.liveTileFrameElement9.Name = "liveTileFrameElement9";
            this.liveTileFrameElement9.Text = "Donate";
            this.liveTileFrameElement9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.liveTileFrameElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // signatureLinkLabel
            // 
            this.signatureLinkLabel.AutoSize = true;
            this.signatureLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signatureLinkLabel.Font = new System.Drawing.Font("Buxton Sketch", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signatureLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.signatureLinkLabel.Location = new System.Drawing.Point(423, 317);
            this.signatureLinkLabel.Name = "signatureLinkLabel";
            this.signatureLinkLabel.Size = new System.Drawing.Size(40, 15);
            this.signatureLinkLabel.TabIndex = 1;
            this.signatureLinkLabel.TabStop = true;
            this.signatureLinkLabel.Text = "No Flaw";
            this.signatureLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signatureLinkLabel.MouseHover += new System.EventHandler(this.signatureLinkLabel_MouseHover);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(53, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(323, 23);
            this.progressBar.TabIndex = 0;
            // 
            // waitCancelButton
            // 
            this.waitCancelButton.Location = new System.Drawing.Point(382, 1);
            this.waitCancelButton.Name = "waitCancelButton";
            this.waitCancelButton.Size = new System.Drawing.Size(81, 24);
            this.waitCancelButton.TabIndex = 2;
            this.waitCancelButton.Text = "Cancel";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 328);
            this.Controls.Add(this.waitCancelButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.signatureLinkLabel);
            this.Controls.Add(this.radPageView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StartForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Read My Email";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitCancelButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.TileGroupElement tileGroupElement1;
        private Telerik.WinControls.UI.TileGroupElement tileGroupElement2;
        private Telerik.WinControls.UI.RadLiveTileElement outlookLiveTile;
        private Telerik.WinControls.UI.RadLiveTileElement credentialsLiveTile;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement4;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement5;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement1;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement2;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement3;
        private Telerik.WinControls.UI.RadLiveTileElement googleLiveTile;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement6;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement7;
        private Telerik.WinControls.UI.TileGroupElement tileGroupElement3;
        private Telerik.WinControls.UI.RadLiveTileElement contactLiveTile;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement8;
        private Telerik.WinControls.UI.LiveTileFrameElement liveTileFrameElement9;
        private System.Windows.Forms.LinkLabel signatureLinkLabel;
        private Telerik.WinControls.UI.RadWaitingBar progressBar;
        private Telerik.WinControls.UI.RadButton waitCancelButton;
    }
}
