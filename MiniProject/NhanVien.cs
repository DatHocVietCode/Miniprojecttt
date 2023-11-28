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
    public partial class NhanVien : Form
    {
        QLNhanVien nv;
        DataClasses1DataContext db;
        public NhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            nv = new QLNhanVien();
            db = new DataClasses1DataContext();
            var list = (from s in db.QLNhanViens select s).ToList();
            dataGridView1.DataSource = list;
        }
     
        private void Save_button_Click(object sender, EventArgs e)
        {
            try
            {
                nv.Id = Convert.ToInt32(textBox1.Text);
                nv.Tên = textBox2.Text;
                nv.Phòng = textBox3.Text;
                //nv.LươngperHour = Convert.ToInt32(textBox4.Text);
                nv.Tuổi = Convert.ToInt32(textBox5.Text);
                nv.HourWork = Convert.ToInt32(textBox7.Text);
                nv.TypeofEmployee = textBox8.Text;
                if (nv.TypeofEmployee == "Permanent")
                {
                    nv.LươngperHour = 30000;
                }
                else if (nv.TypeofEmployee == "Temporary")
                {
                    nv.LươngperHour = 2100;
                }
                else
                {
                    MessageBox.Show("Invalid type of employee", "Notice");
                    return;
                }

                db.QLNhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Cant add because it already exist or bug happened :>!");
            }
            //finally { db.SubmitChanges(); }
            Form1_Load(sender, e);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                nv = db.QLNhanViens.Where(s => s.Id == Convert.ToInt32(textBox1.Text)).Single();
                nv.Id = Convert.ToInt32(textBox1.Text);
                nv.Tên = textBox2.Text;
                nv.Phòng = textBox3.Text;
                //nv.LươngperHour = Convert.ToInt32(textBox4.Text);
                nv.Tuổi = Convert.ToInt32(textBox5.Text);
                nv.HourWork = Convert.ToInt32(textBox7.Text);
                nv.TypeofEmployee = textBox8.Text;
                if (nv.TypeofEmployee=="Permanent")
                {
                    nv.LươngperHour = 1000;
                }
                else if (nv.TypeofEmployee=="Temporary")
                {
                    nv.LươngperHour = 500;
                }
                else
                {
                    MessageBox.Show("Invalid type of employee", "Notice");
                    return;
                }

                db.SubmitChanges();
                Form1_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Em rot mon roi ~");
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                nv = db.QLNhanViens.Where(s => s.Id == Convert.ToInt32(textBox1.Text)).Single();
               /* nv.Id = Convert.ToInt32(textBox1.Text);
                nv.Tên = textBox2.Text;
                nv.Phòng = textBox3.Text;
                nv.Lương = Convert.ToInt32(textBox4.Text);
                nv.Tuổi = Convert.ToInt32(textBox5.Text);*/
                db.QLNhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
                Form1_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Em khong biet nua!~~");
            }
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            TimKiem form2 = new TimKiem();
            form2.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
