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
        public int NumberOfSeries0 = 0, NumberOfSeries1 = 1, NumberOfSeries2 = 2;
        private void method1(object sender, EventArgs e)
        {
            decimal[] x1 = {0, 1, 2};
            buttonStart.Click -= method1;
            Polynomial p = new Polynomial();

            Point[] Points1 = { new Point(-2.789m, 0), new Point(-1.456m, 0), new Point(-0.123m, 0), new Point(0, 0), new Point(0.123m, 0), new Point(1.456m, 0), new Point(2.789m, 0) };
            decimal[] coefficients1 = new decimal[3] { 1, 2, 3 };
            Point[] Points2 = { new Point(-2.789m, 0), new Point(-1.456m, 0), new Point(-0.123m, 0), new Point(0, 0), new Point(0.123m, 0), new Point(1.456m, 0), new Point(2.789m, 0) };
            decimal[] coefficients2 = new decimal[2] { 1, 2 };
            Point[] Points3 = { new Point(-2.789m, 0), new Point(-1.456m, 0), new Point(-0.123m, 0), new Point(0, 0), new Point(0.123m, 0), new Point(1.456m, 0), new Point(2.789m, 0) };
            decimal SinusoidFreeTerm1 = 5.0m;

            Parabola parabola = new Parabola(coefficients1);
            parabola.BuiltPoints(x1);

           /* Straight straight = new Straight(coefficients2, NumberOfSeries1);
            straight.Function(Points2, (Form1)Form1.ActiveForm);

            Sinusoid sinusoid = new Sinusoid(SinusoidFreeTerm1, NumberOfSeries2);
            sinusoid.Function(Points3, (Form1)Form1.ActiveForm);

            Collision c = new Collision();
            c.ChechCollision(Points1, (Form1)Form1.ActiveForm);
            c.ChechCollision(Points2, (Form1)Form1.ActiveForm);
            c.ChechCollision(Points3, (Form1)Form1.ActiveForm);*/

/*            string parabolal = "";
            string straightl = "";
            string sinusoidl = "";

            foreach (Point p in Points1)
            {
                parabolal += "\r\n" + p.ToString();
            }
            textBoxParabola.Text = "Парабола\n\r" + parabolal;

            foreach (Point p in Points2)
            {
                straightl += "\r\n" + p.ToString();
            }
            textBoxStraight.Text = "Прямая\n\r" + straightl;

            foreach (Point p in Points3)
            {
                sinusoidl += "\r\n" + p.ToString();
            }
            textBoxSinusoid.Text = "Синусойда\n\r" + sinusoidl;*/
        }
    }
}
