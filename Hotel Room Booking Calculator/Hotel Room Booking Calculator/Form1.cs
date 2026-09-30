using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //exception handling
            try
            {
                //declaring variables and initialization one time
                String GuestName = txtGuestName.Text;
                String RoomType = txtRoomType.Text;
                int NumOfNights = int.Parse(txtNights.Text);
                double PricePerNight = double.Parse(txtPriceNight.Text);

                //constant variables
                const double tax = 0.1;
                const double Discount = 0.05;

                //process
                double sub_total = NumOfNights * PricePerNight;
                double taxt = sub_total * tax;
                double discount = sub_total * Discount;
                double total = sub_total + taxt - discount;

                //display output
                lblservicetax.Text = taxt.ToString("c");
                lbldiscount.Text = discount.ToString("c");
                lbltotalamount.Text = total.ToString("c");
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);


            }

        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clearing textbox
            txtGuestName.Clear();
            txtRoomType.Clear();
            txtNights.Clear();
            txtPriceNight.Clear();
            //clearing label
            lblservicetax.Text = " ";
            lbldiscount.Text = " ";
            lbltotalamount.Text = " ";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            //closing form
            this.Close();
        }
    }
}
