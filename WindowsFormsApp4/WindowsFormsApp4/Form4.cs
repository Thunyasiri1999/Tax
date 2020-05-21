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
    public partial class Form4 : Form
    {
        public int Dataf4;
        public int Dataf5;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //ซ่อมบ้าน ซ่อมรถ จากพายุ 
            if (int.Parse(textBox13.Text) + int.Parse(textBox14.Text) <= 100000)
            {
                Dataf4 = Dataf4 + int.Parse(textBox13.Text) + int.Parse(textBox14.Text);
            }
            else
            {
                Dataf4 = Dataf4 + 100000;
            }


            //คำนวณ
            Double moneyall = Dataf5 - Dataf4;
            if (Dataf5 - Dataf4 < 0)
            {
                moneyall = 0;
            }
                
            textBox1.Text = moneyall.ToString();

            if (moneyall >= 0 && moneyall <= 150000)
            {
                moneyall = 0;
            }
            else if (moneyall > 150000 && moneyall <= 300000)
            {
                moneyall *= 0.05;
            }
            else if (moneyall > 300000 && moneyall <= 500000)
            {
                moneyall *= 0.1;
            }
            else if (moneyall > 500000 && moneyall <= 750000)
            {
                moneyall *= 0.15;
            }
            else if (moneyall > 750000 && moneyall <= 1000000)
            {
                moneyall *= 0.2;
            }
            else if (moneyall > 1000000 && moneyall <= 2000000)
            {
                moneyall *= 0.25;
            }
            else if (moneyall > 2000000 && moneyall <= 5000000)
            {
                moneyall *= 0.3;
            }
            else if (moneyall > 5000000)
            {
                moneyall *= 0.35;
            }
            textBox2.Text = moneyall.ToString();

            textBox3.Text = Dataf4.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
