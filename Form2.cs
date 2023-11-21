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
        TextBox textBox1 ;
        
        public Color SelectedColor { get; private set; }


        public Form2(Color color) 
        {


            InitializeComponent();

            this.Height = 600;
            this.Width = 800;
            this.Text = "Colors";

           

            pbs = new PictureBox();
            pbs.BackColor = colorResult;
            pbs.BorderStyle = BorderStyle.FixedSingle;
            pbs.Size = new Size(400, 200);
            pbs.Location = new Point(0,0);
            pbs.Visible = true;
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
            Red.Visible = false;
            Greem.Location = new Point(Red.Location.X, Red.Location.Y + 20);
            Greem.Visible = false;
            Blue.Location = new Point(Greem.Location.X, Greem.Location.Y + 20);
            Blue.Visible = false;
            numicRed.Location = new Point(Red.Right + 50, Red.Location.Y);
            numicGreen.Location = new Point(Greem.Right + 50, Greem.Location.Y);
            numicBlue.Location = new Point(Blue.Right + 50, Blue.Location.Y);
            numicBlue.Visible = true;
            numicRed.Visible = true;
            numicGreen.Visible = true;
            Button btnForm2 = new Button();
            btnForm2.Text = "salevsta";
            btnForm2.Location = new Point(20, 250);
            btnForm2.Click += chetotam;
            Button btnForm3 = new Button();
            btnForm3.Text = "apply";
            btnForm3.Location = new Point(20, 300);
            btnForm3.Click += vazaaaap;

            this.Controls.Add(btnForm2);
            //baton = new Button();
            //baton.Height = 40;
            //baton.Width = 100;
            //baton.Text = "Valjuta mind!";
            //baton.Location = new Point(pbs.Location.X, pbs.Location.Y + 50);
            //baton.Click += chetotam;
            //baton.Visible = true;

            this.Controls.Add(Red);
            this.Controls.Add(Greem);
            this.Controls.Add(Blue);
            this.Controls.Add(numicRed);
            this.Controls.Add(numicGreen);
            this.Controls.Add(numicBlue);
            this.Controls.Add(pbs);
            this.Controls.Add(btnForm3);
            this.Controls.Add(textBox1);
            //this.Controls.Add(baton);




            Red.Tag = numicRed;
            Greem.Tag= numicGreen;
            Blue.Tag= numicBlue;

            numicRed.Tag = Red;
            numicGreen.Tag = Greem;
            numicBlue.Tag= Blue;

            numicRed.Value = color.R;
            numicGreen.Value = color.G;
            numicBlue.Value = color.B;

            
            numicRed.Scroll += redvluechange;
            
            numicGreen.Scroll += greemvluechange;
            
            numicBlue.Scroll += bluevluechange;

            numicRed.ValueChanged += Numic_ValueChanged;

            numicGreen.ValueChanged += Numic_ValueChanged;

            numicBlue.ValueChanged += Numic_ValueChanged;

            //Red.Controls.Cast(UpdateColor);
            //Greem.ControlAdded+=UpdateColor;
            //Blue.ControlAdded+= UpdateColor;

            //var cto = MessageBox.Show("salvestada seda pilti enne laadimisel uut pilti ", "kohtung", MessageBoxButtons.YesNoCancel);
            //switch (cto)
            //{
            //    case DialogResult.No: break;
            //    case DialogResult.Yes: btn_save(sender, e); break;
            //    case DialogResult.Cancel: return;
            //}
            

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
        private void greemvluechange(object sender, EventArgs e)
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
        private void bluevluechange(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown1 = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown1.Tag;
            scrollBar.Value = (int)numericUpDown1.Value;
        }
        private void UpdateColor()
        {
            colorResult = Color.FromArgb((int)numicRed.Value, (int)numicGreen.Value, (int)numicBlue.Value);
            pbs.BackColor = colorResult;
        }
        private void Numic_ValueChanged(object sender, EventArgs e)
        {
            
            UpdateColor();
        }
        private void chetotam(object sender, EventArgs e)
        {
            var cto = MessageBox.Show("otsustage kas soovite salvestada varvi ", "kohtung", MessageBoxButtons.YesNoCancel);
            switch (cto)
            {
                case DialogResult.No: break;
                case DialogResult.Yes: button_Click(sender, e); break;
                case DialogResult.Cancel: return;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color.FromArgb(Convert.ToInt32(numicRed.Value = colorDialog.Color.R));
                Color.FromArgb(Convert.ToInt32(numicGreen.Value = colorDialog.Color.G));
                Color.FromArgb(Convert.ToInt32(numicBlue.Value = colorDialog.Color.B));

                colorResult = colorDialog.Color;

                UpdateColor();
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
        private void vazaaaap(object sender, EventArgs e)
        {
            // Set the SelectedColor property before closing the form
            SelectedColor = Color.FromArgb((int)numicRed.Value, (int)numicGreen.Value, (int)numicBlue.Value);
            this.Close();
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
