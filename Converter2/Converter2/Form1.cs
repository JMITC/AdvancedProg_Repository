using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter2
{
    public partial class Form1 : Form
    {//variable declaration
        String input;
        String convert;
        double output;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //input buttons
        private void one_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "1";
            this.label.Text += input;
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "2";
            this.label.Text += input;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "3";
            this.label.Text += input;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "4";
            this.label.Text += input;
        }

        private void five_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "5";
                this.label.Text += input;
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "6";
                this.label.Text += input;
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "7";
                this.label.Text += input;
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "8";
                this.label.Text += input;
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "9";
                this.label.Text += input;
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += "0";
                this.label.Text += input;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";//empties label
                this.input = String.Empty;//empties input string
                
            }
        }

        private void conversion_Click(object sender, EventArgs e)
        {
            double num;
            //parsing input into double num for use in calculations/conversion
            double.TryParse(input, out num);

            convert = list.Text.ToString();//converts the current position of list box to string and saves it to convert for use in switch
            //switch to choose specified conversion type
            switch (convert)
            {
                case "Euro to Dollar(US)":
                    output = num * 1.11;//does specified conversion
                    label.Text = output.ToString();//parses output to a string so it can be shown in label
                    break;
                case "Dollar(US) to Euro":
                    output = num * .89;
                    label.Text = output.ToString();
                    break;
                case "Euro to Pound":
                    output = num * .75;
                    label.Text = output.ToString();
                    break;
                case "Pound to Euro":
                    output = num * 1.35;
                    label.Text = output.ToString();
                    break;


            }

            this.input = String.Empty;//clears input string for reuse
            input += output; // saves output to input for reuse  
        }

        private void decimalPoint_Click(object sender, EventArgs e)
        {
            {
                this.label.Text = "";
                input += ".";
                this.label.Text += input;
            }
        }
    }
}
