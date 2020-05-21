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
    public partial class Form2 : Form
    {
        public int Dataf1,input;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            // เบี้ยประกันสังคม+สุขภาพ
            if (int.Parse(textBox1.Text)<=9000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox1.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 9000;
            }
            if (int.Parse(textBox2.Text) <= 100000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox2.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 100000;
            }
            //เบี้ยประกันสุขภาพบิดามารดา
            if (int.Parse(textBox9.Text) <= 15000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox9.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 15000;
            }
            //เบี้ยประกันสุขภาพคู่สมรส
            if (int.Parse(textBox10.Text) <= 10000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox10.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 10000;
            }
            //กองทุนสำรองชีพ
            if (int.Parse(textBox3.Text) <= 10000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox3.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 10000;
            }
            //เงินสะสมกองทุน กบข
            if (int.Parse(textBox4.Text) <= 500000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox4.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 500000;
            }
            //เงินสะสม กอช 
            if (int.Parse(textBox5.Text) <= 13200)
            {
                Dataf1 = Dataf1 + int.Parse(textBox5.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 13200;
            }
            //เบี้ยประกันชีวิตแบบชำนาญ
            if (int.Parse(textBox6.Text) <= 500000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox6.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 500000;
            }
            //ค่าซื้อ LTF ถือครอง ไม่น้อยกว่า 7 ปี
            if (int.Parse(textBox7.Text) <= 500000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox7.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 500000;
            }
            //RMF ลงทุนต่อเนื่องถึงอายุ 55 ปี
            if (int.Parse(textBox8.Text) <= 500000)
            {
                Dataf1 = Dataf1 + int.Parse(textBox8.Text);
            }
            else
            {
                Dataf1 = Dataf1 + 500000;
            }

            Form3 fm3 = new Form3();
            fm3.Dataf2 = Dataf1;
            fm3.Dataf3 = input;
            
            fm3.Show();
            this.Hide();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
