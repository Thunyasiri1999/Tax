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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sub = int.Parse(money.Text)* 12;
            int tax = 0;
            int cripple = int.Parse(pk.Text);
            int worb = int.Parse(sn.Text);
            
            
          
            //พ่อแม่
            int fathermother = 0;
            if (fm.Text == "บิดา-มารดา (อายุ 60 ปี ขึ้นไป)")
            {
               fathermother = 60000;
            }
            else if (fm.Text == "บิดา หรือ มารดา (อายุเกิน 60 ปี)")
            {
                fathermother = 30000;
            }
            else if (fm.Text == "บิดา-มารดา (อายุไม่เกิน 60 ปี )")
            {
                fathermother = 0;
            }
            //ลูก
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(bt.Value);
            if (y > 0)
            {
                 y = ((y - 1) * 60000) + 30000;
            }
            else
            {
                y = 0;
            }


            tax = 60000  + fathermother + (cripple * 60000) + worb + (x * 30000) + y;
       
            Form2 fm2 = new Form2();
            fm2.Dataf1 = tax;
            fm2.input = sub;
           
            fm2.Show();
            this.Hide();
        }
        private void money_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
