
namespace Stickers {
    partial class TodoItem {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ItemTableLine = new System.Windows.Forms.TableLayoutPanel();
            this.CheckButton = new System.Windows.Forms.Button();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ItemTextBox = new System.Windows.Forms.TextBox();
            this.ItemTableLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemTableLine
            // 
            this.ItemTableLine.ColumnCount = 3;
            this.ItemTableLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ItemTableLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLine.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.ItemTableLine.Controls.Add(this.CheckButton, 0, 0);
            this.ItemTableLine.Controls.Add(this.AbortButton, 2, 0);
            this.ItemTableLine.Controls.Add(this.ItemTextBox, 1, 0);
            this.ItemTableLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemTableLine.Location = new System.Drawing.Point(0, 0);
            this.ItemTableLine.Name = "ItemTableLine";
            this.ItemTableLine.RowCount = 1;
            this.ItemTableLine.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ItemTableLine.Size = new System.Drawing.Size(255, 24);
            this.ItemTableLine.TabIndex = 0;
            // 
            // CheckButton
            // 
            this.CheckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CheckButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckButton.ForeColor = System.Drawing.Color.Transparent;
            this.CheckButton.Image = global::Stickers.Properties.Resources.CircleBlack;
            this.CheckButton.Location = new System.Drawing.Point(0, 0);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(0);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(24, 24);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.ToggleTask);
            // 
            // AbortButton
            // 
            this.AbortButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AbortButton.Image = global::Stickers.Properties.Resources.Abort;
            this.AbortButton.Location = new System.Drawing.Point(231, 0);
            this.AbortButton.Margin = new System.Windows.Forms.Padding(0);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(24, 24);
            this.AbortButton.TabIndex = 1;
            this.AbortButton.UseVisualStyleBackColor = true;
            // 
            // ItemTextBox
            // 
            this.ItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ItemTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ItemTextBox.Location = new System.Drawing.Point(24, 4);
            this.ItemTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ItemTextBox.Name = "ItemTextBox";
            this.ItemTextBox.Size = new System.Drawing.Size(207, 16);
            this.ItemTextBox.TabIndex = 2;
            this.ItemTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TodoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ItemTableLine);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TodoItem";
            this.Size = new System.Drawing.Size(255, 24);
            this.ItemTableLine.ResumeLayout(false);
            this.ItemTableLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ItemTableLine;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button AbortButton;
        private System.Windows.Forms.TextBox ItemTextBox;
    }
}
