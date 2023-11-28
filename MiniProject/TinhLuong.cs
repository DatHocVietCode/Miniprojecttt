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
    public partial class TinhLuong : Form
    {
        QLNhanVien nv = null;
        DataClasses1DataContext data = new DataClasses1DataContext();
        public TinhLuong()
        {
            InitializeComponent();
        }
        public QLNhanVien Tim_Kiem_nv()
        {
            nv = new QLNhanVien();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Textbox is empty!", "Notice");
                textBox1.Text.Trim();
                textBox1.Clear();
                return default;
            }
            //MessageBox.Show(textBox1.Text);
            data = new DataClasses1DataContext();
            QLNhanVien result = (from s in data.QLNhanViens where s.Id == Convert.ToInt32(textBox1.Text) select s).FirstOrDefault();
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*nv = new QLNhanVien();
            if (textBox1.Text==string.Empty)
            {
                MessageBox.Show("Textbox is empty!", "Notice");
                textBox1.Text.Trim();
                textBox1.Clear();
                return;
            }
            //MessageBox.Show(textBox1.Text);
            data = new DataClasses1DataContext(); 
            var result = (from s in data.QLNhanViens where s.Id == Convert.ToInt32(textBox1.Text) select s).FirstOrDefault();*/
            var result = Tim_Kiem_nv();
            if (result == default)
            {
                MessageBox.Show("No exist!", "Notice");
                return;
            }
            else
            {
                if (result.TypeofEmployee == "Temporary")
                    label3.Text = "Luong Thang: \nLuong thang cua nhan vien thoi vu: \nNhan Vien ID: "
                                           + result.Id.ToString() + "\nNhan vien name: " + result.Tên + "\n" +
                                           (result.LươngperHour * result.HourWork).ToString();
                else
                    label3.Text = "Luong Thang: \nLuong thang cua nhan vien chinh thuc \nNhan Vien ID: "
                                           + result.Id.ToString() + "\nNhan vien name: " + result.Tên + "\n" +
                                           (result.LươngperHour * 8 * 30).ToString();
            }
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = Tim_Kiem_nv();
            if (result == default)
            {
                MessageBox.Show("No exist!", "Notice");
                return;
            }
            else
            {
                if (result.TypeofEmployee == "Temporary")
                    label3.Text = "Luong nam: \nLuong Nam cua nhan vien thoi vu: \nNhan Vien ID: " 
                        + result.Id.ToString() + "\nNhan vien name: " + result.Tên +"\n" +
                        (result.LươngperHour * result.HourWork * 24).ToString();
                else
                    label3.Text = "Luong nam: \nLuong Nam cua nhan vien chinh thuc: \nNhan Vien ID: "
                                           + result.Id.ToString() + "\nNhan vien name: " + result.Tên + "\n" +
                                           (result.LươngperHour * 8 * 30 *12).ToString();
            }
        }
    }
}
