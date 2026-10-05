using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_With_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            double validation;
            if (double.TryParse(txthoursworked.Text,out validation)&& double.TryParse(txthourlypayrate.Text, out validation))
            {
                try
                {
                    //varaibles with initialize
                    double hourrs = double.Parse(txthoursworked.Text);
                    double rate = double.Parse(txthourlypayrate.Text);
                    double grosspay = 0;
                    for (int i = 1; i <= hourrs; i++)
                    {
                        //neted loop
                        for (int j=1; j<=1;j++)
                        {
                            grosspay = grosspay + rate;

                        }
                        lblgrosspay.Text = grosspay.ToString("c2");

                    }

                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }


            }
            else
            {
                MessageBox.Show("hours_worked and payrate  only accept double or int");

            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing
            txthoursworked.Clear();
            txthourlypayrate.Clear();
            lblgrosspay.Text = "";

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
