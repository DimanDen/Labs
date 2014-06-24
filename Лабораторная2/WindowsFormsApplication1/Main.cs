using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void method1(object sender, EventArgs e)
        {
            buttonStart.Click -= method1;

            Point TestPoint =  new Point(-1, 2);
            decimal[] x1 = { -2, -1, 0, 1, 2 };
            decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
            decimal[] coefficients2 = new decimal[2] { 1, 2 };
            decimal SinusoidFreeTerm1 = 5.0m;

            string parabolal = "";
            string straightl = "";
            string sinusoidl = "";

            Parabola parabola = new Parabola(coefficients1, x1);
            foreach (Point p in parabola.Points)
            {
                chart1.Series[0].Points.AddXY(p.x, p.y);
                parabolal += "\r\n" + p.ToString();
            }
            parabola.Collision(TestPoint);
            textBoxParabola.Text = "Парабола\n\r" + parabolal;
            textboxCollision.AppendText("\r\nПарабола: " + TestPoint.ToString() + " - " + parabola.Collision(TestPoint).ToString());

            Straight straight = new Straight(coefficients2, x1);
            foreach (Point s in straight.Points)
            {
                chart1.Series[1].Points.AddXY(s.x, s.y);
                straightl += "\r\n" + s.ToString();
            }
            textBoxStraight.Text = "Прямая\n\r" + straightl;
            textboxCollision.AppendText("\r\nПрямая: " + TestPoint.ToString() + " - " + straight.Collision(TestPoint).ToString());

            Sinusoid sinusoid = new Sinusoid(SinusoidFreeTerm1, x1);
            foreach (Point sin in sinusoid.Points)
            {
                chart1.Series[2].Points.AddXY(sin.x, sin.y);
                sinusoidl += "\r\n" + sin.ToString();
            }
            textBoxSinusoid.Text = "Синусойда\n\r" + sinusoidl;
            textboxCollision.AppendText("\r\nСинусойда: " + TestPoint.ToString() + " - " + sinusoid.Collision(TestPoint).ToString());

            chart1.Series[3].Points.AddXY(TestPoint.x, TestPoint.y);
        }
    }
}
