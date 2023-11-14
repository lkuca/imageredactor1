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
    public partial class Form1 : Form
    {
        MenuStrip menu;
        System.Windows.Forms.ToolStrip toolstrip;
        Panel p;
        ColorDialog colordiag;
        OpenFileDialog openfilDia;
        SaveFileDialog savfildiag;
        PictureBox pb;
        ImageList il;
        TrackBar trackb;
        ComboBox cbx;
        ToolStripMenuItem windowMenuAbout, windowMenuFile, windowMenuEdit, windowMenuHelp, windowMenuNEW, windowMenuOpen, windowMenuSave, windowMenuExit, windowMenuUndo, windowMenuReno, windowMenuPen, windowMenuStyle, windowMenuSolid,
         windowMenuDot, windowMenuDASHDOTDOT;
        bool drawing;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        Label label_XY;
        public bool MultiSelect { get; set; }
        public Form1()
        {

            InitializeComponent();
            drawing= false;
            currentPen = new Pen(Color.Black);
            this.Height = 600;
            this.Width = 800;
            this.Text = "Paiint";
            menu = new MenuStrip();

            trackb= new TrackBar();
            



            drawing = false;
            currentPen = new Pen(Color.Black);
            







             windowMenuFile = new ToolStripMenuItem("File");
             windowMenuEdit = new ToolStripMenuItem("Muuta");
             windowMenuHelp = new ToolStripMenuItem("Abi");
            
            windowMenuNEW = new ToolStripMenuItem("Uus");
            windowMenuNEW.Text = "&Uus";
            // Assign a shortcut key.
            windowMenuNEW.ShortcutKeys = Keys.Control | Keys.N;
            // Make the menu item visible.
            windowMenuNEW.Visible = true;
            // Display the shortcut key combination.
            windowMenuNEW.ShowShortcutKeys = true;
            windowMenuOpen = new ToolStripMenuItem("Ava");
            windowMenuOpen.Text = "&Ava";
            // Assign a shortcut key.
            windowMenuOpen.ShortcutKeys = Keys.F3;
            // Make the menu item visible.
            windowMenuOpen.Visible = true;
            // Display the shortcut key combination.
            windowMenuOpen.ShowShortcutKeys = true;
            windowMenuOpen.Click += btn_open;
            
            

            windowMenuSave = new ToolStripMenuItem("Salvesta");
            windowMenuSave.Text = "&Salvesta";
            // Assign a shortcut key.
            windowMenuSave.ShortcutKeys = Keys.F2;
            // Make the menu item visible.
            windowMenuSave.Visible = true;
            // Display the shortcut key combination.
            windowMenuSave.ShowShortcutKeys = true;
            windowMenuSave.Click += btn_save;
            windowMenuExit = new ToolStripMenuItem("Sule");
            windowMenuExit.Text = "&Sule";
            // Assign a shortcut key.
            windowMenuExit.ShortcutKeys = Keys.Alt | Keys.X;
            // Make the menu item visible.
            windowMenuExit.Visible = true;
            // Display the shortcut key combination.
            windowMenuExit.ShowShortcutKeys = true;
            windowMenuUndo = new ToolStripMenuItem("Undo");
            windowMenuUndo.Text = "&Undo";
            // Assign a shortcut key.
            windowMenuUndo.ShortcutKeys = Keys.Control | Keys.Z;
            // Make the menu item visible.
            windowMenuUndo.Visible = true;
            // Display the shortcut key combination.
            windowMenuUndo.ShowShortcutKeys = true;
            windowMenuReno = new ToolStripMenuItem("Reno");
            windowMenuReno.Text = "&Reno";
            // Assign a shortcut key.
            windowMenuReno.ShortcutKeys = Keys.Control | Keys.Shift | Keys.Z;
            // Make the menu item visible.
            windowMenuReno.Visible = true;
            // Display the shortcut key combination.
            windowMenuReno.ShowShortcutKeys = true;
            windowMenuPen = new ToolStripMenuItem("Pliiats");
            windowMenuPen.Checked = true;
             windowMenuStyle = new ToolStripMenuItem("Stiil");
            windowMenuStyle.Checked = true;
             windowMenuSolid = new ToolStripMenuItem("Solid");
            windowMenuSolid.Checked = true;
             windowMenuDot = new ToolStripMenuItem("Dot");
             windowMenuDASHDOTDOT = new ToolStripMenuItem("DashDOTDOT");



            //SaveFileDialog savfildiag = new SaveFileDialog();
            //savfildiag.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            //savfildiag.Title = "Save an Image File";
            //savfildiag.FilterIndex = 4;
            //savfildiag.ShowDialog();
            //if (savfildiag.FileName != "")
            //{
            //    System.IO.FileStream fs =(System.IO.FileStream)savfildiag.OpenFile();
            //    switch (savfildiag.FilterIndex)
            //    {
            //        case 1:
            //            this.pb.Image.Save(fs, ImageFormat.Jpeg); break;

            //        case 2:
            //            this.pb.Image.Save(fs, ImageFormat.Bmp); break;


            //        case 3:
            //            this.pb.Image.Save(fs, ImageFormat.Gif); break;

            //        case 4:
            //            this.pb.Image.Save(fs, ImageFormat.Png); break;
            //    }
            //    fs.Close();
            //}



             windowMenuAbout = new ToolStripMenuItem("About(Umbes)");
            windowMenuAbout.Text = "&About(Umbes)";
            // Assign a shortcut key.
            windowMenuAbout.ShortcutKeys = Keys.F1;
            // Make the menu item visible.
            windowMenuAbout.Visible = true;
            // Display the shortcut key combination.
            windowMenuAbout.ShowShortcutKeys = true;




            //ToolStripMenuItem windowNewMenu = new ToolStripMenuItem("New", null, new EventHandler(windowNewMenu_Click));
            //windowMenu.DropDownItems.Add(windowNewMenu);



            pb = new PictureBox();
            pb.Image = new Bitmap(500, 700);
            pb.Location = new Point(menu.Width);
            pb.Size= new Size(500,700);
            pb.Visible = true;
            pb.BackColor = Color.Gray;

            
            


            menu.Items.Add(windowMenuEdit);
            menu.Items.Add(windowMenuHelp);
            menu.Items.Add(windowMenuFile);
            windowMenuFile.DropDownItems.Add(windowMenuNEW);
            windowMenuFile.DropDownItems.Add(windowMenuOpen);
            windowMenuFile.DropDownItems.Add(windowMenuSave);
            windowMenuFile.DropDownItems.Add(windowMenuExit);
            windowMenuEdit.DropDownItems.Add(windowMenuUndo);
            windowMenuEdit.DropDownItems.Add(windowMenuReno);
            windowMenuEdit.DropDownItems.Add(windowMenuPen);
            windowMenuHelp.DropDownItems.Add(windowMenuAbout);
            windowMenuPen.DropDownItems.Add(windowMenuStyle);
            windowMenuStyle.DropDownItems.Add(windowMenuSolid);
            windowMenuStyle.DropDownItems.Add(windowMenuDot);
            windowMenuStyle.DropDownItems.Add(windowMenuDASHDOTDOT);


            menu.Visible = true;
            this.Controls.Add(menu);
            this.Controls.Add(pb);
            




        }
        
        private bool ShowShortcutKeys { get; set; }
        private void SetupMyMenuItem(object sender, EventArgs e)
        {
            //// Set the caption for the menu item.
            //windowMenuNEW.Text = "&New";
            //// Assign a shortcut key.
            //windowMenuNEW.Shortcut = Shortcut.CtrlN;
            //// Make the menu item visible.
            //windowMenuNEW.Visible = true;
            //// Display the shortcut key combination.
            //windowMenuNEW.ShowShortcut = true;
        }
        private void btn_save(object sender, EventArgs e)
        {
            SaveFileDialog savfildiag = new SaveFileDialog();
            savfildiag.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            savfildiag.Title = "Save an Image File";
            savfildiag.FilterIndex = 4;
            savfildiag.ShowDialog();
            if (savfildiag.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)savfildiag.OpenFile();
                switch (savfildiag.FilterIndex)
                {
                    case 1:
                        this.pb.Image.Save(fs, ImageFormat.Jpeg); break;

                    case 2:
                        this.pb.Image.Save(fs, ImageFormat.Bmp); break;


                    case 3:
                        this.pb.Image.Save(fs, ImageFormat.Gif); break;

                    case 4:
                        this.pb.Image.Save(fs, ImageFormat.Png); break;
                }
                fs.Close();
            }
        }
        private void btn_open(object sender, EventArgs e)
        {
            openfilDia = new OpenFileDialog();
            openfilDia.Filter = "JPG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            openfilDia.Title = "Open an Image file";
            openfilDia.FilterIndex= 1;
            if (openfilDia.ShowDialog() != DialogResult.Cancel)
                pb.Load(openfilDia.FileName);
            pb.SizeMode= PictureBoxSizeMode.StretchImage;

        }
        private void picDrawingSurface_mouseDown(object sender, MouseEventArgs e)
        {

            if (pb.Image == null)
            {
                MessageBox.Show("alguses laadige uus fail!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation= e.Location;
                currentPath = new GraphicsPath();
            }

            //drawing = false;
            //try
            //{
            //    currentPath.Dispose();
            //}
            //catch { };
        }
        private void picDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            try
            {
                currentPath.Dispose();
            }
            catch { };
        }
        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            if(drawing)
            {
                Graphics g = Graphics.FromImage(pb.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen,currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pb.Invalidate();
                label_XY.Text = e.X.ToString() + ", " + e.Y.ToString();
                
            }
        }
        



    }
    
}