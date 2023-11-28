using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.Show();
        }

        private void cuaHang1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuaHangA cuaHang = new CuaHangA(1);
            cuaHang.Show();
        }

        private void cuaHang2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuaHangA cuaHang = new CuaHangA(2);
            cuaHang.Show();
        }

        private void quanLyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tinhLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhLuong tinhLuong = new TinhLuong();  
            tinhLuong.Show();
        }

        private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Income_caculate income_Caculate = new Income_caculate();
            income_Caculate.Show();
        }

        private void outcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
