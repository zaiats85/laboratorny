using System;
using System.Drawing;
using System.Windows.Forms;

public class Exercise : Form
{
    public Exercise()
    {
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Paint += new PaintEventHandler(DrawImage2FloatRectF);
        this.SuspendLayout();
        // 
        // Exercise
        // 
        this.ClientSize = new System.Drawing.Size(284, 261);
        this.Name = "Exercise";
        this.Load += new System.EventHandler(this.Exercise_Load);
        this.Paint += new System.Windows.Forms.PaintEventHandler(this.Exercise_Paint);
        this.ResumeLayout(false);
    }

    public void DrawImage2FloatRectF(object sender, PaintEventArgs e)
    {

        // Create image.
        Image newImage = Image.FromFile("/Users/olegz/Downloads/honda.jpg");

        // Create coordinates for upper-left corner of image.
        float x = 150.0F;
        float y = 50.0F;

        // Create rectangle for source image.
        RectangleF srcRect = new RectangleF(20.0F, 10.0F, 750.0F, 450.0F);
        GraphicsUnit units = GraphicsUnit.Pixel;

        // Draw image to screen.
        e.Graphics.DrawImage(newImage, x, y, srcRect, units);
    }

    private void Exercise_Paint(object sender, PaintEventArgs e)
    {
        Pen penCurrent = new Pen(Color.Blue);
        Point[] pt = { new Point( 40,  42),
                  new Point(188, 246),
                              new Point(484, 192),
                  new Point(350,  48) };

        e.Graphics.DrawCurve(penCurrent, pt);
    }

    private void Exercise_Load(object sender, EventArgs e)
    {

    }
}
