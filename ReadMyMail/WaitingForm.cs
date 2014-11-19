using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace ReadMyMail
{
    public partial class WaitingForm : Telerik.WinControls.UI.RadForm
    {
        //private static Thread WaitingThread;
        //private static WaitingForm waitingForm;

        public WaitingForm()
        {
            InitializeComponent();

            waitingBar.ShowText = true;
            waitingBar.Text = "Loading... Please Wait";
            waitingBar.WaitingBarElement.TextElement.TextAlignment = ContentAlignment.MiddleCenter;
            waitingBar.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.Dash;
            var dash = waitingBar.WaitingBarElement.SeparatorElement;
            dash.NumberOfColors = 2;
            dash.BackColor = Color.Orange;
            dash.BackColor2 = Color.Yellow;
            dash.SweepAngle = 45;
            dash.StepWidth = 15;
            dash.SeparatorWidth = 10;
            dash.GradientPercentage = 0.25f;

            //waitingBar.StartWaiting();
        }

        //public static void ShowForm()
        //{
        //    WaitingThread = new Thread(ThreadTask) {IsBackground = false};
        //    WaitingThread.Start();
        //}

        //private static void ThreadTask(object owner)
        //{
        //    waitingForm = new WaitingForm
        //    {
        //        ShowInTaskbar = false,
        //        Owner = (Form) owner,
        //        FormBorderStyle = FormBorderStyle.None,
        //        ControlBox = false,
        //        TopMost = true,
        //        StartPosition = FormStartPosition.Manual
        //    };

        //    Application.Run(waitingForm);
        //}

        //public static void CloseDialogDown()
        //{
        //    Application.ExitThread();
        //}

        //public static void CloseForm()
        //{
        //    while (waitingForm == null || !waitingForm.IsHandleCreated)
        //    {
        //        Thread.Sleep(10);
        //    }
        //    var mi = new MethodInvoker(CloseDialogDown);
        //    waitingForm.Invoke(mi);
        //}

    }
}
