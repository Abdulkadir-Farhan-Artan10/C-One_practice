using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_score_Average
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

        private void txtscore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalculateaverage_Click(object sender, EventArgs e)
        {
            //validation
            double validation;
            if (double.TryParse(txtscore1.Text, out validation) && double.TryParse(txtscore2.Text, out validation) &&
                double.TryParse(txtscore3.Text, out validation)) 
            {
                try
                {
                    //creating variables with initialization
                    double score1, score2, score3, average;
                    score1 = double.Parse(txtscore1.Text);
                    score2 = double.Parse(txtscore2.Text);
                    score3 = double.Parse(txtscore3.Text);

                    if (score1 < 0 || score1 > 100)
                    {
                        MessageBox.Show("invalid score 1");

                    }
                    else if (score2 < 0 || score2 > 100)
                    {
                        MessageBox.Show("invalid score 2");

                    }
                    else if (score3 < 0 || score3 > 100)
                    {
                        MessageBox.Show("invalid score 3");

                    }
                    else
                    {
                        average = (score1 + score2 + score3 )/ 3;
                        lbloutput.Text = average.ToString("0.0");
                    }

                }
                catch (Exception x) {
                    MessageBox.Show(x.Message);
                
                }
            }
            else
            {
                MessageBox.Show("scores must be double or int");


            }
         
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            lbloutput.Text = " ";
        }
    }
}
