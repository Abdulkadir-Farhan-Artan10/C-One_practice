using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_chapter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creating variables
            //int age;
            //double salary;
            //String grade;
            //expict conversion and initializaton
            //age =int.Parse( txtage.Text);
            //salary =double.Parse( txtsalary.Text);
            //grade= txtgrade.Text;

            //processing and concatination with output
            //lbloutput.Text = age + " " + salary + " " + grade;


            //exception handling methods
            try
            {
                //creating variables
                int age;
                double salary;
                String grade;
                //expict conversion and initializaton
                age = int.Parse(txtage.Text);
                salary = double.Parse(txtsalary.Text);
                grade = txtgrade.Text;

                //processing and concatination with output
                lbloutput.Text = age + " " + salary + " " + grade;

            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing txt boxes
            txtage.Clear();
            txtsalary.Clear();
            txtgrade.Clear();
            //clearing label
            lbloutput.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        
        
        
        
        

        
        
        
    }
}
