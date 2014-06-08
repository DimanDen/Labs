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
        public abstract void Function(Point[] Points, double[] coefficients);
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

        public override void Function(Point[] Points, double[] coefficients)
        {
        }
    }


    class Parabola : Polynomial //Парабола         
    {
        public Parabola(double[] coefficients) //constructor with a pointer to the object
        {
            if (NumberOfCoefficients == 3)
            {
                this.coefficients = coefficients;
            }
        }
    }

    class Straight : Polynomial  //Прямая   
    {
        public Straight(double[] coefficients) //constructor with a pointer to the object
        {
            if (NumberOfCoefficients == 2)
            {
                this.coefficients = coefficients;
            }
        }
    }

    class TranscendentalCurves : Trajectory  // Трансцендентные кривые
    {
        protected double SinusoidFreeTerm; // свободный член для синусоиды
        public override void Function(Point[] Points, double[] coefficients) //В данном методе находим значения функции. Функция уже будет выглядить как многочлен.
        {
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
        public Point[] PointsCollision;
        public void ChechCollision(Point[] Points1)
        {
        }

    }

    class Program
    {
        static void Main()
        {
        }
    }
}