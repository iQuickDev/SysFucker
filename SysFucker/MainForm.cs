using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace SysFucker
{
    public partial class MainForm : Form
    {
        // make form click through
        private enum GetWindowLong
        {
            GWL_EXSTYLE = -20
        }

        private enum ExtendedWindowStyles
        {
            WS_EX_TRANSPARENT = 0x20,
            WS_EX_LAYERED = 0x80000
        }

        private enum LayeredWindowAttributes
        {
            LWA_COLORKEY = 0x1,
            LWA_ALPHA = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        private static extern int User32_GetWindowLong(IntPtr hWnd, GetWindowLong nIndex);

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        private static extern int User32_SetWindowLong(IntPtr hWnd, GetWindowLong nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern bool User32_SetLayeredWindowAttributes(IntPtr hWnd, int crKey, byte bAlpha, LayeredWindowAttributes dwFlags);

        public MainForm()
        {
            InitializeComponent();
            //DisplayRotator.Rotate(1, DisplayRotator.Orientations.DEGREES_CW_270);
            BrightnessController.SetMonitorBrightness(this.Handle, 1);
            NotificationSender.sendRandomNotification();
            MsgBoxSender.SpawnMsg(1);
            DisplayRotator.ResetAllRotations();
        }

        private void onClose(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void handleKeyCombo(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Alt && e.KeyCode == Keys.Delete)
            {
                MessageBox.Show("lmfao");
                e.Handled = true;
            }
        }
    }
}
