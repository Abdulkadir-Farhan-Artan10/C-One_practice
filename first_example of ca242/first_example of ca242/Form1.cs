using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_example_of_ca242
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            //creating variables to store using input
            string firstname, secondname, thirdname,fullname;
            firstname = txtfname.Text;
            secondname = txtsname.Text;
            thirdname = txtthirdname.Text;

            //process concat firstname and second name
            fullname = firstname + "  " + secondname+ " "+thirdname;


            //display output using label
            lpldisplay.Text = fullname;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtsname.Text = "";
            txtthirdname.Text = string.Empty;
            lpldisplay.Text = string.Empty;
            
        }

        private void lpldisplay_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
