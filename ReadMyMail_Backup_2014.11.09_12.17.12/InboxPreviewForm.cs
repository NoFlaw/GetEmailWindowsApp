using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ReadMyMail
{
    public partial class InboxPreviewForm : Telerik.WinControls.UI.RadForm
    {
        public InboxPreviewForm()
        {
            InitializeComponent();
        }

        private void InboxPreviewForm_Load(object sender, EventArgs e)
        {
            inboxDateLabel.Text = string.Empty;
            inboxHostLabel.Text = string.Empty;
            inboxLoginLabel.Text = string.Empty;
        }
    }
}
