using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            //validation
            int validation;
            if (int.TryParse(txtnumber.Text, out validation))
            {
                //exception handling
                try
                {
                    int number = int.Parse(txtnumber.Text);
                    //logical operators
                    if (number >= 1 && number <= 10)
                    {
                        lbldecision.Text = "the number is within the range.";
                    }
                    else
                    {
                        lbldecision.Text = "the number is outside the range.";


                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }

            }

            else
            {
                MessageBox.Show("enter only number that is integer");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtnumber.Clear();
            lbldecision.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
