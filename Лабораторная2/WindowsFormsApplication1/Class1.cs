using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Point
    {
        public double x; //coordinates of points
        public double y;
        public Point(double x, double y) //constructor with a pointer to the object
        {
            this.x = x;
            this.y = y;
        }
    }

    public abstract class Trajectory // Траектория
    {
        public abstract void Function(Point[] Points, Form1 Okno);
    }

    public class Polynomial : Trajectory  //Многочлен n-ого порядка. Имеет вид c0 + c1*x + c2*(x^2) + ...
    {
        public int NumberOfSeries;
        public double[] coefficients; //В массиве содержатся коэффициенты для определение многочлена той или иной степени
        //В данном методе определяется уравнение для нахождения значений фукнции. 
        //Например: если в массиве коэффициентов будет три элемента, значит степень многочлена будет второй. 
        //Следовательно мы имеем дело с параболой
        public int NumberOfCoefficients //properties, which specifies the conditions the number ofcoefficients
        {
            get
            {
                NumberOfCoefficients = coefficients.Length;
                return NumberOfCoefficients;
            }
            set
            { }
        }
        public override void Function(Point[] Points, Form1 Okno)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < coefficients.Length; j++)
                {
                    Points[i].y = Points[i].y + coefficients[j] * Math.Pow(Points[i].x, j);
                }
                //Okno.NewLines[NumberOfSeries][i+1] = "(" + Points[i].x.ToString() + "; " +  Points[i].y.ToString() + ")";
               // Console.WriteLine("({0}; {1})", Points[i].x, Points[i].y); 
                Okno.chart1.Series[NumberOfSeries].Points.AddXY(Points[i].x, Points[i].y);
            }
        }
    }

    public class Parabola : Polynomial //Парабола         
    {
        public Parabola(double[] coefficients, int NumberOfSeries) //constructor with a pointer to the object
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                this.NumberOfSeries = NumberOfSeries;
            }
        }
    }

    public class Straight : Polynomial  //Прямая   
    {
        public Straight(double[] coefficients, int NumberOfSeries) //constructor with a pointer to the object
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
                this.NumberOfSeries = NumberOfSeries;
            }
        }
    }

    public class TranscendentalCurves : Trajectory  // Трансцендентные кривые
    {
        public int NumberOfSeries;
        protected double SinusoidFreeTerm; // свободный член для синусоиды
        public override void Function(Point[] Points, Form1 Okno) //В данном методе находим значения функции. Функция уже будет выглядить как многочлен.
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < Points.Length; j++)
                {
                    Points[i].y = Math.Sin(Points[i].x) + SinusoidFreeTerm;
                }
                Okno.chart1.Series[NumberOfSeries].Points.AddXY(Points[i].x, Points[i].y);
            }
        }
    }

    public class Sinusoid //Синусоида
        : TranscendentalCurves
    {
        public Sinusoid(double SinusoidFreeTerm, int NumberOfSeries) //constructor with a pointer to the object
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.NumberOfSeries = NumberOfSeries;
        }
    }


    public class Collision //Столкновение
    {
        public Point[] PointsCollision = { new Point(0.12, 1.29), new Point(1, 1), new Point(3, 9), new Point(1.45, 3.91), new Point(2.78, 5.34) };
        public void ChechCollision(Point[] Points, Form1 Okno)
        {
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                for (int j = 0; j < PointsCollision.GetLength(0); j++)
                {
                    string str1 = Points[i].x.ToString();
                    string str2 = Points[i].y.ToString();
                    string str3 = PointsCollision[j].x.ToString();
                    string str4 = PointsCollision[j].y.ToString();
                    if (str1.Remove(0) == str3 && str2.Remove(0) == str4)
                    {
                        Console.WriteLine("Произошлко столкновение с перпятствием в точке: ({0}; {1}) ", Points[i].x, Points[i].y);
                    }
                    Okno.chart1.Series[3].Points.AddXY(PointsCollision[j].x, PointsCollision[j].y);
                } 
            }
        }
    }
}