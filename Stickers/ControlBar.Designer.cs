
namespace Stickers
{
    partial class ControlBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ControlsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PinBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.ControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.BackColor = System.Drawing.Color.Black;
            this.ControlsPanel.Controls.Add(this.PinBtn);
            this.ControlsPanel.Controls.Add(this.UpdateBtn);
            this.ControlsPanel.Controls.Add(this.Settings);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(120, 40);
            this.ControlsPanel.TabIndex = 4;
            // 
            // PinBtn
            // 
            this.PinBtn.FlatAppearance.BorderSize = 0;
            this.PinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PinBtn.Image = global::Stickers.Properties.Resources.Pin;
            this.PinBtn.Location = new System.Drawing.Point(3, 3);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(32, 32);
            this.PinBtn.TabIndex = 0;
            this.PinBtn.UseVisualStyleBackColor = true;
            this.PinBtn.Click += new System.EventHandler(this.PinStatusChange);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Image = global::Stickers.Properties.Resources.Update;
            this.UpdateBtn.Location = new System.Drawing.Point(41, 3);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(32, 32);
            this.UpdateBtn.TabIndex = 1;
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Image = global::Stickers.Properties.Resources.Setting;
            this.Settings.Location = new System.Drawing.Point(79, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(32, 32);
            this.Settings.TabIndex = 2;
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // ControlBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlsPanel);
            this.Name = "ControlBar";
            this.Size = new System.Drawing.Size(120, 40);
            this.ControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ControlsPanel;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button Settings;
    }
}
