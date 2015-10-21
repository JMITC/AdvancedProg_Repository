namespace Converter3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ComboBox();
            this.zero = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.conversion = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.measurementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchesToFeetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feetToInchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fahrenheitToCelsiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.celsiusToFahrenheitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToPoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poundToEuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Euro to Pound",
            "Pound to Euro",
            "Celsius to Fahrenheit",
            "Fahrenheit to Celsius",
            "Feet to Inches",
            "Inches to Feet"});
            this.list.Location = new System.Drawing.Point(313, 171);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 24);
            this.list.TabIndex = 28;
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(267, 254);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 27;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // decimalPoint
            // 
            this.decimalPoint.Location = new System.Drawing.Point(348, 254);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(75, 24);
            this.decimalPoint.TabIndex = 26;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = true;
            this.decimalPoint.Click += new System.EventHandler(this.decimalPoint_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(267, 214);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 25;
            this.clear.Text = "CLR";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // conversion
            // 
            this.conversion.Location = new System.Drawing.Point(348, 214);
            this.conversion.Name = "conversion";
            this.conversion.Size = new System.Drawing.Size(98, 23);
            this.conversion.TabIndex = 24;
            this.conversion.Text = "CONVERT";
            this.conversion.UseVisualStyleBackColor = true;
            this.conversion.Click += new System.EventHandler(this.conversion_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(24, 172);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 23);
            this.nine.TabIndex = 23;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(105, 172);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 23);
            this.eight.TabIndex = 22;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(186, 172);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 23);
            this.seven.TabIndex = 21;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(24, 214);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 23);
            this.six.TabIndex = 20;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(105, 214);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 23);
            this.five.TabIndex = 19;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(186, 214);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 23);
            this.four.TabIndex = 18;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(24, 254);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 17;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(105, 254);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(186, 254);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 15;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(105, 111);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 29;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 22);
            this.toolStripLabel1.Text = "Menu";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.measurementsToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.currencyToolStripMenuItem});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(14, 22);
            this.toolStripDropDownButton1.Text = "Menu";
            // 
            // measurementsToolStripMenuItem
            // 
            this.measurementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inchesToFeetToolStripMenuItem,
            this.feetToInchesToolStripMenuItem});
            this.measurementsToolStripMenuItem.Name = "measurementsToolStripMenuItem";
            this.measurementsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.measurementsToolStripMenuItem.Text = "Measurements";
            // 
            // inchesToFeetToolStripMenuItem
            // 
            this.inchesToFeetToolStripMenuItem.Name = "inchesToFeetToolStripMenuItem";
            this.inchesToFeetToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.inchesToFeetToolStripMenuItem.Text = "Inches to Feet";
            this.inchesToFeetToolStripMenuItem.Click += new System.EventHandler(this.inchesToFeetToolStripMenuItem_Click);
            // 
            // feetToInchesToolStripMenuItem
            // 
            this.feetToInchesToolStripMenuItem.Name = "feetToInchesToolStripMenuItem";
            this.feetToInchesToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.feetToInchesToolStripMenuItem.Text = "Feet to Inches";
            this.feetToInchesToolStripMenuItem.Click += new System.EventHandler(this.feetToInchesToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fahrenheitToCelsiusToolStripMenuItem,
            this.celsiusToFahrenheitToolStripMenuItem});
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            // 
            // fahrenheitToCelsiusToolStripMenuItem
            // 
            this.fahrenheitToCelsiusToolStripMenuItem.Name = "fahrenheitToCelsiusToolStripMenuItem";
            this.fahrenheitToCelsiusToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.fahrenheitToCelsiusToolStripMenuItem.Text = "Fahrenheit to Celsius";
            this.fahrenheitToCelsiusToolStripMenuItem.Click += new System.EventHandler(this.fahrenheitToCelsiusToolStripMenuItem_Click);
            // 
            // celsiusToFahrenheitToolStripMenuItem
            // 
            this.celsiusToFahrenheitToolStripMenuItem.Name = "celsiusToFahrenheitToolStripMenuItem";
            this.celsiusToFahrenheitToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.celsiusToFahrenheitToolStripMenuItem.Text = "Celsius to Fahrenheit";
            this.celsiusToFahrenheitToolStripMenuItem.Click += new System.EventHandler(this.celsiusToFahrenheitToolStripMenuItem_Click);
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euroToPoundToolStripMenuItem,
            this.poundToEuroToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // euroToPoundToolStripMenuItem
            // 
            this.euroToPoundToolStripMenuItem.Name = "euroToPoundToolStripMenuItem";
            this.euroToPoundToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.euroToPoundToolStripMenuItem.Text = "Euro to Pound";
            this.euroToPoundToolStripMenuItem.Click += new System.EventHandler(this.euroToPoundToolStripMenuItem_Click);
            // 
            // poundToEuroToolStripMenuItem
            // 
            this.poundToEuroToolStripMenuItem.Name = "poundToEuroToolStripMenuItem";
            this.poundToEuroToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.poundToEuroToolStripMenuItem.Text = "Pound to Euro";
            this.poundToEuroToolStripMenuItem.Click += new System.EventHandler(this.poundToEuroToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 289);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.list);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.conversion);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button decimalPoint;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button conversion;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem measurementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchesToFeetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feetToInchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fahrenheitToCelsiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem celsiusToFahrenheitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToPoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poundToEuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

