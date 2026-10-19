using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_System
{
    public partial class Form1 : Form
    {
        bool booking_approved=false;
        const double strandard_rate = 50;
        const double normal_rate = 80;
        const double hight_rate = 140;
        const double breakfast_rate = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            booking_approved = false;
            listBox_booking_details.Items.Clear();
            //creating variables
            String Guest_name, room_type = ""; 
            int guest_age, number_ofnights, number_ofguests,maximum_guests=0;
            double rate = 0,basic_cost,night_discount_rate=0,night_discount,cost_afternight_discount,senior_discount=0;
            double roomcost_after_discounts,breakfastcost=0,service_surcharge=0,total_cost;
            //initialization
            Guest_name=txt_guestname.Text;
            guest_age=int.Parse(txt_guestage.Text);
            number_ofnights=int.Parse(txt_numofnights.Text);
            number_ofguests=int.Parse(txt_numofguests.Text);

            //validate if name is empty
            if (Guest_name=="")
            {
                MessageBox.Show("please enter guest name");
                return;

            }
            //validate age data type
            if (!int.TryParse(txt_guestage.Text,out guest_age))
            {
                MessageBox.Show("please enter valid guest age");
                return;

            }
            //validate number of nights data type
            else if (!int.TryParse(txt_numofnights.Text, out number_ofnights))
            {
                MessageBox.Show("please enter valid number_of_nights");
                return;

            }
            //validate number of guests data type
            else if (!int.TryParse(txt_numofguests.Text, out number_ofguests))
            {
                MessageBox.Show("please enter valid number_of_Guests");
                return;

            }
            //validate guest age must be between 18 and 90
            if (guest_age<18 || guest_age>90)
            {
                MessageBox.Show("guest age must be between 18 and 90");
                return;

            }
            //validate number of nights must be between 1 and 30
            else if (number_ofnights < 1 || number_ofnights > 30)
            {
                MessageBox.Show("number of nights must be between 1 and 30");
                return;

            }
            //validate number of guests must be between 1 and 6
            else if (number_ofguests < 1 || number_ofnights > 6)
            {
                MessageBox.Show("number of guests must be between 1 and 6");
                return;

            }

            //select room type and determine rate using switch
            if (radioButton_standard.Checked)
            {
                room_type = "standard";
            }
            else if (radioButton_normal.Checked)
            {
                room_type = "Normal";

            }
            else if (radioButton_hight.Checked)
            {
                room_type = "Hight";

            }
            else
            {
                MessageBox.Show("please select room type");
                return;
            }
            switch (room_type)
            {
                case "standard":
                    rate = strandard_rate;
                    maximum_guests = 2;
                    break;

                case "Normal":
                    rate = normal_rate;
                    maximum_guests = 4;
                    break;

                case "hight":
                    rate = hight_rate;
                    maximum_guests = 6;
                    break;


            }
            //check room capacity
            if (number_ofguests > maximum_guests)
            {
                MessageBox.Show(room_type + "room can accomodate a maximum of " + maximum_guests + " guests.");
                return;


            }
            //calculate basic room cost
            basic_cost = rate * number_ofnights;
            //calculate night discount
            if(number_ofnights>=5 && number_ofnights <= 9)
            {
                night_discount_rate = 0.05;
            }
            else if (number_ofnights>=10)
            {
                night_discount_rate = 0.12;


            }
            night_discount = basic_cost * night_discount_rate;
            cost_afternight_discount = basic_cost - night_discount;

            //calcuate senior discount
            if (guest_age >= 60)
            {
                senior_discount = cost_afternight_discount * 0.05;
            }
            roomcost_after_discounts = cost_afternight_discount - senior_discount;

            //calculate breakfast cost
            if (checkBox_breakfast.Checked)
            {
                breakfastcost = breakfast_rate * number_ofguests * number_ofnights;
            }
            //calculate service surcharge
            if (number_ofguests > 4)
            {
                service_surcharge = roomcost_after_discounts * 0.05;
            }
            //calculate final total
            total_cost = roomcost_after_discounts + breakfastcost + service_surcharge;
            //approve booking
            booking_approved= true;

            //display booking details
            listBox_booking_details.Items.Add("Hotel Booking details");
            listBox_booking_details.Items.Add("===============================");

            listBox_booking_details.Items.Add("Guest Name:" + Guest_name);
            listBox_booking_details.Items.Add("Guest Age:" + guest_age);
            listBox_booking_details.Items.Add("Room Type:" + room_type);
            listBox_booking_details.Items.Add("Room rate: $" + rate.ToString("0.00"));
            listBox_booking_details.Items.Add("number of nights:" + number_ofnights);
            listBox_booking_details.Items.Add("number of guests:" + number_ofguests);
             
            listBox_booking_details.Items.Add("----------------------------------------");

            listBox_booking_details.Items.Add("basic room cost: $" + basic_cost.ToString("0.00"));
            listBox_booking_details.Items.Add("Night discount: $" + night_discount.ToString("0.00"));
            listBox_booking_details.Items.Add("Senior discount: $" + senior_discount.ToString("0.00"));
            listBox_booking_details.Items.Add("break fast costt: $" + breakfastcost.ToString("0.00"));
            listBox_booking_details.Items.Add("service surcharge: $" + service_surcharge.ToString("0.00"));
            listBox_booking_details.Items.Add("break fast costt: $" + breakfastcost.ToString("0.00"));

            listBox_booking_details.Items.Add("----------------------------------------");

            listBox_booking_details.Items.Add("Total cost: $" + total_cost.ToString("0.00"));
            listBox_booking_details.Items.Add("booking approved:" + booking_approved);





        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txt_guestname.Clear();
            txt_guestage.Clear();
            txt_numofnights.Clear();
            txt_numofguests.Clear();

            radioButton_standard.Checked = false;
            radioButton_normal.Checked = false;
            radioButton_hight.Checked = false;

            checkBox_breakfast.Checked = false;

            listBox_booking_details.Items.Clear();
            booking_approved = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
