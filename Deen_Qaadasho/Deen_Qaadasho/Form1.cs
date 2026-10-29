using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deen_Qaadasho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)

        {
            //validation
            double validatio;
            if(double.TryParse(txtsalery.Text,out validatio)&& double.TryParse(txtyeaar.Text, out validatio))
            {
                try
                {
                    //creating variables with initialization
                    double salary = double.Parse(txtsalery.Text);
                    double yearexp = double.Parse(txtyeaar.Text);
                    if (salary>200)
                    {
                        if (yearexp >= 2)
                        {
                            lbloutpu.Text = "waa qaadan kartaa deen.";
                        }
                        else
                        {
                            lbloutpu.Text = "sanadaha shaqeesay deen laguma qaato ee tag meesha.";
                        }

                    }
                    else
                    {
                        lbloutpu.Text = "deen laguma qaato musharkan ee ka tag meesha:";
                    }


                 
                }
                catch(Exception x)
                {
                    MessageBox.Show(x.Message);
                }

            }
            else
            {
                MessageBox.Show("salary and year only accept double or int");
            } 
           
        }

        private void BTNCLEAR_Click(object sender, EventArgs e)
        {
            txtsalery.Clear();
            txtyeaar.Clear();
            lbloutpu.Text = "";


        }
    }
}
