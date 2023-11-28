using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniProject
{
    public partial class CuaHangA : Form
    {
        DataClasses2DataContext db;
        QuanLyCuaHang ql;
        public CuaHangA(int x)
        {
            InitializeComponent();
            if (x==1)
            {
                label8.Text = "Cua hang siu cap vip pro";
            }
            else
            {
                label8.Text = "Cua hang dom";
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CuaHangA_Load(object sender, EventArgs e)
        {
            ql = new QuanLyCuaHang();
            db = new DataClasses2DataContext();
            var list = (from s in db.QuanLyCuaHangs select s).ToList();
            dataGridView1.DataSource = list;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                ql.Seri = textBox1.Text;
                ql.Producer = textBox2.Text;
                ql.Number = Convert.ToInt32(textBox3.Text);
                ql.Color = textBox4.Text;
                ql.DTProduct = dateTimePicker1.Value;
                ql.Price = Convert.ToDouble(textBox6.Text);
                ql.DTBought = dateTimePicker2.Value;
                db.QuanLyCuaHangs.InsertOnSubmit(ql);
                
                db.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Cant add because it already exist or bug happened :>!");
            }
            //finally { db.SubmitChanges(); }
            CuaHangA_Load(sender, e);
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                ql = db.QuanLyCuaHangs.Where(s => s.Seri == textBox1.Text).Single();
                ql.Seri = textBox1.Text;
                ql.Producer = textBox2.Text;
                ql.Number = Convert.ToInt32(textBox3.Text);
                ql.Color = textBox4.Text;
                ql.DTProduct = dateTimePicker1.Value;
                ql.Price = Convert.ToDouble(textBox6.Text);
                db.QuanLyCuaHangs.InsertOnSubmit(ql);
                db.SubmitChanges();
                CuaHangA_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Em rot mon roi ~");
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                ql = db.QuanLyCuaHangs.Where(s => s.Seri == textBox1.Text).Single();
                /* nv.Id = Convert.ToInt32(textBox1.Text);
                 nv.Tên = textBox2.Text;
                 nv.Phòng = textBox3.Text;
                 nv.Lương = Convert.ToInt32(textBox4.Text);
                 nv.Tuổi = Convert.ToInt32(textBox5.Text);*/
                db.QuanLyCuaHangs.DeleteOnSubmit(ql);
                db.SubmitChanges();
                CuaHangA_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Em khong biet nua!~~");
            }
        }
    }
}
