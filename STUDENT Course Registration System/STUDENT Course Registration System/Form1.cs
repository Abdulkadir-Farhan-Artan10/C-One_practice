using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STUDENT_Course_Registration_System
{
    public partial class Form1 : Form
    {
        bool booking_approved = false;
        double course_price=0;
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void btn_addcourse_Click(object sender, EventArgs e)
        {
            String courseName;
           
            int count = 1;
            courseName=txt_coursename.Text;
            course_price=double.Parse(txt_courseprice.Text);
            if (!double.TryParse(txt_courseprice.Text, out course_price))
            {
                MessageBox.Show("please enter valid course price.");
                return;
            }
            if (course_price < 0)
            {
                MessageBox.Show("course price must be posotive");
                return;
            }
           
           
           
                listBox_coursename_courseprice.Items.Add("Course name:"    +courseName);
                listBox_coursename_courseprice.Items.Add( "course price"     +course_price);
                count++;
            
            //listBox_coursename_courseprice.Items.Clear();

           

        }

        private void btn_removecourse_Click(object sender, EventArgs e)
        {
            if (listBox_coursename_courseprice.SelectedIndex != -1)
            {
                listBox_coursename_courseprice.Items.Remove(listBox_coursename_courseprice.SelectedItem);


            }
            else
            {
                MessageBox.Show("please selecct the item you want to remove");
            }

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                int age;
                double Basic_registration_fee = 0, course_discount_rate = 0, course_discount, final_registration_fee;
                int num_of_registered_course;
                int count = 1;
                String Name, id;

                id = txt_id.Text;
                Name = txt_name.Text;
                age = int.Parse(txt_age.Text);
                num_of_registered_course = int.Parse(txt_registeredcourse.Text);
                if (!int.TryParse(txt_age.Text, out age))
                {
                    MessageBox.Show("please inter valid age");
                    return;

                }
                if (id=="")
                {
                    MessageBox.Show("please enter id");
                    return;



                }
                if (age < 16 || age > 60)
                {
                    MessageBox.Show("age must be between 16 and 60");
                    return;
                }
                if (num_of_registered_course <= 0)
                {
                    MessageBox.Show("number of registered course must be at least 1");
                    return;


                }
                while (count <= num_of_registered_course)
                {
                    Basic_registration_fee = course_price * num_of_registered_course;
                    count++;

                }
                if (num_of_registered_course == 1)
                {
                    course_discount_rate = 0;


                }
                else if (num_of_registered_course == 2)
                {
                    course_discount_rate = 0.05;


                }
                else if (num_of_registered_course >= 3 & num_of_registered_course <= 4)
                {
                    course_discount_rate = 0.1;

                }
                else if (num_of_registered_course == 5)
                {
                    course_discount_rate = 0.15;


                }
                course_discount = Basic_registration_fee * course_discount_rate;
                final_registration_fee = Basic_registration_fee - course_discount;

                booking_approved = true;


                listBox_registration_result.Items.Add("Student Registration Result");
                listBox_registration_result.Items.Add("==============================");
                listBox_registration_result.Items.Add("Student ID: " + id);
                listBox_registration_result.Items.Add("Student Name: " + Name);
                listBox_registration_result.Items.Add("Student Age: " + age);
                listBox_registration_result.Items.Add("Number of Course: " + num_of_registered_course);

                listBox_registration_result.Items.Add("--------------------------------------------");
                listBox_registration_result.Items.Add("Basic Registration Fee: " + Basic_registration_fee);
                listBox_registration_result.Items.Add("Course Discount : " + course_discount);

                listBox_registration_result.Items.Add("--------------------------------------------");
                listBox_registration_result.Items.Add("Final Registration Fee:" + final_registration_fee);
                listBox_registration_result.Items.Add("Booking Approved:" + booking_approved);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            
            
            }















        }

        private void txt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
