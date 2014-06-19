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
        /// Вспомогательная переменная, с помощью который определяется метод создания точек
        /// </summary>
        public bool ParabolaOrStraight;
        /// <summary>
        /// Переменная, определяющая 
        /// </summary>
        bool CheckCollision = false;
        /// <summary>
        /// Коэффициенты, используемые в подсчете значения функции с помощью многочлена
        /// </summary>
        public decimal[] coefficients;
        /// <summary>
        /// Свободный член в формул подсчета значения функции синусойды
        /// </summary>
        public decimal SinusoidFreeTerm;
        public Point[] Points = { new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0), new Point(0, 0) };
        /// <summary>
        /// Точки, пересечение с которыми будет проверяться
        /// </summary>
        public Point[] PointsCollision = { new Point(-1, 2), new Point(-123, 1243) };

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
            if (ParabolaOrStraight == true)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    for (int j = 0; j < coefficients.Length; j++)
                    {
                        Points[i].x = x[i];
                        Points[i].y = Points[i].y + coefficients[j] * (decimal)Math.Pow((double)Points[i].x, j);
                    }
                }
            }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Points[i].x = x[i];
                    Points[i].y = (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
                }
            }
        }
        /// <summary>
        /// Метод, который позволяет получить точки
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public decimal[] GetPoints(decimal[] x)
        {
            return x;
        }
        /// <summary>
        /// Метод, в котором проверяется принадлежит ли точка траектории
        /// </summary>
        /// <param name="Points"></param>
        public void Collision(Point[] Points)
        {
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                for (int j = 0; j < PointsCollision.GetLength(0); j++)
                {
                    if (Points[i].x == PointsCollision[j].x && Points[i].y == PointsCollision[j].y)
                    {
                        CheckCollision = true;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Класс, представляющий траекторию в виде многочлена
    /// </summary>
    public class Polynomial : Trajectory
    {
        public override Point[] BuiltPoints(decimal[] x)
        {
            return Points;
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде параболы
    /// </summary>
    public class Parabola : Polynomial
    {
        public Parabola(decimal[] coefficients, bool ParabolaOrStraight)
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                this.ParabolaOrStraight = ParabolaOrStraight;
            }
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде прямой
    /// </summary>
    public class Straight : Polynomial
    {
        public Straight(decimal[] coefficients, bool ParabolaOrStraight)
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
                this.ParabolaOrStraight = ParabolaOrStraight;
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
            return Points;
        }
    }

    /// <summary>
    /// Класс, в котором траектория представлена в виде синусоды
    /// </summary>
    public class Sinusoid
        : TranscendentalCurves
    {
        public Sinusoid(decimal SinusoidFreeTerm, bool ParabolaOrStraight)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.ParabolaOrStraight = ParabolaOrStraight;
        }
    }
}