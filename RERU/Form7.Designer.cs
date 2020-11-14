
namespace RERU
{
    partial class Form7
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
            this.หนาเเรกToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ลงทะเบยนกจกรรมToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.หนาเเรกToolStripMenuItem,
            this.ลงทะเบยนกจกรรมToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // หนาเเรกToolStripMenuItem
            // 
            this.หนาเเรกToolStripMenuItem.Name = "หนาเเรกToolStripMenuItem";
            this.หนาเเรกToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.หนาเเรกToolStripMenuItem.Text = "หน้าเเรก";
            // 
            // ลงทะเบยนกจกรรมToolStripMenuItem
            // 
            this.ลงทะเบยนกจกรรมToolStripMenuItem.Name = "ลงทะเบยนกจกรรมToolStripMenuItem";
            this.ลงทะเบยนกจกรรมToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.ลงทะเบยนกจกรรมToolStripMenuItem.Text = "ลงทะเบียนกิจกรรม";
            this.ลงทะเบยนกจกรรมToolStripMenuItem.Click += new System.EventHandler(this.ลงทะเบยนกจกรรมToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 502);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "ระบบกิจกรรม [นักศึกษา]";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem หนาเเรกToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ลงทะเบยนกจกรรมToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}