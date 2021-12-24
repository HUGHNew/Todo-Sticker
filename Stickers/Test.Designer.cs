
namespace Stickers
{
    partial class Test
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
            this.todoItem1 = new Stickers.TodoItem();
            this.SuspendLayout();
            // 
            // todoItem1
            // 
            this.todoItem1.BackColor = System.Drawing.Color.Transparent;
            this.todoItem1.Location = new System.Drawing.Point(21, 22);
            this.todoItem1.Margin = new System.Windows.Forms.Padding(0);
            this.todoItem1.Name = "todoItem1";
            this.todoItem1.Size = new System.Drawing.Size(255, 24);
            this.todoItem1.TabIndex = 5;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 436);
            this.Controls.Add(this.todoItem1);
            this.IsMdiContainer = true;
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);

        }

        #endregion
        private TodoItem todoItem1;
    }
}