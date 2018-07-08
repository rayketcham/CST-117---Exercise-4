using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Created By: Ray Ketcham
//Date: 7/8/2018
//Course: CST-117
namespace CST_117___Exercise_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //closes the application
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clears all forms
            label2.Text = "";
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Define seconds
            int seconds;

            if (int.TryParse(textBox1.Text, out seconds))
            {
                // && was purposely used, originally || was used and would show input from any range
                if (seconds >= 60 && seconds < 3600)
                {
                    //Defining Minute
                    int minute = seconds / 60;
                    label2.Text = minute.ToString() + " minutes.";
                }
                //If > is used instead of < this whole statement will be missed and causes errors, careful watching the correct < or >
                else if (seconds >= 3600 && seconds < 86400)
                {
                    //Define Hour
                    int hour = seconds / 3600;
                    label2.Text = hour.ToString() + " hours.";

                }
                else if (seconds >= 86400)
                {
                    //Define Day
                    int day = seconds / 86400;
                    label2.Text = day.ToString() + " days.";
                }
            }
            else
            {
                //Displays Message box invalid character input
                MessageBox.Show("Invalid Character");
            }
            }
        }
}