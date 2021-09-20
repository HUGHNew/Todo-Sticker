
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TodoPanel = new System.Windows.Forms.Panel();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.TodoBtn = new System.Windows.Forms.Button();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.ControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PinBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Aborted = new System.Windows.Forms.Button();
            this.Tip = new System.Windows.Forms.ToolTip(this.components);
            this.TodoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodoPanel
            // 
            this.TodoPanel.AutoSize = true;
            this.TodoPanel.Controls.Add(this.DataGrid);
            this.TodoPanel.Location = new System.Drawing.Point(0, 75);
            this.TodoPanel.Name = "TodoPanel";
            this.TodoPanel.Size = new System.Drawing.Size(300, 353);
            this.TodoPanel.TabIndex = 0;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToOrderColumns = true;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowTemplate.Height = 25;
            this.DataGrid.Size = new System.Drawing.Size(250, 350);
            this.DataGrid.TabIndex = 0;
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
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.PinBtn);
            this.ControlsPanel.Controls.Add(this.UpdateBtn);
            this.ControlsPanel.Controls.Add(this.Settings);
            this.ControlsPanel.Location = new System.Drawing.Point(180, 12);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(120, 42);
            this.ControlsPanel.TabIndex = 3;
            // 
            // PinBtn
            // 
            this.PinBtn.FlatAppearance.BorderSize = 0;
            this.PinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinBtn.Image = ((System.Drawing.Image)(resources.GetObject("PinBtn.Image")));
            this.PinBtn.Location = new System.Drawing.Point(3, 3);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(32, 32);
            this.PinBtn.TabIndex = 0;
            this.Tip.SetToolTip(this.PinBtn, "置顶");
            this.PinBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Image = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.Image")));
            this.UpdateBtn.Location = new System.Drawing.Point(41, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(32, 32);
            this.UpdateBtn.TabIndex = 1;
            this.Tip.SetToolTip(this.UpdateBtn, "更新");
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.Location = new System.Drawing.Point(79, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(32, 32);
            this.Settings.TabIndex = 2;
            this.Tip.SetToolTip(this.Settings, "设置\r\n");
            this.Settings.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.DoneBtn);
            this.Controls.Add(this.TodoBtn);
            this.Controls.Add(this.TodoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Opacity = 0.6D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TodoTable";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.TodoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TodoPanel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button TodoBtn;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.FlowLayoutPanel ControlsPanel;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Aborted;
        private System.Windows.Forms.ToolTip Tip;
    }
}

