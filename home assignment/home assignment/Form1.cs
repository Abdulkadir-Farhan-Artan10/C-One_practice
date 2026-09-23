using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //stage of input
            //creating variables
            string dayoftheweek, nameofthemonth, fulldate;
            int numericofthemonth, year;
            //initial values to variables
            dayoftheweek = txtdayoftheweek.Text;
            nameofthemonth = txtnameofthemonth.Text;
            //explicit convertion-type casting-using parse method
            numericofthemonth =int.Parse( txtnumericofthemonth.Text);
            year =int.Parse( txtyear.Text);

            //stage 2 process - concatination of full date
            fulldate = dayoftheweek + ", " + nameofthemonth + ", " + numericofthemonth + " ," + year;

            // stage 3 = output using label
            lbloutput.Text = fulldate;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox
            txtdayoftheweek.Clear();
            txtnameofthemonth.Clear();
            txtnumericofthemonth.Clear();
            txtyear.Clear();

            //clearing label - it not used clear function();
            lbloutput.Text = " ";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //form close-using this keyword and close function
            this.Close();
        }
    }
}
