using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде трансцендентные кривые
    /// </summary>
    public class TranscendentalCurves : Trajectory
    {
        /// <summary>
        /// Базовый конструктор для синусойды
        /// </summary>
        /// <param name="SinusoidFreeTerm">Свободный член синусойды</param>
        /// <param name="x">Массив абсцисс</param>
        public TranscendentalCurves(decimal SinusoidFreeTerm, decimal[] x)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
            this.Points = this.BuiltPoints(x);
        }

        /// <summary>
        /// Метод построения точек, специализированный трансцендентные кривые
        /// </summary>
        /// <param name="x">Массив абсцисс</param>
        /// <returns></returns>
        public override Point[] BuiltPoints(decimal[] x)
        {
            Points = new Point[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                Points[i] = new Point(x[i], 0);
                Points[i].y = (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
            }
            return Points;
        }
    }
}
