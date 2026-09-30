using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
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

        private void button1_Click(object sender, EventArgs e)
        {
            //creating variables
            String food_one, food_two;
            double food_one_price, food_two_price, sum, taxt,total;
            const double tax = 0.07;
            food_one = txtfood1.Text;
            food_one_price =double.Parse( txtprice1.Text);
            food_two = txtfood2.Text;
            food_two_price = double.Parse(txtprice2.Text);

            //processs
            sum = food_one_price + food_two_price;
            taxt = sum *tax ;
            total = sum + taxt;
            //display
            lbltaxt.Text = taxt.ToString();
            lbltotalamount.Text = total.ToString();


            
           
           
            

          
            
            


           




            //display output
            
        }
    }
}
