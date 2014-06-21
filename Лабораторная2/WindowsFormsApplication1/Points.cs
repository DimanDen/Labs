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
}
