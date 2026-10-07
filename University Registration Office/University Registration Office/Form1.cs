using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Registration_Office
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //validation
            int validation;
            if (int.TryParse(txtnumberofcourses.Text, out validation))
            {
                try
                {
                    String studentname;
                    int studentid;
                    int number_of_courses;
                    int study_level;
                    int transport_fee;
                    studentname = txtstudentname.Text;
                    studentid = int.Parse(txtstudentId.Text);
                    number_of_courses = int.Parse(txtnumberofcourses.Text);
                    study_level = int.Parse(txtstudylevel.Text);
                    transport_fee = int.Parse(txttransportoption.Text);
                    double feepercourse = 0;
                    double tutionfee=0;
                    double discount=0;
                    double finalfee=0;
                    
                    if (number_of_courses >= 1 && number_of_courses <= 8)
                    {
                        if (study_level == 1)
                        {
                            feepercourse = 40;

                        }
                        else if (study_level == 2)
                        {
                            feepercourse = 45;
                        }
                        else if (study_level == 3)
                        {
                            feepercourse = 50;

                        }
                        else if (study_level == 4)
                        {
                            feepercourse = 55;


                        }

                        // 10% discount for 6 or more courses
                        if (number_of_courses >= 6)
                        {
                            discount = tutionfee * 0.1;
                        }

                        tutionfee = number_of_courses * feepercourse;
                        finalfee = tutionfee + transport_fee - discount;
                    }

                     else
                    {
                        MessageBox.Show("number of courses must be range of 1-8");
                    }

                    //lbloutput.Text = " name: " + studentname +  " "+ " id "+ studentid + " "+ " num_of_courses:" + number_of_courses + " " + " study level:" + study_level + " " + " tuition fee" + transport_fee + " " + " discount " + discount + " " + "tuitionfee: "+ tutionfee + " "  +" finalfee:" + finalfee;
                    //display
                    lblname.Text = studentname;
                    lblid.Text = studentid.ToString();
                    lblnumofcourses.Text = number_of_courses.ToString();
                    lblstudylevel.Text = study_level.ToString();
                    lbltransportfee.Text = transport_fee.ToString();
                    lbldiscount.Text = discount.ToString();
                    lbltuitionfee.Text = tutionfee.ToString();
                    lblfinalfee.Text = finalfee.ToString()

                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);

                }


            }
            else
            {
                MessageBox.Show("number of courses must be only integer");
            }
        }

            
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clear all textbox
            txtstudentname.Clear();
            txtstudentId.Clear();
            txtnumberofcourses.Clear();
            txtstudylevel.Clear();
            txttransportoption.Clear();

            //clear all labels
            lblname.Text = "";
            lblid.Text = "";
            lblnumofcourses.Text = "";
            lblstudylevel.Text = "";
            lbltuitionfee.Text = "";
            lbldiscount.Text = "";
            lbltuitionfee.Text = "";
            lblfinalfee.Text = "";
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

