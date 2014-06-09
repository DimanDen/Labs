using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajectory
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
        public abstract void Function(Point[] Points);
    }

    class Polynomial : Trajectory  //Многочлен n-ого порядка. Имеет вид c0 + c1*x + c2*(x^2) + ...
    {
        protected double[] coefficients; //В массиве содержатся коэффициенты для определение многочлена той или иной степени
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
        public override void Function(Point[] Points)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < coefficients.Length; j++)
                {
                    Points[i].y = Points[i].y + coefficients[j] * Math.Pow(Points[i].x, j);
                }
                Console.WriteLine("({0}; {1})", Points[i].x, Points[i].y);
            }
        }
    }

    class Parabola : Polynomial //Парабола         
    {
        public Parabola(double[] coefficients) //constructor with a pointer to the object
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
            }
        }
    }

    class Straight : Polynomial  //Прямая   
    {
        public Straight(double[] coefficients) //constructor with a pointer to the object
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
            }
        }
    }

    class TranscendentalCurves : Trajectory  // Трансцендентные кривые
    {
        protected double SinusoidFreeTerm; // свободный член для синусоиды
        public override void Function(Point[] Points) //В данном методе находим значения функции. Функция уже будет выглядить как многочлен.
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < Points.Length; j++)
                {
                    Points[i].y = Math.Sin(Points[i].x) + SinusoidFreeTerm;
                }
                Console.WriteLine("({0}; {1})", Points[i].x, Points[i].y);
            }
        }
    }

    class Sinusoid //Синусоида
        : TranscendentalCurves
    {
        public Sinusoid(double SinusoidFreeTerm) //constructor with a pointer to the object
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
        }
    }


    class Collision //Столкновение
    {
        public Point[] PointsCollision = { new Point(0.12, 1.29), new Point(1, 1), new Point(3, 9), new Point(1.45, 3.91), new Point(2.78, 5.34) };
        public void ChechCollision(Point[] Points)
        {
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                for (int j = 0; j < PointsCollision.GetLength(0); j++)
                {
                    string str1 = Points[i].x.ToString();
                    string str2 = Points[i].y.ToString();
                    string str3 = PointsCollision[j].x.ToString();
                    string str4 = PointsCollision[j].y.ToString();
                    if (str1.Remove(4) == str3 && str2.Remove(4) == str4)
                    {
                        Console.WriteLine("Произошлко столкновение с перпятствием в точке: ({0}; {1}) ", Points[i].x, Points[i].y);
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Point[] Points1 = { new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double[] coefficients1 = new double[3] { 1, 2, 3 };
            Point[] Points2 = { new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double[] coefficients2 = new double[2] { 1, 2 };
            Point[] Points3 = { new Point(0.123, 0), new Point(1.456, 0), new Point(2.789, 0) };
            double SinusoidFreeTerm1 = 5.0;

            Console.WriteLine("Парабола");
            Parabola parabola = new Parabola(coefficients1);
            parabola.Function(Points1);

            Console.WriteLine("\nПрямая");
            Straight straight = new Straight(coefficients2);
            straight.Function(Points2);

            Console.WriteLine("\nСинусоида");
            Sinusoid sinusoid = new Sinusoid(SinusoidFreeTerm1);
            sinusoid.Function(Points3);

            Console.WriteLine("\nИнформация о столкновении с препятствиями:");
            Collision c = new Collision();
            Console.WriteLine("\nНаличие столкновения у параболы:");
            c.ChechCollision(Points1);
            Console.WriteLine("\nНаличие столкновения у прямой:");
            c.ChechCollision(Points2);
            Console.WriteLine("\nНаличие столкновения у синусоиды:");
            c.ChechCollision(Points3);
            Console.ReadKey();
        }
    }
}