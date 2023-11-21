using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Image_redactor
{
    public partial class ToolStrip : Form
    {
         System.Windows.Forms.Button btn,btn1, btn2, btn3, btn4;
        public ToolStrip()
        {
            btn = new  System.Windows.Forms.Button();
            btn.Height = 40;
            btn.Width = 100;
            btn.Location = new Point(150, 50);
            btn.MouseClick += btnOpenNewForm_Click;
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn1.Visible = true;
            btn1 = new System.Windows.Forms.Button();
            btn1.Height = 40;
            btn1.Width = 100;
            btn1.Location = new Point(150, btn.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn2.Visible = true;
            btn2 = new System.Windows.Forms.Button();
            btn2.Height = 40;
            btn2.Width = 100;
            btn2.Location = new Point(150, btn1.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn3.Visible = true;
            btn3 = new System.Windows.Forms.Button();
            btn3.Height = 40;
            btn3.Width = 100;
            btn3.Location = new Point(150, btn2.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn3.Visible = true;
            btn4 = new System.Windows.Forms.Button();
            btn4.Height = 40;
            btn4.Width = 100;
            btn4.Location = new Point(150, btn3.Bottom);
            //btn.Click += Btn_Click;
            //btn.MouseHover += button2_MouseHover;
            btn4.Visible = true;
            //btn5 = new Button();
            //btn5.Height = 40;
            //btn5.Width = 100;
            //btn5.Location = new Point(150, btn4.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn5.Visible = true;
            //btn6 = new Button();
            //btn6.Height = 40;
            //btn6.Width = 100;
            //btn6.Location = new Point(150, btn5.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn6.Visible = true;
            //btn7 = new Button();
            //btn7.Height = 40;
            //btn7.Width = 100;
            //btn7.Location = new Point(150, btn6.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn7.Visible = true;
            //btn8 = new Button();
            //btn8.Height = 40;
            //btn8.Width = 100;
            //btn8.Location = new Point(150, btn7.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn8.Visible = true;
            //btn9 = new Button();
            //btn9.Height = 40;
            //btn9.Width = 100;
            //btn9.Location = new Point(150, btn8.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn9.Visible = true;
            //btn10 = new Button();
            //btn10.Height = 40;
            //btn10.Width = 100;
            //btn10.Location = new Point(150, btn9.Bottom);
            ////btn.Click += Btn_Click;
            ////btn.MouseHover += button2_MouseHover;
            //btn10.Visible = true;




        }
        //private void BtnSave_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch(Exception ex)
        //    {
        //        PictureBox.Show("Save not Successfuly !" + ex);
        //    }
        //    finally
        //    {

        //    }
        //}

        private void btnOpenNewForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the new form
            Form2 f = new Form2(Color.Black);

            // Show the new form
            f.ShowDialog();
        }

    }
}
