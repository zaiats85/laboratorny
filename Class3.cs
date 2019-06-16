using System;
using System.Drawing;
using System.Windows.Forms;

public partial class Form2 : Form
{
    private System.Windows.Forms.PictureBox pictureBox1;
    public Form2()
    {
        InitializeComponent();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();

        // 
        // pictureBox1
        // 
        //this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.pictureBox1.Location = new System.Drawing.Point(0, 0);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(50, 50);
        this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 23F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(284, 262);
        this.Controls.Add(this.pictureBox1);
        this.Name = "Move with keyboard";
        this.Text = "Move with keyboard";
        this.Load += Form2_Load;
        this.KeyDown += new KeyEventHandler(Form2_KeyDown);
    }

    private void InitializeComponent()
    {
        Paint += new PaintEventHandler(Form2_Load);
    }

    void Form2_KeyDown(object sender, KeyEventArgs e)
    {
        int x = pictureBox1.Location.X;
        int y = pictureBox1.Location.Y;

        switch (e.KeyCode)
        {
            case Keys.Down:
                y += 5;
                break;
            case Keys.Up:
                y -= 5;
                break;
            case Keys.Right:
                x += 5;
                break;
            case Keys.Left:
                x -= 5;
                break;
        }

        pictureBox1.Location = new Point(x, y);
    }
    private void Form2_Load(object sender, EventArgs e)
    {
        Bitmap b = new Bitmap(1024, 1024);
        using (Graphics g = Graphics.FromImage(b))
        using (System.Drawing.Drawing2D.LinearGradientBrush l = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, b.Width, b.Height), Color.Yellow, Color.Green, 0f))
            g.FillRectangle(l, new Rectangle(0, 0, b.Width, b.Height));

        this.pictureBox1.Image = b;

        //MessageBox.Show(b.Size.ToString());
    }
}