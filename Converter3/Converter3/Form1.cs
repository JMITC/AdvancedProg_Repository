using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter3
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
        //buttons for input
        private void decimalPoint_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += ".";
            this.label.Text += input;

        }

        private void zero_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "0";
            this.label.Text += input;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            this.input = String.Empty;
         
        }

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
            this.label.Text = "";
            input += "5";
            this.label.Text += input;
        }

        private void six_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "6";
            this.label.Text += input;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "7";
            this.label.Text += input;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "8";
            this.label.Text += input;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            this.label.Text = "";
            input += "9";
            this.label.Text += input;
        }

        private void conversion_Click(object sender, EventArgs e)
        {
            double num;
            //parses input to double num for use in calculations
            double.TryParse(input, out num);

            convert = list.Text.ToString();
            //switch to select and use specified calulation/conversion
            switch (convert)
            {

                case "Euro to Pound":
                    output = num * 0.75;//does specified conversion
                    label.Text = output.ToString();//parses double output to a string for use on the label

                    break;

                case "Pound to Euro":
                    output = num * 1.35;
                    label.Text = output.ToString();

                    break;

                case "Celsius to Fahrenheit":
                    output = (num * 9) / 5 + 32; ;  
                    label.Text = output.ToString();

                    break;

                case "Fahrenheit to Celsius":
                    output = ((num - 32) * 5) / 9;
                    label.Text = output.ToString();

                    break;


                case "Inches to Feet":
                    output = num * 0.0833333;
                    label.Text = output.ToString();

                    break;


                case "Feet to Inches":
                    output = num * 12;
                    label.Text = output.ToString();
                    break;
            }

            
            this.input = String.Empty;//clears input string for reuse as equal to output
            input += output; // saves output to input for reuse    


        }

       
        //Menu items
        private void inchesToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.list.Text = "Inches to Feet"; //changes the string in the combo box to specified calculation, uses combo box "convert=list.ToString" code to choose correct switch
        }

        private void feetToInchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            this.list.Text = "Feet to Inches";
        }

        private void fahrenheitToCelsiusToolStripMenuItem_Click(object sender, EventArgs e)
        {


            this.list.Text = "Fahrenheit to Celsius";
        }

        private void celsiusToFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            this.list.Text = "Celsius to Fahrenheit";
        }

        private void euroToPoundToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.list.Text = "Euro to Pound"; 
            
        }

        private void poundToEuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.list.Text = "Pound to Euro";
        }
    }
}
