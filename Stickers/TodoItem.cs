using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stickers {
    public partial class TodoItem : UserControl {
        public TodoItem() {
            InitializeComponent();
            InitTime = DateTime.Now;
            Done = false;
        }
        private readonly DateTime InitTime;
        private bool Done;
        public DateTime Initialization { get => InitTime; }
        public bool TaskDone { get => Done; }
        private void ToggleTask(object sender, EventArgs e) {
            Done = !Done;
            this.CheckButton.Image =Done? Properties.Resources.CircleCheckBlack: Properties.Resources.CircleBlack;
        }
    }
}
