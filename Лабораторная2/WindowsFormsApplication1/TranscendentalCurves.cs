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
        /// Метод построения точек, специализированный трансцендентные кривые
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
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
}
