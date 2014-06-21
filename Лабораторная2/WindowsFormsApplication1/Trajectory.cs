using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
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
        public bool Collision(Point testPoint)
        {
            return BuiltPoints(new decimal[] { testPoint.x })[0].y == testPoint.y;
        }
    }
}
