using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Stickers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void FormLoad()
        {
            #region Button BorderColor
            TodoBtn.FlatAppearance.BorderColor = BackColor;
            DoneBtn.FlatAppearance.BorderColor = BackColor;
            Aborted.FlatAppearance.BorderColor = BackColor;
            PinBtn.FlatAppearance.BorderColor = BackColor;
            UpdateBtn.FlatAppearance.BorderColor = BackColor;
            Settings.FlatAppearance.BorderColor = BackColor;
            #endregion
        }
        void test()
        {
            
        }

        [DllImport("user32.dll")]//拖动无窗体的控件
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
    }
}
