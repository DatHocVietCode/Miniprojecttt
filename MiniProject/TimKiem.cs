using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class TimKiem : Form
    {
        static QLNhanVien nv = new QLNhanVien();
        static DataClasses1DataContext db = new DataClasses1DataContext();
        List<QLNhanVien> list = (from s in db.QLNhanViens where s.Phòng == "IT" select s).ToList();
        public TimKiem()
        {
            InitializeComponent();
        }
        private void IT_button_CheckedChanged(object sender, EventArgs e)
        {
            var list = (from s in db.QLNhanViens where s.Phòng == "IT" select s).ToList();
            this.list = list;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var list = (from s in db.QLNhanViens select s).ToList();
            dataGridView1.DataSource = db.QLNhanViens;
        }

        private void HR_button_CheckedChanged(object sender, EventArgs e)
        {
            var list = (from s in db.QLNhanViens where s.Phòng == "HR" select s).ToList();
            this.list = list;
        }

        private void BA_button_CheckedChanged(object sender, EventArgs e)
        {
            var list = (from s in db.QLNhanViens where s.Phòng == "BA" select s).ToList();
            this.list = list;
        }

        private void Show_button_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.list;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                int salaryperhour = Convert.ToInt32(textBox1.Text);
                var list = (from s in db.QLNhanViens where s.LươngperHour >= salaryperhour select s).ToList();
                this.list = list;
            }
            catch (Exception)
            {

                MessageBox.Show("The value is incorrect!");
            }
            dataGridView1.DataSource = this.list;
        }

        private void Savefile_button_Click(object sender, EventArgs e)
        {
            string path = @"D:\Object oriented programming\22110309_Vo Phan Tan Dat\Week13\BTinclass\Output.txt";
            dataGridView1.AllowUserToAddRows = false;
            TextWriter wrt = new StreamWriter(path);
            wrt.WriteLine("   ID Number \t\t Name \t                Deparment \t               Salary per hour \t        Age");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    wrt.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                wrt.WriteLine("");
                wrt.WriteLine("==============================================================================================================");
            }
            wrt.Close();
        }
    }
}
