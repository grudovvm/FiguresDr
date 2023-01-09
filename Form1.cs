using System.Threading;

namespace FiguresDr;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCircle_Click(object sender, EventArgs e)
    {
        
    }
    public void RectangleThread()
    {
        for (int i = 0; i < 1000; i++)
        {
            Random random = new Random();
            Pen pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
            Graphics rectangle = this.CreateGraphics();
            rectangle.DrawRectangle(pen, random.Next(0, this.Width - 155), random.Next(0, this.Height - 155), random.Next(50, 150), random.Next(50, 150));
            Thread.Sleep(3000);
        }
    }

    private void btnRectangle_Click(object sender, EventArgs e)
    {
        Thread thread1 = new Thread(RectangleThread);
        thread1.Start();
    }
}
