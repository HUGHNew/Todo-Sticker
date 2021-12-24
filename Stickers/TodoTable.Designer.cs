
namespace Stickers
{
    partial class TodoTable
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Todo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Done = new System.Windows.Forms.ToolStripMenuItem();
            this.Abort = new System.Windows.Forms.ToolStripMenuItem();
            this.TopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmitAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCol = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCol = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.RowMenu.SuspendLayout();
            this.ColMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AllowUserToOrderColumns = true;
            this.Table.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Todo,
            this.DDL,
            this.SubmitAddr});
            this.Table.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle2;
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.GridColor = System.Drawing.Color.DarkGray;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.RowTemplate.Height = 25;
            this.Table.Size = new System.Drawing.Size(305, 301);
            this.Table.TabIndex = 0;
            this.Table.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ColumnMenu);
            // 
            // Todo
            // 
            this.Todo.ContextMenuStrip = this.RowMenu;
            this.Todo.Frozen = true;
            this.Todo.HeaderText = "Todo";
            this.Todo.Name = "Todo";
            // 
            // RowMenu
            // 
            this.RowMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Done,
            this.Abort,
            this.TopItem});
            this.RowMenu.Name = "RowtMenu";
            this.RowMenu.Size = new System.Drawing.Size(101, 70);
            // 
            // Done
            // 
            this.Done.Image = global::Stickers.Properties.Resources.Check;
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(100, 22);
            this.Done.Text = "完成";
            // 
            // Abort
            // 
            this.Abort.Image = global::Stickers.Properties.Resources.Abort;
            this.Abort.Name = "Abort";
            this.Abort.Size = new System.Drawing.Size(100, 22);
            this.Abort.Text = "放弃";
            // 
            // TopItem
            // 
            this.TopItem.Image = global::Stickers.Properties.Resources.Top;
            this.TopItem.Name = "TopItem";
            this.TopItem.Size = new System.Drawing.Size(100, 22);
            this.TopItem.Text = "顶置";
            // 
            // DDL
            // 
            this.DDL.ContextMenuStrip = this.RowMenu;
            this.DDL.HeaderText = "DDL";
            this.DDL.Name = "DDL";
            // 
            // SubmitAddr
            // 
            this.SubmitAddr.ContextMenuStrip = this.RowMenu;
            this.SubmitAddr.HeaderText = "Addr";
            this.SubmitAddr.Name = "SubmitAddr";
            // 
            // ColMenu
            // 
            this.ColMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCol,
            this.DelCol});
            this.ColMenu.Name = "ColMenu";
            this.ColMenu.Size = new System.Drawing.Size(125, 48);
            // 
            // AddCol
            // 
            this.AddCol.Image = global::Stickers.Properties.Resources.AddColumn;
            this.AddCol.Name = "AddCol";
            this.AddCol.Size = new System.Drawing.Size(124, 22);
            this.AddCol.Text = "新增一列";
            // 
            // DelCol
            // 
            this.DelCol.Image = global::Stickers.Properties.Resources.RmColumn;
            this.DelCol.Name = "DelCol";
            this.DelCol.Size = new System.Drawing.Size(124, 22);
            this.DelCol.Text = "删除该列";
            // 
            // TodoTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table);
            this.Name = "TodoTable";
            this.Size = new System.Drawing.Size(305, 301);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.RowMenu.ResumeLayout(false);
            this.ColMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ContextMenuStrip ColMenu;
        private System.Windows.Forms.ToolStripMenuItem AddCol;
        private System.Windows.Forms.ToolStripMenuItem DelCol;
        private System.Windows.Forms.ContextMenuStrip RowMenu;
        private System.Windows.Forms.ToolStripMenuItem Done;
        private System.Windows.Forms.ToolStripMenuItem Abort;
        private System.Windows.Forms.ToolStripMenuItem TopItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Todo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmitAddr;
    }
}
