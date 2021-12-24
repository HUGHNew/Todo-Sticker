using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stickers
{
    public partial class TodoTable : UserControl
    {
        public TodoTable()
        {
            InitializeComponent();
        }
        private void TableDataLoad(string datafile)
        {
            
        }
        private void ColumnMenu(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.ColMenu.Show(Cursor.Position);
            }
        }
    }
}
