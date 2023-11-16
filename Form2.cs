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
        NumericUpDown numick;
        HScrollBar hsCSroll;
        public Form2() 
        {
            
            hsCSroll = new HScrollBar();
            hsCSroll.Minimum= 0;
            hsCSroll.Maximum= 255;
            hsCSroll.Tag = numick;

        }

        
    }
}
