using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_creating__example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_creating_file_Click(object sender, EventArgs e)
        {
            try
            {
                //import class creating new file
                StreamWriter outputfile; //this class use writing and  append
                                         //open the file
                                         //creating new file  _create text()
                outputfile = File.CreateText("C:\\Users\\hp\\Music\\test\\ca242.txt");

                //process the file
                //writting  the file
                outputfile.WriteLine("best class in semester 5 is-----");
                outputfile.WriteLine("jamhuriya university-----");
                outputfile.WriteLine("subject c#----");



                //close the file_using close function
                outputfile.Close();


                MessageBox.Show("succesfuly to create file");
            }catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //import class
            StreamReader reads;
            //open the file -reading the file
            //open text;
            reads = File.OpenText("C:\\Users\\hp\\Music\\test\\ca242.txt");
            //process the file -reading the file
            //string lines;
            //while (reads.EndOfStream==false)
            //{
            //    lines = reads.ReadLine();
            //    listBox1.Items.Add(lines);
            //
            //read kaligeed
            char lines;
            while (reads.EndOfStream == false)
            {
                lines = (char)reads.Read();
                listBox1.Items.Add(lines);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //uma baahna class read all text
            String lines;
            lines =File.ReadAllText("ca242.text");
            listBox1.Items.Add(lines); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //import class
            StreamWriter writes;
            //the open the file -append the file
            //append text
            writes = File.AppendText("C:\\Users\\hp\\Music\\test\\ca242.txt");

            //the process of the file
            //wtite or write line
            writes.WriteLine("c#");
            writes.WriteLine("java");
            writes.WriteLine("Artan");

            writes.Close();
        }
    }
}
