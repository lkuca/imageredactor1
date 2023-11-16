using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
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
        
        public Form2(Color color) 
        {

            Red.Tag = numicRed;
            Greem.Tag= numicGreen;
            Blue.Tag= numicBlue;

            numicRed.Tag = Red;
            numicGreen.Tag = Greem;
            numicBlue.Tag= Blue;

            numicRed.Tag = Color.Red;
            numicGreen.Tag = Color.Green;
            numicBlue.Tag = Color.Blue;

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

    }
}
