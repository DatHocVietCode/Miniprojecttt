namespace MiniProject
{
    partial class MainForm
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
            this.quanLyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhLuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cacCuaHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuaHang1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuaHang2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outcomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loiNhuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyToolStripMenuItem,
            this.cacCuaHangToolStripMenuItem,
            this.quanLyDoanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyToolStripMenuItem
            // 
            this.quanLyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.tinhLuongToolStripMenuItem});
            this.quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            this.quanLyToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quanLyToolStripMenuItem.Text = "Quan Ly";
            this.quanLyToolStripMenuItem.Click += new System.EventHandler(this.quanLyToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.nhanVienToolStripMenuItem.Text = "Nhan Vien";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // tinhLuongToolStripMenuItem
            // 
            this.tinhLuongToolStripMenuItem.Name = "tinhLuongToolStripMenuItem";
            this.tinhLuongToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.tinhLuongToolStripMenuItem.Text = "Tinh Luong";
            this.tinhLuongToolStripMenuItem.Click += new System.EventHandler(this.tinhLuongToolStripMenuItem_Click);
            // 
            // cacCuaHangToolStripMenuItem
            // 
            this.cacCuaHangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuaHang1ToolStripMenuItem,
            this.cuaHang2ToolStripMenuItem});
            this.cacCuaHangToolStripMenuItem.Name = "cacCuaHangToolStripMenuItem";
            this.cacCuaHangToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.cacCuaHangToolStripMenuItem.Text = "Cac cua hang";
            // 
            // cuaHang1ToolStripMenuItem
            // 
            this.cuaHang1ToolStripMenuItem.Name = "cuaHang1ToolStripMenuItem";
            this.cuaHang1ToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.cuaHang1ToolStripMenuItem.Text = "Cua hang siu cap vip pro";
            this.cuaHang1ToolStripMenuItem.Click += new System.EventHandler(this.cuaHang1ToolStripMenuItem_Click);
            // 
            // cuaHang2ToolStripMenuItem
            // 
            this.cuaHang2ToolStripMenuItem.Name = "cuaHang2ToolStripMenuItem";
            this.cuaHang2ToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.cuaHang2ToolStripMenuItem.Text = "Cua hang dom";
            this.cuaHang2ToolStripMenuItem.Click += new System.EventHandler(this.cuaHang2ToolStripMenuItem_Click);
            // 
            // quanLyDoanhThuToolStripMenuItem
            // 
            this.quanLyDoanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeToolStripMenuItem,
            this.outcomeToolStripMenuItem,
            this.loiNhuanToolStripMenuItem});
            this.quanLyDoanhThuToolStripMenuItem.Name = "quanLyDoanhThuToolStripMenuItem";
            this.quanLyDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.quanLyDoanhThuToolStripMenuItem.Text = "Quan ly doanh thu";
            // 
            // incomeToolStripMenuItem
            // 
            this.incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            this.incomeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.incomeToolStripMenuItem.Text = "Income";
            this.incomeToolStripMenuItem.Click += new System.EventHandler(this.incomeToolStripMenuItem_Click);
            // 
            // outcomeToolStripMenuItem
            // 
            this.outcomeToolStripMenuItem.Name = "outcomeToolStripMenuItem";
            this.outcomeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outcomeToolStripMenuItem.Text = "Outcome";
            this.outcomeToolStripMenuItem.Click += new System.EventHandler(this.outcomeToolStripMenuItem_Click);
            // 
            // loiNhuanToolStripMenuItem
            // 
            this.loiNhuanToolStripMenuItem.Name = "loiNhuanToolStripMenuItem";
            this.loiNhuanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loiNhuanToolStripMenuItem.Text = "Loi nhuan";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhLuongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cacCuaHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuaHang1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuaHang2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outcomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loiNhuanToolStripMenuItem;
    }
}

