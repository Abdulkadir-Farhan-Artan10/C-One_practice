using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_chapter3
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
            String name, gender;
            String faculty = "";
            int age, validation_of_age;
            //check validation of age
            if (int.TryParse(txtage.Text, out validation_of_age))
            {
                //assigning variables
                name = txtname.Text;
                age = int.Parse(txtage.Text);
                //checking age is posotive number
                if (age > 0)
                {

                    //validation of gender is choosed
                    if (radioButton_male.Checked)
                    {

                        //validation of checkbox is checked
                        if (checkBox_computer.Checked && checkBox_it.Checked)
                        {
                            //addition of listbox
                            //gender = "male \n";
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            gender = "male \n";
                            listBox1.Items.Add(gender);
                            faculty += "computer" + " , " + "it";
                            listBox1.Items.Add(faculty);


                        }
                        else if (checkBox_computer.Checked)
                        {
                            //add textbox to listbox
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            //addition of listbox of gender male
                            gender = "male \n";
                            listBox1.Items.Add(gender);
                            //addition listbox of checkbox computer
                            faculty = "computer \n";
                            listBox1.Items.Add(faculty);

                        }
                        else if (checkBox_it.Checked)
                        {
                            //add textbox to listbox
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            //addition of listbox gender male
                            gender = "male \n";
                            listBox1.Items.Add(age);
                            //addition of listbox dfaculty it
                            faculty = "it \n";
                            listBox1.Items.Add(faculty);

                        }

                        //else if (checkBox_computer.Checked && checkBox_it.Checked) 
                        //{
                        //    //addition of listbox
                        //    faculty += "computer" + " , " + "it";
                        //    listBox1.Items.Add(faculty);

                        //}
                        else
                        {
                            MessageBox.Show("please select your faculty you can selct 1 or more");
                        }
                        
                      
                    }
                    else if (radioButton_female.Checked)
                    {
                        

                        //validation of checkbox is checked
                        if (checkBox_computer.Checked && checkBox_it.Checked)
                        {
                            //add textbox to listbox
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            //addition of listbox of gender female
                            gender = "female \n";
                            listBox1.Items.Add(gender);
                            //addition of listbox faculty computer and it
                            faculty += "computer" + " , " + "it";
                            listBox1.Items.Add(faculty);


                        }
                        else if (checkBox_computer.Checked)
                        {
                            //add textbox to listbox
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            //addition of listbox of gender female
                            gender = "female \n";
                            listBox1.Items.Add(gender);
                            //addition of listbox faculty computer
                            faculty = "computer \n";
                            listBox1.Items.Add(faculty);

                        }
                        else if (checkBox_it.Checked)
                        {
                            //add textbox to listbox
                            listBox1.Items.Add(name);
                            listBox1.Items.Add(age);
                            //addition of listbox for gender female
                            gender = "female \n";
                            listBox1.Items.Add(gender);
                            //addition of listbox faculty it
                            faculty = "it \n";
                            listBox1.Items.Add(faculty);

                        }

                        //else if (checkBox_computer.Checked && checkBox_it.Checked) 
                        //{
                        //    //addition of listbox
                        //    faculty += "computer" + " , " + "it";
                        //    listBox1.Items.Add(faculty);

                        //}
                        else
                        {
                            MessageBox.Show("please select your faculty you can selct 1 or more");
                        }


                    }
                    else
                    {
                        MessageBox.Show("please choose your gender");
                    }
                   

                   

                }
                else
                {
                    MessageBox.Show("age only accept posotive number");
                }


            }
            else
            {
                MessageBox.Show("age must be numeric espicialyy integer.");
            }

         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //selectimg
            //String selectitem;
            //selectitem = listBox1.Text;
            //MessageBox.Show(selectitem);

            //qaab kale select
            if (listBox1.SelectedIndex != -1)
            {
                String selection;
                selection = listBox1.SelectedItem.ToString();
                MessageBox.Show(selection);

                //removing buttons

            }
            else
            {
                MessageBox.Show("please select item");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            //remove method

            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.Remove(listBox1.SelectedIndex);


            }
            else
            {
                MessageBox.Show("please selecct the item you want to remove");
            }

  
            //if (listBox1.Items.Count != 0)
            //{
                
            //} 
            //else
            //{
            //    MessageBox.Show("before we delete enter value");
            //}
            //string destpin;
            //destpin = txtremoveditems.Text;
            //listBox1.Items.Remove(destpin.ToString());





            //listBox1.Items.Remove("artan");
        }

        private void btnremoveat_Click(object sender, EventArgs e)
        {
            //remove at method
            //listBox1.Items.RemoveAt(0);

            //another way using user input
            int index;
            index=listBox1.SelectedIndex;
            listBox1.Items.RemoveAt((int)index);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox
            txtname.Clear();
            txtage.Clear();
            //clearing radio buttons
            radioButton_male.Checked = false;
            radioButton_female.Checked = false;
            //clearing checkbox
            checkBox_computer.Checked = false;
            checkBox_it.Checked = false;
            //clearing textbox
            //listBox1.Items.Clear();

            //clear lblcount
            lblcount.Text = "";


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncount_Click(object sender, EventArgs e)
        {
            int count;
            count = listBox1.Items.Count;
            lblcount.Text = count.ToString();
            

        }
    }
}
