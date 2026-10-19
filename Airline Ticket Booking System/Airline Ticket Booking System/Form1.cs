using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_System
{
    public partial class Form1 : Form
    {
        bool bookingapproved = false;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingapproved = false;
            //validation
            int passenger_age, number_of_tickets;
            double baggage_weight, ticket_price=0,Basic_cost=0,ticket_discount_rate=0,Ticket_discount,discounted_cost;
            string travel_class, passenger_name;
            string booking_approved;
            double  age_discount_rate=0,age_discount,final_ticket_cost,insurance_cost=0,baggage_cost=0,total_cost;
            const double insurance_price = 25;
            const double extra_baggage_price = 10;
            //validate age
            if (!int.TryParse(txtpassengerage.Text, out passenger_age)){
                MessageBox.Show("enter valid age");
                return;

            }
            //validate number of tickets
            else if (!int.TryParse(txtnumoftickets.Text, out number_of_tickets))
            {
                MessageBox.Show("enter valid tikets");
                return;

            }
            //validate  baggage weight
            else if (!double.TryParse(txtbaggageweight.Text, out baggage_weight))
            {
                MessageBox.Show("enter valid baggage weight");
                return;

            }



            //initialize
            passenger_name = txtpassengername.Text;
                passenger_age = int.Parse(txtpassengerage.Text);
                number_of_tickets = int.Parse(txtnumoftickets.Text);
                baggage_weight = double.Parse(txtbaggageweight.Text);

            //validate empty name
                if (passenger_name == "")
                {
                    MessageBox.Show("please enter passenger name");
                    return;
                }
                //validate age must be between 1 and 100
                if (passenger_age < 1 || passenger_age > 100)
                {
                    MessageBox.Show("age must be between 1 and 100");
                    return;

                }
                //validate number of tickets must be between 1 and 5
                if (number_of_tickets < 1 || number_of_tickets > 5)
                {

                    MessageBox.Show("tickets must be between 1 and 5");
                    return;
                }
                //validate baggage weight must be between 0 and 50
                if (baggage_weight < 0 || baggage_weight > 50)
                {
                    MessageBox.Show("baggage weight must be between 0 and 50");
                    return;
                }

                if (!radiobtn_firstclass.Checked && !radiobutton_normalclass.Checked && !radiobtn_businessclass.Checked)
                {
                    MessageBox.Show("please select travel class");
                    return;


                }
                else if (passenger_age<12 && radiobtn_firstclass.Checked)
                {
                    MessageBox.Show(" Booking Rejcted : passengers under 12 can't book fist class");
                    return;

                }
            
            if (radiobtn_firstclass.Checked)
            {
                ticket_price = 500;
            }
            else if (radiobutton_normalclass.Checked)

            {
                ticket_price = 200;
            }
            else if (radiobtn_businessclass.Checked)
            {
                ticket_price = 350;

            }

            //basic ticket cost
            Basic_cost = ticket_price * number_of_tickets;

            //ticket discount
            if (number_of_tickets>=3 && number_of_tickets<=4)
            {
                ticket_discount_rate = 0.05;

            }
            else if (number_of_tickets==5)

            {
                ticket_discount_rate = 0.1;
            }

            Ticket_discount = Basic_cost * ticket_discount_rate;
            discounted_cost = Basic_cost - Ticket_discount;

            //age discount

            if (passenger_age < 12)
            {
                age_discount_rate = 0.2;
            }
            else if (passenger_age>=60)
            {
                age_discount_rate = 0.1;
            }

            age_discount=discounted_cost* age_discount_rate;
            final_ticket_cost = discounted_cost - age_discount;

            //travel insurance
            if (checkboxtravel_insurance.Checked)
            {
                insurance_cost = insurance_price * number_of_tickets;

            }

            //baggage : first 20 kg is free per passenger
            if (baggage_weight>20)
            {
                baggage_cost = (baggage_weight - 20) * extra_baggage_price * number_of_tickets;
            }
            //final total;
            total_cost=final_ticket_cost + insurance_cost + baggage_cost;

            //booking approved
            bookingapproved = true;

            //dispalay booking details
            listbox_ticket_info.Items.Add("airline Booking Details");
            listbox_ticket_info.Items.Add("==============================");
            listbox_ticket_info.Items.Add("passenger Name: " + passenger_name);
            listbox_ticket_info.Items.Add("passenger Age: " + passenger_age);
            listbox_ticket_info.Items.Add("Number of tickets: " + number_of_tickets);
            listbox_ticket_info.Items.Add("Baggage weight: " + baggage_weight + " kg");

            listbox_ticket_info.Items.Add("------------------------------");

            listbox_ticket_info.Items.Add("Basic Ticket Cost: $" + baggage_cost.ToString("0.00"));
            listbox_ticket_info.Items.Add("Ticket discount: $" + Ticket_discount.ToString("0.00"));
            listbox_ticket_info.Items.Add("Age discount: $" + age_discount.ToString("0.00"));
            listbox_ticket_info.Items.Add("Insurance cost: $" + insurance_cost.ToString("0.00"));
            listbox_ticket_info.Items.Add("Baggage cost: $" + baggage_cost.ToString("0.00"));

            listbox_ticket_info.Items.Add("------------------------------");

            listbox_ticket_info.Items.Add("Total Cost: $" + total_cost.ToString("0.00"));
            listbox_ticket_info.Items.Add("Booking Approved: " + bookingapproved);











        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            listbox_ticket_info.Items.Clear();
            txtpassengername.Clear();
            txtpassengerage.Clear();
            txtnumoftickets.Clear();
            txtbaggageweight.Clear();
            radiobtn_firstclass.Checked = false;
            radiobutton_normalclass.Checked = false;
            radiobtn_businessclass.Checked = false;
            checkboxtravel_insurance.Checked = false;

           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }
    



