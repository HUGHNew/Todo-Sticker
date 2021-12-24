
namespace Stickers
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TodoBtn = new System.Windows.Forms.Button();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.Aborted = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TodoBtn
            // 
            this.TodoBtn.FlatAppearance.BorderSize = 0;
            this.TodoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodoBtn.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TodoBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TodoBtn.Location = new System.Drawing.Point(12, 12);
            this.TodoBtn.Name = "TodoBtn";
            this.TodoBtn.Size = new System.Drawing.Size(78, 35);
            this.TodoBtn.TabIndex = 1;
            this.TodoBtn.Text = "Todo";
            this.TodoBtn.UseVisualStyleBackColor = true;
            // 
            // DoneBtn
            // 
            this.DoneBtn.FlatAppearance.BorderSize = 0;
            this.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBtn.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DoneBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DoneBtn.Location = new System.Drawing.Point(96, 12);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(78, 35);
            this.DoneBtn.TabIndex = 2;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = true;
            // 
            // Aborted
            // 
            this.Aborted.FlatAppearance.BorderSize = 0;
            this.Aborted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aborted.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Aborted.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Aborted.Location = new System.Drawing.Point(12, 47);
            this.Aborted.Name = "Aborted";
            this.Aborted.Size = new System.Drawing.Size(162, 28);
            this.Aborted.TabIndex = 4;
            this.Aborted.Text = "Aborted";
            this.Aborted.UseVisualStyleBackColor = true;
            // 
            // Tip
            // 
            this.Tip.AutoPopDelay = 5000;
            this.Tip.BackColor = System.Drawing.SystemColors.Desktop;
            this.Tip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Tip.InitialDelay = 50;
            this.Tip.ReshowDelay = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.Aborted);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.TodoBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Opacity = 0.6D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TodoTable";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button TodoBtn;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.Button Aborted;
        private System.Windows.Forms.ToolTip Tip;
    }
}

