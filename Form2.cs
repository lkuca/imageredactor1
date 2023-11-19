using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Image_redactor
{
    public partial class Form2 : Form
    {
        PictureBox pbs;
        NumericUpDown numicRed,numicGreen,numicBlue;
        HScrollBar Red,Greem,Blue;
        Color colorResult;
        TextBox textBox1, textBox2, textBox3;

        
        public Form2(Color color) 
        {


            InitializeComponent();

            this.Height = 600;
            this.Width = 800;
            this.Text = "Colors";

            textBox1 = new TextBox();

            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                string s = main.Text;
                main.Text = "OK";
            }

            Red = new HScrollBar();
            Greem= new HScrollBar();
            Blue = new HScrollBar();
            numicRed= new NumericUpDown();
            numicGreen= new NumericUpDown();
            numicBlue= new NumericUpDown();
            

            Red.Minimum= 0;
            Red.Maximum= 255;
            Greem.Minimum= 0;
            Greem.Maximum= 255;
            Blue.Minimum= 0;
            Blue.Maximum= 255;
            Red.LargeChange= 1;
            Greem.LargeChange= 1;
            Blue.LargeChange= 1;


            numicRed.Minimum= 0;
            numicRed.Maximum= 255;
            numicGreen.Minimum= 0;
            numicGreen.Maximum= 255;
            numicBlue.Minimum= 0;
            numicBlue.Maximum= 255;
            numicRed.Increment = 1;
            numicGreen.Increment=1;
            numicBlue.Increment= 1;




            Red.Location = new Point(40, 50);
            Red.Visible = true;
            Greem.Location = new Point(Red.Location.X, Red.Location.Y + 20);
            Greem.Visible = true;
            Blue.Location = new Point(Greem.Location.X, Greem.Location.Y + 20);
            Blue.Visible = true;
            numicRed.Location = new Point(Red.Right + 50, Red.Location.Y);
            numicGreen.Location = new Point(Greem.Right + 50, Greem.Location.Y);
            numicBlue.Location = new Point(Blue.Right + 50, Blue.Location.Y);
            numicBlue.Visible = true;
            numicRed.Visible = true;
            numicGreen.Visible = true;

            this.Controls.Add(Red);
            this.Controls.Add(Greem);
            this.Controls.Add(Blue);
            this.Controls.Add(numicRed);
            this.Controls.Add(numicGreen);
            this.Controls.Add(numicBlue);




            Red.Tag = numicRed;
            Greem.Tag= numicGreen;
            Blue.Tag= numicBlue;

            numicRed.Tag = Red;
            numicGreen.Tag = Greem;
            numicBlue.Tag= Blue;

            numicRed.Value = color.R;
            numicGreen.Value = color.G;
            numicBlue.Value = color.B;
            
            
        }

        private void Redvaluechange(object sender, EventArgs e)
        {
            ScrollBar scrollBar= (ScrollBar)sender;
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            numericUpDown1.Value = scrollBar.Value;
        }
        private void redvluechange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            ScrollBar scrollBar= (ScrollBar)numericUpDown1.Tag;
            scrollBar.Value = (int)numericUpDown1.Value;
        }
        private void Greemvaluechange(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            numericUpDown1.Value = scrollBar.Value;
        }
        private void Greemvluechange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown1.Tag;
            scrollBar.Value = (int)numericUpDown1.Value;
        }
        private void Bluevaluechange(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            numericUpDown1.Value = scrollBar.Value;
        }
        private void Bluevluechange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown1.Tag;
            scrollBar.Value = (int)numericUpDown1.Value;
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb(Red.Value, Greem.Value, Blue.Value);
            pbs.BackColor = colorResult;
        }
        private void button_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Red.Value = colorDialog.Color.R;
                Greem.Value = colorDialog.Color.G;
                Blue.Value = colorDialog.Color.B;

                colorResult = colorDialog.Color;

                UpdateColor();
            }
        }
        public string Data
        {
            get
            {
                return textBox1.Text;
            }
        }
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form2";
        }
        #endregion
    }
}
