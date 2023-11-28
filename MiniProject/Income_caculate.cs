using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MiniProject
{
    public partial class Income_caculate : Form
    {
        DataClasses2DataContext datacuahang = new DataClasses2DataContext();
        QuanLyCuaHang cuaHang = new QuanLyCuaHang();
        dynamic g_result_list = null;
        public Income_caculate()
        {
            InitializeComponent();
        }
        public bool check_valid_month(int test)
        {
            if (test < 1 || test >12) 
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Invalid input");
                textBox1.Text.Trim();
                textBox1.Clear();
                textBox2.Text.Trim();
                textBox2.Clear();
                return;
            }
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            {
                MessageBox.Show("Invalid input");
                textBox1.Text.Trim();
                textBox1.Clear();
                textBox2.Text.Trim();
                textBox2.Clear();
                return;
            }
            if (!check_valid_month(Convert.ToInt32(textBox1.Text))|| !check_valid_month(Convert.ToInt32(textBox2.Text)))
            {
                MessageBox.Show("Invalid input");
                textBox1.Text.Trim();
                textBox1.Clear();
                textBox2.Text.Trim();
                textBox2.Clear();
                return;
            }
            int thangbatdau = Convert.ToInt32(textBox1.Text);
            int thangketthuc = Convert.ToInt32(textBox2.Text);
            datacuahang = new DataClasses2DataContext();
            List<QuanLyCuaHang> temp = new List<QuanLyCuaHang>();
            for (int i = thangbatdau; i <= thangketthuc; i++)
            {
                 var result = (from s in datacuahang.QuanLyCuaHangs where 
                          s.DTBought.Value.Month == i select s).ToList();
                temp.AddRange(result);
            }
            g_result_list = temp;
          /*  var result = (from s in datacuahang.QuanLyCuaHangs where 
                          s.DTBought.Value.Month == Convert.ToInt32(textBox1.Text) select s).ToList();*/
            //g_result_list = (List<QuanLyCuaHang>)result;
            dataGridView1.DataSource = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (((List<QuanLyCuaHang>)g_result_list).Count==0)
            {
                MessageBox.Show("Empty to export!", "Notice");
                return;
            }
            double[] TotalRevenue = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            MessageBox.Show("File is exported!", "Notice");
            string path = @"D:\\Object oriented programming\\22110309_Vo Phan Tan Dat\\Week14\\Output\\Income.txt";
            StreamWriter streamWriter = new StreamWriter(path);
            streamWriter.WriteLine("Doanh thu tu thang " + textBox1.Text + " toi thang " + textBox2.Text + "\n\n");
            foreach (var item in g_result_list)
            {
                streamWriter.WriteLine("Month bought: " + ((QuanLyCuaHang)item).DTBought.Value.Month.ToString());
                streamWriter.WriteLine("Producer: " + ((QuanLyCuaHang)item).Producer);
                streamWriter.WriteLine("Number: " + ((QuanLyCuaHang)item).Number.ToString());
                streamWriter.WriteLine("Price per device: " + ((QuanLyCuaHang)item).Price.ToString());
                streamWriter.WriteLine("Total income: " + (((QuanLyCuaHang)item).Price * ((QuanLyCuaHang)item).Number).ToString());
                streamWriter.WriteLine("=================================================");
                TotalRevenue[((QuanLyCuaHang)item).DTBought.Value.Month] += (double)(((QuanLyCuaHang)item).Price * ((QuanLyCuaHang)item).Number);
            }
            double max = 0;
            int index = 0;
            for (int i = 0; i<=12;i++)
            {
                if (TotalRevenue[i]>max)
                {
                    max = TotalRevenue[i];
                    index = i;
                }
            }
            streamWriter.Write("The highest revenue is " + index.ToString() + " with the revenue is: " + max.ToString());
            streamWriter.WriteLine("\n----------------------------------------------------------------------\n\n");
            streamWriter.Close();
        }
    }
}
