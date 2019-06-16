using System;
using System.Drawing;
using System.Windows.Forms;

public class TrigFunctions : Form
{
    public TrigFunctions()
    {
        Text = "Trig Functions";
        ResizeRedraw = true;
        InitializeComponent();
    }

    void InitializeComponent()
    {
        Paint += new PaintEventHandler(TrigonometricFunctions);
        Paint += new PaintEventHandler(DrawLinePointF);
    }

    

    public void DrawLinePointF(object sender, PaintEventArgs e)
    {
        // Create pen 
        Pen blackPen = new Pen(Color.Black, 1);

        // Create points that define a line
        PointF point1 = new PointF(0, 350);
        PointF point2 = new PointF(900, 350);
        PointF point3 = new PointF(50, 600);
        PointF point4 = new PointF(50, -600);

        // Draw Line to screen.
        e.Graphics.DrawLine(blackPen, point1, point2);
        e.Graphics.DrawLine(blackPen, point3, point4);

    }

    private void TrigonometricFunctions(object sender, PaintEventArgs e)
    {

        int cx = 800; // number of x points
        int cy = 200; // y sin interva;
        int dY = 250; // y shift
        int dX = 50; // x shift
        double argument = 2 * Math.PI / (cx - 1);

        Pen penSine = new Pen(Color.Blue);
        Pen penCosine = new Pen(Color.Red);
        Pen penTg = new Pen(Color.Green);

        PointF[] ptSine = new PointF[cx];
        PointF[] ptCosine = new PointF[cx];
        PointF[] ptTg = new PointF[cx];
       
        for (int i = 0; i < cx; i++)
        {
            ptSine[i].X = i+ dX;
            ptSine[i].Y = cy / 2 * (1 - (float) Math.Sin(i * argument)) + dY;
            ptCosine[i].X = i + dX;
            ptCosine[i].Y = cy / 2 * (1 - (float)Math.Cos(i * argument)) + dY;
            ptTg[i].X = i + dX;
            ptTg[i].Y = cy / 2 * (1 - (float)Math.Tan(i * argument)) + dY;

        }

        e.Graphics.DrawCurve(penCosine, ptCosine);
        e.Graphics.DrawCurve(penSine, ptSine);
        e.Graphics.DrawCurve(penTg, ptTg);
    }
}

public class Program
{
    public static int Main()
    {
        //Application.Run(new TrigFunctions());
        //Application.Run(new WindowsFormsApplication1.Form1());
        Application.Run(new Form2());

        return 0;
    }
}