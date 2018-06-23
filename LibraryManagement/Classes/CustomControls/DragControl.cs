﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LibraryManagement
{
    class DragControl : Component
    {
        private Control handleControl;

        public Control SelectControl
        {
            get { return handleControl; }
            set
            {
                handleControl = value;
                handleControl.MouseDown += new MouseEventHandler(DragForm_MouseDown);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left;

            if (flag)
            {
                ReleaseCapture();
                SendMessage(SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
