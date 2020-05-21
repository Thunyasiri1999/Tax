using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        /// ประกาศตัวแปรเพื่อดึงค่า
        public int Dataf2;
        public int Dataf3;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////ดอกเบี้ยบ้าน
            if (int.Parse(textBox1.Text) <= 100000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox1.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 100000;
            }
            if (int.Parse(comboBox1.SelectedItem.ToString()) >= 2562)
            {
                if (int.Parse(textBox2.Text) <= 200000)
                {
                    Dataf2 = Dataf2 + int.Parse(textBox2.Text);
                }
                else
                {
                    Dataf2 = Dataf2 + 200000;
                }
            }
            else
            {
                if (int.Parse(textBox2.Text)<=3000000)
                {
                    Dataf2 = Dataf2 + int.Parse(textBox2.Text) * 4 / 100;
                }
            }
            ////กระตุ้นเศรษฐกิจภาครัฐ ซื้ออุปกรณ์กีฬา หนังสือ OTOP
            if (int.Parse(textBox8.Text) <= 15000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox8.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 15000;
            }
            if (int.Parse(textBox7.Text) <= 15000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox7.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 15000;
            }
            if (int.Parse(textBox6.Text) <= 15000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox6.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 15000;
            }

            //บริจาคทั่วไป
           
            if (int.Parse(textBox3.Text) <= Dataf3*10/100)
            {
                Dataf2 = Dataf2 + int.Parse(textBox3.Text);
            }
            else
            {
                Dataf2 = Dataf2 + Dataf3*10/100;
            }
            if (int.Parse(textBox4.Text) <= Dataf3 * 10 / 100)
            {
                Dataf2 = Dataf2 + int.Parse(textBox4.Text);
            }
            else
            {
                Dataf2 = Dataf2 + Dataf3 * 10 / 100;
            }
            ///พรรคการเมือง
            if (int.Parse(textBox5.Text) <= 10000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox5.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 10000;
            }

            //เที่ยวทั่วไทย
            if (int.Parse(textBox9.Text)+int.Parse(textBox10.Text) <= 20000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox9.Text)+int.Parse(textBox10.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 20000;
            }

            //ค่าซ่่อมรถกับซ่อมบ้าน
            if (int.Parse(textBox11.Text) + int.Parse(textBox12.Text) <= 100000)
            {
                Dataf2 = Dataf2 + int.Parse(textBox11.Text) + int.Parse(textBox12.Text);
            }
            else
            {
                Dataf2 = Dataf2 + 100000;
            }
            ///โยนข้อมูลไปForm ถัดไป
            Form4 fm4 = new Form4();
            fm4.Dataf4 = Dataf2;
            fm4.Dataf5 = Dataf3;
            fm4.Show();
            this.Hide();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
