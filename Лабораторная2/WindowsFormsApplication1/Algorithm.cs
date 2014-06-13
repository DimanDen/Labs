using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором содержится массив значений функции и аргумента
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Значение агумента
        /// </summary>
        public decimal x;

        /// <summary>
        /// Значение функции
        /// </summary>
        public decimal y;
        public Point(decimal x, decimal y) 
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "(" + x + "; " + y + ")";
        }
    }

    /// <summary>
    /// Класс, предназначенный для описания траектории
    /// </summary>
    public abstract class Trajectory 
    {
        /// <summary>
        /// Метод, вычисляющий значение функции
        /// </summary>
        /// <param name="Points"></param>
        /// <param name="Okno"></param>
        public abstract void Function(Point[] Points, Form1 Okno);
    }

    /// <summary>
    /// Класс, описывающий функцию в виде многочлен степени n
    /// </summary>
    public class Polynomial : Trajectory 
    {
        /// <summary>
        /// Вспомогательная переменная, определяющая, какой график необходимо строить
        /// </summary>
        public int NumberOfSeries;

        /// <summary>
        /// Массив, содержащий в себе коэффициенты, стоящие перед аргументами разных степеней
        /// </summary>
        public decimal[] coefficients;

        /// <summary>
        /// Метод, вычисляющий значение функции
        /// </summary>
        /// <param name="Points"></param>
        /// <param name="Okno"></param>
        public override void Function(Point[] Points, Form1 Okno)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < coefficients.Length; j++)
                {
                    Points[i].y = Points[i].y + coefficients[j] * (decimal)Math.Pow((double)Points[i].x, j);
                }
                Okno.chart1.Series[NumberOfSeries].Points.AddXY(Points[i].x, Points[i].y);
            }
        }
    }

    /// <summary>
    /// Класс, описывающий траекторию в виде параболы.
    /// </summary>
    public class Parabola : Polynomial       
    {
        public Parabola(decimal[] coefficients, int NumberOfSeries) 
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                this.NumberOfSeries = NumberOfSeries;
            }
        }
    }

    /// <summary>
    /// Класс, описывающий траекторию в виде прямой.
    /// </summary>
    public class Straight : Polynomial 
    {
        public Straight(decimal[] coefficients, int NumberOfSeries)
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
                this.NumberOfSeries = NumberOfSeries;
            }
        }
    }

    /// <summary>
    /// Класс, описывающий траекторию, заданную с помощью трансцендентных кривых
    /// </summary>
    public class TranscendentalCurves : Trajectory
    {
        /// <summary>
        /// Вспомогательная переменная, определяющая, какой график необходимо строить
        /// </summary>
        public int NumberOfSeries;
        /// <summary>
        /// Свободный член в уранении синусоиды
        /// </summary>
        protected decimal SinusoidFreeTerm; 
        /// <summary>
        /// Метод, вычисляющий значение функции
        /// </summary>
        /// <param name="Points"></param>
        /// <param name="Okno"></param>
        public override void Function(Point[] Points, Form1 Okno) //В данном методе находим значения функции. Функция уже будет выглядить как многочлен.
        {
            for (int i = 0; i < Points.Length; i++)
            {
                for (int j = 0; j < Points.Length; j++)
                {
                    Points[i].y = (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
                }
                Okno.chart1.Series[NumberOfSeries].Points.AddXY(Points[i].x, Points[i].y);
            }
        }
    }

    /// <summary>
    /// Класс, описывающий траекторию в виде синусоиды
    /// </summary>
    public class Sinusoid 
        : TranscendentalCurves
    {
        public Sinusoid(decimal SinusoidFreeTerm, int NumberOfSeries) 
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.NumberOfSeries = NumberOfSeries;
        }
    }

    /// <summary>
    /// Класс, в котором проверяется прошла ли траектория через заданные точки
    /// </summary>
    public class Collision
    {
        /// <summary>
        /// Массив точек, через которые может пройти траетория
        /// </summary>
        public Point[] PointsCollision = { new Point(0.123m, 1.291387m), new Point(0, 15), new Point(3, 9), new Point(1.45m, 3.91m), new Point(2.789m, 6.578m) };
        /// <summary>
        /// Метод, в котором проверяется прошла ли траектория через какие-нибудь точки из массива заданных
        /// </summary>
        /// <param name="Points"></param>
        /// <param name="Okno"></param>
        public void ChechCollision(Point[] Points, Form1 Okno)
        {
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                for (int j = 0; j < PointsCollision.GetLength(0); j++)
                {
                    if (Points[i].x == PointsCollision[j].x && Points[i].y == PointsCollision[j].y)
                    {
                       Okno.textboxCollision.AppendText("\r\n(" + PointsCollision[j].x + "; " + PointsCollision[j].y + ")");
                    }
                    Okno.chart1.Series[3].Points.AddXY(PointsCollision[j].x, PointsCollision[j].y);
                }
            }
        }
    }
}