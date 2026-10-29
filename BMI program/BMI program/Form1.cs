using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //validation
            double weight, height, bmi=0;
            if (!double.TryParse(txt_weight.Text, out weight) || weight<0){
                MessageBox.Show("invalid weight! plear enter valid weight");
                return;
            }
            else if (!double.TryParse(txt_height.Text, out height) || height<0){
                MessageBox.Show("invalid height! plear enter valid height");
                return;
            }
            if (weight < 0 & height < 0) {
                MessageBox.Show("invalid input! weight and height must be posotive");
                return;


            }
            weight = double.Parse(txt_weight.Text);
            height = double.Parse(txt_height.Text);
            bmi = weight / (height * height);

            if (bmi < 18.5) {
               
                listBox_Weight_category.Items.Add("your bmi is :" + bmi.ToString("0.00"));
                listBox_Weight_category.Items.Add("under weight");

                listBox_Weight_category.Items.Add("-------------------------");


                }
                else if (bmi >= 18.5 & bmi <= 25)
                {
                
                listBox_Weight_category.Items.Add("your bmi is :" + bmi.ToString("0.00"));
                listBox_Weight_category.Items.Add("optimal weight");


                listBox_Weight_category.Items.Add("-------------------------");
            }
                else 
                {
               
                listBox_Weight_category.Items.Add("your bmi is :" + bmi.ToString("0.00"));
                listBox_Weight_category.Items.Add("over weight");



                }



            }
            
        }
    }

