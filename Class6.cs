using System;
using System.Windows.Forms;
using System.Drawing;
 
namespace WindowsApplication1
{
    public class Program: Form
    {
        private System.ComponentModel.IContainer components;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Program());
        }

        int x = 100, y = 100;
        double a = 0;
        double b = 0;
        Timer t = new Timer();
        Program()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(ImageExampleForm_Paint);
            t.Interval = 100;
            t.Enabled = true;
            t.Tick += new EventHandler(t_Tick);
        }
 
        void t_Tick(object sender, EventArgs e)
        {
            a += 0.4;
            b += 0.1;
            Invalidate(new Rectangle());
        }
 
        private void ImageExampleForm_Paint(object sender, PaintEventArgs e)
        {
            // Create image.
            Image newImage = Image.FromFile("/Users/olegz/Downloads/honda.jpg");

            // Create Point for upper-left corner of image.
            Point ulCorner = new Point((int)(x * Math.Sin(a)), (int)(y * Math.Cos(b)));

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, ulCorner);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(586, 452);
            this.Name = "Program";
            this.ResumeLayout(false);
        }
    }
}
