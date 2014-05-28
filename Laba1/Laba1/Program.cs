using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajectory
{
    interface IFunction //Метод определения значения функции
    {
        void Function();
    }

    class Point
    {
        public double x; //coordinates of points
        public double y;
        public Point(double x, double y) //constructor with a pointer to the object
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Trajectory : IFunction // Траектория
    {
        static public double[] x; //координаты точек на оси асцисс
        static public double[] y; //координаты точек на оси ординат
        public void Function()
        {
        }
    }

    class Polynomial : Trajectory  //Многочлен n-ого порядка. Имеет вид c0 + c1*x + c2*(x^2) + ...
    {
        protected double[] coefficients; //В массиве содержатся коэффициенты для определение многочлена той или иной степени
        //В данном методе определяется уравнение для нахождения значений фукнции. 
        //Например: если в массиве коэффициентов будет три элемента, значит степень многочлена будет второй. 
        //Следовательно мы имеем дело с параболой

        public Point[] Points1; //Координаты точек движущегося объекта
        public void Function() 
        {
        }
    }


    class Parabola : Polynomial //Парабола         
    {
        public Parabola(double[] coefficients) 
        {
            this.coefficients = coefficients;
        }
    }

    class Straight : Polynomial  //Прямая   
    {
        public Straight(double[] coefficients) 
        {
            this.coefficients = coefficients;
        }
    }

    class TranscendentalCurves : Trajectory  // Трансцендентные кривые
    {
        protected double b; // свободный член для синусоиды

        public Point[] Points1; //Координаты точек движущегося объекта
        public void Function() //В данном методе находим значения функции. Функция уже будет выглядить как многочлен.
        {
        }
    }

    class Sinusoid //Синусоида
        : TranscendentalCurves
    {
        public Sinusoid(double b) 
        {
            this.b = b;
        }
    }

    class Collision //Столкновение
    {
        public Point[] PointsCollision; //Координаты посторонних предметов
        public void ChechCollision(Point[] Points1) //Проверка на столкновение
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