using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertGPT
{
    public partial class DatabaseScreen : UserControl
    {
        private FileStream fs;
        private Point LastPoint;
        private Bitmap img;

        private double ratio = 1.0F;
        private Point imgPoint;
        private Rectangle imgRect;
        private Point clickPoint;
        public DatabaseScreen()
        {
            InitializeComponent();
            this.AllowDrop = true;
            
        }

        private void DatabaseScreen_Load(object sender, EventArgs e)
        {

        }

        private void DBDiagramImg_MouseWheel(object sender, MouseEventArgs e)
        {
            int lines = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            PictureBox pb = (PictureBox)sender;

            if (lines > 0)
            {
                ratio *= 1.1F;
                if (ratio > 100.0) ratio = 100.0f;

                imgRect.Width = (int)Math.Round(DBDiagramImg.Width * ratio);
                imgRect.Height = (int)Math.Round(DBDiagramImg.Height * ratio);
                imgRect.X = -(int)Math.Round(1.1F * (imgPoint.X - imgRect.X) - imgPoint.X);
                imgRect.Y = -(int)Math.Round(1.1F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
            }
            else if (lines < 0)
            {
                ratio *= 0.9F;
                if (ratio < 1) ratio = 1;

                imgRect.Width = (int)Math.Round(DBDiagramImg.Width * ratio);
                imgRect.Height = (int)Math.Round(DBDiagramImg.Height * ratio);
                imgRect.X = -(int)Math.Round(0.9F * (imgPoint.X - imgRect.X) - imgPoint.X);
                imgRect.Y = -(int)Math.Round(0.9F * (imgPoint.Y - imgRect.Y) - imgPoint.Y);
            }

            if (imgRect.X > 0) imgRect.X = 0;
            if (imgRect.Y > 0) imgRect.Y = 0;
            if (imgRect.X + imgRect.Width < DBDiagramImg.Width) imgRect.X = DBDiagramImg.Width - imgRect.Width;
            if (imgRect.Y + imgRect.Height < DBDiagramImg.Height) imgRect.Y = DBDiagramImg.Height - imgRect.Height;
            DBDiagramImg.Invalidate();
        }

        private async void DatabaseScreen_DragDropAsync(object sender, DragEventArgs e)
        {
            Console.WriteLine("DBScreen_DragDrop");
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileNameIabel.Text = Path.GetFileName(filePaths[0]);
            PromptToImageService pis = new PromptToImageService();
            await pis.GetResponse(new DBDiagramType(filePaths[0]));
            using (fs = new FileStream("out.png", FileMode.Open, FileAccess.Read))
            {

                DBDiagramImg.Image = Image.FromStream(fs);
                img = new Bitmap(fs);
                imgPoint = new Point(DBDiagramImg.Width / 2, DBDiagramImg.Height / 2);
                imgRect = new Rectangle(0, 0, DBDiagramImg.Width, DBDiagramImg.Height);
                ratio = 1.0;
                clickPoint = imgPoint;

                DBDiagramImg.Invalidate();
            }
        }

        private void DatabaseScreen_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("DragForm_DragEnter");
            /*Controls.Add(guideScreen);
            guideScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            guideScreen.BringToFront();*/

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DBDiagramImg_Paint(object sender, PaintEventArgs e)
        {
            if (DBDiagramImg.Image != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                e.Graphics.DrawImage(DBDiagramImg.Image, imgRect);
                DBDiagramImg.Focus();
            }
        }

        private void DBDiagramImg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clickPoint = new Point(e.X, e.Y);
            }
            DBDiagramImg.Invalidate();
        }

        private void DBDiagramImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                imgRect.X = imgRect.X + (int)Math.Round((double)(e.X - clickPoint.X) / 5);
                if (imgRect.X >= 0) imgRect.X = 0;
                if (Math.Abs(imgRect.X) >= Math.Abs(imgRect.Width - DBDiagramImg.Width)) imgRect.X = -(imgRect.Width - DBDiagramImg.Width);
                imgRect.Y = imgRect.Y + (int)Math.Round((double)(e.Y - clickPoint.Y) / 5);
                if (imgRect.Y >= 0) imgRect.Y = 0;
                if (Math.Abs(imgRect.Y) >= Math.Abs(imgRect.Height - DBDiagramImg.Height)) imgRect.Y = -(imgRect.Height - DBDiagramImg.Height);
            }
            else
            {
                LastPoint = e.Location;
            }

            DBDiagramImg.Invalidate();
        }
    }
}
