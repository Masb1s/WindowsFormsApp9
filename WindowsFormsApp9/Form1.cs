using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = 50;
            int y = 120;

            Pen pen = new Pen(Color.Black, 2);

            Brush body = Brushes.Gray;
            Brush tire = Brushes.Black;
            Brush rim = Brushes.White;

            Point[] cabin =
            {
        new Point(x, y),
        new Point(x + 20, y - 25),
        new Point(x + 60, y - 25),
        new Point(x + 60, y + 20),
        new Point(x, y + 20)
    };

            Rectangle cargo = new Rectangle(x + 70, y - 25, 100, 45);

            g.FillPolygon(body, cabin);
            g.DrawPolygon(pen, cabin);

            g.FillRectangle(body, cargo);
            g.DrawRectangle(pen, cargo);

            g.FillRectangle(Brushes.LightBlue, x + 25, y - 20, 25, 15);
            g.DrawRectangle(pen, x + 25, y - 20, 25, 15);

            int wheelD = 30;

            g.FillEllipse(tire, x + 15, y + 10, wheelD, wheelD);
            g.FillEllipse(rim, x + 22, y + 17, 16, 16);

            g.FillEllipse(tire, x + 110, y + 10, wheelD, wheelD);
            g.FillEllipse(rim, x + 117, y + 17, 16, 16);

            pen.Dispose();
        }

    }
}
