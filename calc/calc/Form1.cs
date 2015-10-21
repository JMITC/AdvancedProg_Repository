using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{

    public partial class Form1 : Form
    {
        //variable declartion
        String input;
        String inputOne;
        String inputTwo;
        double output = 0;
        char calc;

        public Form1()
        {
            InitializeComponent();
        }

        private void equals_Click(object sender, EventArgs e)
        {

            double numOne;
            double numTwo;

            inputTwo = input; //Storing the input after the operand as the second number in the calc

            //parsing inputOne and inputTwo into doubles numOne and numTwo for use in calc
            double.TryParse(inputOne, out numOne);
            double.TryParse(inputTwo, out numTwo);


            /* switch (calc)
             {

                 case '+':

                     output = numOne + numTwo; //doing specificed calc, adding the output to double output
                     label.Text = output.ToString();//parsing the double to string for output on the calculators label

                     break;

                 case '-':

                     output = numOne - numTwo; 
                     label.Text = output.ToString(); 

                     break;

                 case '*':

                     output = numOne * numTwo;
                     label.Text = output.ToString();

                     break;

                 case '/':

                     output = numOne / numTwo;
                     label.Text = output.ToString();

                     break;
                     
            } ......Why did this not work? Couldn't use a result of a calculation in a new calculation*/

            //if statement for different calcs depending on the operand entered
            if (calc == '-')
            {
                output = numOne - numTwo; //calc
                label.Text = output.ToString(); //output display
            }

            if (calc == '+')
            {
                output = numOne + numTwo;
                label.Text = output.ToString();
            }

            if (calc == '*')
            {
                output = numOne * numTwo;
                label.Text = output.ToString();
            }

            if (calc == '/')
            {
                output = numOne / numTwo;
                label.Text = output.ToString();
            }
                    //clear input strings for reuse
                    this.inputOne = String.Empty;
                    this.inputTwo = String.Empty;
                    this.input = String.Empty;

                    input += output; // saves output to input for reuse

            }
        
        //buttons used for input
        private void clear_Click(object sender, EventArgs e)
        {
            this.label.Text = "";//emptying calculators label
            this.input = String.Empty;//emptying input string
            this.inputOne = String.Empty;//emptying string used as first input number
            this.inputTwo = String.Empty;//emptying string used as econd input number

        }

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

       

        private void addition_Click(object sender, EventArgs e)
        {
            inputOne = input; //saves input before operand as inputOne
            calc = '+'; //adds correct operand to string calc for later use in switch
            input = String.Empty;//empties string input for later use with inputTwo
            input += '+';//adds current operand to input for display
            this.label.Text += input;//displays operand
            input = String.Empty;//empties string for inputTwo again

        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            inputOne = input;
            calc = '-';
            input = String.Empty;
            input += '-';
            this.label.Text += input;
            input = String.Empty;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            inputOne = input;
            calc = '*';
            input = String.Empty;
            input += '*';
            this.label.Text += input;
            input = String.Empty;

        }

        private void division_Click(object sender, EventArgs e)
        {
            inputOne = input; 
            calc = '/'; 
            input = String.Empty;
            input += '/'; 
            this.label.Text += input;
            input = String.Empty; 
        }
    }
}
