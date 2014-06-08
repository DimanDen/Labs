using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string[][] NewLines = new string[3][];
        public int NumberOfSeries0 = 0, NumberOfSeries1 = 1, NumberOfSeries2 = 2;
        private void method1(object sender, EventArgs e)
        {
            /*NewLines[0] = new string[20];
            NewLines[1] = new string[20];
            NewLines[2] = new string[20];
            
            textBox1.Lines = NewLines[0];
            textBox2.Lines = NewLines[1];
            textBox3.Lines = NewLines[2];
            NewLines[1][0] = "s";*/
            
            Point[] Points1 = { new Point(-2.789, 0), new Point(-1.456, 0), new Point(-0.123, 0), new Point(0, 0), new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double[] coefficients1 = new double[3] { 1, 2, 3 };
            Point[] Points2 = { new Point(-2.789, 0), new Point(-1.456, 0), new Point(-0.123, 0), new Point(0, 0), new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double[] coefficients2 = new double[2] { 1, 2 };
            Point[] Points3 = { new Point(-2.789, 0), new Point(-1.456, 0), new Point(-0.123, 0), new Point(0, 0), new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double SinusoidFreeTerm1 = 5.0;

            //NewLines[0][0] = "Парабола:";
            Parabola parabola = new Parabola(coefficients1, NumberOfSeries0);
            parabola.Function(Points1, (Form1)Form1.ActiveForm);

            //NewLines[1][0] = "Прямая:";
            Straight straight = new Straight(coefficients2, NumberOfSeries1);
            straight.Function(Points2, (Form1)Form1.ActiveForm);

            //NewLines[2][0] = "Cинусоида:";
            Sinusoid sinusoid = new Sinusoid(SinusoidFreeTerm1, NumberOfSeries2);
            sinusoid.Function(Points3, (Form1)Form1.ActiveForm);

            // Console.WriteLine("\nИнформация о столкновении с препятствиями:");
            Collision c = new Collision();
            // Console.WriteLine("\nНаличие столкновения у параболы:");
            c.ChechCollision(Points1, (Form1)Form1.ActiveForm);
            //Console.WriteLine("\nНаличие столкновения у прямой:");
            c.ChechCollision(Points2, (Form1)Form1.ActiveForm);
            // Console.WriteLine("\nНаличие столкновения у синусоиды:");
            c.ChechCollision(Points3, (Form1)Form1.ActiveForm);
        }
    }
}
