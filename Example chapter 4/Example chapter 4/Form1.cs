using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_chapter_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int month, count=0;
            double balance, intrest_rate;
            if (int.TryParse(txt_month.Text, out month) & double.TryParse(txt_startingbalance.Text, out balance) & double.TryParse(txt_interestrate.Text, out intrest_rate))
            {
                balance = double.Parse(txt_startingbalance.Text);
                month = int.Parse(txt_month.Text);
                intrest_rate = double.Parse(txt_interestrate.Text);

                //calculatin using loop
                while (count <= month)
                {
                   balance = balance + (intrest_rate / 100) * balance;
                    count++;


                    listBox_endingbalance.Items.Add("month" +count+ " Ending balance is  "  +balance);
                }
               

            }
            else
            {
                MessageBox.Show("txtbox only accept numeric data type");





            }

        }
    }
}
    
