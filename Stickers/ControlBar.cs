using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stickers
{
    public partial class ControlBar : UserControl
    {
        public ControlBar()
        {
            InitializeComponent();
        }
        private static bool IsBtnPinned = false;
        private System.Drawing.Bitmap JPG_PIN=> Properties.Resources.Pin;
        private System.Drawing.Bitmap JPG_PINNED => Properties.Resources.Pinned;
        private void PinStatusChange(object sender, EventArgs e)
        {
            void Pin(bool top) => (TopLevelControl as Form).TopMost = top;

            if (IsBtnPinned) // pinned now
            {
                PinBtn.Image = JPG_PIN; // unlock
                Pin(false);
            }
            else // not pin new
            {
                PinBtn.Image = JPG_PINNED; // lock
                Pin(true);
            }IsBtnPinned = !IsBtnPinned;
        }
    }
}
