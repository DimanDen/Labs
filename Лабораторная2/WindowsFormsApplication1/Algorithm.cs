using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, содержащий в себе точки в виде: (координата по оси абсцисс; координата по оси ординат)
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Координата по оси абсцисс
        /// </summary>
        public decimal x;
        /// <summary>
        /// координата по оси ординат
        /// </summary>
        public decimal y;
        public Point(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        /// <summary>
        /// Метод, задающий необходимый формат точек
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "(" + x + "; " + y + ")";
        }
    }

    /// <summary>
    /// Класс, описывающий траекторию
    /// </summary>
    public abstract class Trajectory
    {
        /// <summary>
        /// Коэффициенты, используемые в подсчете значения функции с помощью многочлена
        /// </summary>
        public decimal[] coefficients;
        /// <summary>
        /// Свободный член в формул подсчета значения функции синусойды
        /// </summary>
        public decimal SinusoidFreeTerm;
        public Point[] Points;
        /// <summary>
        /// Метод построения точек
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public abstract Point[] BuiltPoints(decimal[] x);
        /// <summary>
        /// Метод в котором высчитывается значение функции для траектории в виде многочлена и в виде синусойды
        /// </summary>
        /// <param name="x"></param>
        public void CreatePoints(decimal[] x)
        {
            Points = BuiltPoints(x);
        }
        /// <summary>
        /// Метод, который позволяет получить точки
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Point[] GetPoints(decimal[] x)
        {
            return BuiltPoints(x);
        }
        /// <summary>
        /// Метод, в котором проверяется принадлежит ли точка траектории
        /// </summary>
        /// <param name="Points"></param>
        public decimal Collision(Point testPoint)
        {
            return BuiltPoints(new decimal[] {testPoint.x})[0].y;// == testPoint.y;
        }
    }

    /// <summary>
    /// Класс, представляющий траекторию в виде многочлена
    /// </summary>
    public class Polynomial : Trajectory
    {
        public override Point[] BuiltPoints(decimal[] x)
        {
            for (int i = 0; i < x.Length; i++)
                {
                    for (int j = 0; j < coefficients.Length; j++)
                    {
                        Points[i].x = x[i];
                        Points[i].y = Points[i].y + coefficients[j] * (decimal)Math.Pow((double)Points[i].x, j);
                    }
                }
            return Points;
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде параболы
    /// </summary>
    public class Parabola : Polynomial
    {
        public Parabola(decimal[] coefficients, Point[] Points)
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                this.Points = Points;
            }
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде прямой
    /// </summary>
    public class Straight : Polynomial
    {
        public Straight(decimal[] coefficients, Point[] Points)
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
                this.Points = Points;
            }
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде трансцендентных криых
    /// </summary>
    public class TranscendentalCurves : Trajectory
    {
        public override Point[] BuiltPoints(decimal[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Points[i].x = x[i];
                Points[i].y = (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
            }
            return Points;
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде синусоды
    /// </summary>
    public class Sinusoid
        : TranscendentalCurves
    {
        public Sinusoid(decimal SinusoidFreeTerm, Point[] Points)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.Points = Points;
        }
    }
}