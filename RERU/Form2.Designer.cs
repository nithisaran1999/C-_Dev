namespace RERU
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.หนาหลกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.กจกรรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมกจกรรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลบกจกรรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.คปองToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เำToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.หนาหลกToolStripMenuItem,
            this.กจกรรมToolStripMenuItem,
            this.คปองToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // หนาหลกToolStripMenuItem
            // 
            this.หนาหลกToolStripMenuItem.Name = "หนาหลกToolStripMenuItem";
            this.หนาหลกToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.หนาหลกToolStripMenuItem.Text = "หน้าหลัก";
            // 
            // กจกรรมToolStripMenuItem
            // 
            this.กจกรรมToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เพมกจกรรมToolStripMenuItem,
            this.ลบกจกรรมToolStripMenuItem});
            this.กจกรรมToolStripMenuItem.Name = "กจกรรมToolStripMenuItem";
            this.กจกรรมToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.กจกรรมToolStripMenuItem.Text = "กิจกรรม";
            // 
            // เพมกจกรรมToolStripMenuItem
            // 
            this.เพมกจกรรมToolStripMenuItem.Name = "เพมกจกรรมToolStripMenuItem";
            this.เพมกจกรรมToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.เพมกจกรรมToolStripMenuItem.Text = "เพิ่มกิจกรรม";
            this.เพมกจกรรมToolStripMenuItem.Click += new System.EventHandler(this.เพมกจกรรมToolStripMenuItem_Click);
            // 
            // ลบกจกรรมToolStripMenuItem
            // 
            this.ลบกจกรรมToolStripMenuItem.Name = "ลบกจกรรมToolStripMenuItem";
            this.ลบกจกรรมToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ลบกจกรรมToolStripMenuItem.Text = "ลบกิจกรรม";
            this.ลบกจกรรมToolStripMenuItem.Click += new System.EventHandler(this.ลบกจกรรมToolStripMenuItem_Click);
            // 
            // คปองToolStripMenuItem
            // 
            this.คปองToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.เำToolStripMenuItem,
            this.fToolStripMenuItem});
            this.คปองToolStripMenuItem.Name = "คปองToolStripMenuItem";
            this.คปองToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.คปองToolStripMenuItem.Text = "คูปอง";
            // 
            // เำToolStripMenuItem
            // 
            this.เำToolStripMenuItem.Name = "เำToolStripMenuItem";
            this.เำToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.เำToolStripMenuItem.Text = "เพิ่ม Coupon";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.fToolStripMenuItem.Text = "Coupon ทั้งหมด";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 689);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "ระบบลงทะเบียนกิจกรรม [Administrator]";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem หนาหลกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem กจกรรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมกจกรรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลบกจกรรมToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem คปองToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เำToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}