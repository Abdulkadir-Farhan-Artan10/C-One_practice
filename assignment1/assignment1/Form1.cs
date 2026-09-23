using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbldepartment_Click(object sender, EventArgs e)
        {

        }

        private void lblsemester_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            //stage1
            //creating variables to store user input
            string studentname, studentId, studentdep, studentinfo;
            int studentsemester;

            studentname = txtstudentname.Text;
            studentId = txtstudentid.Text;
            studentdep = txtdepartment.Text;
            //this part i made explicit conversion-type casting -using parse method
            studentsemester =int.Parse (txtsemester.Text);
            //stage 2- concatination
            //processing 
            studentinfo = studentname + " , " + studentId + "  ," + studentdep + " , " + studentsemester;
            //display output using label
            lbloutput.Text = studentinfo;
          
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing only textboxes
            txtstudentname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            //clearing output label -beacaouse label did not use clear function();
            lbloutput.Text = string.Empty;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //closing form
            this.Close();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void txtsemester_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
