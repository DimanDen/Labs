using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде трансцендентных криых
    /// </summary>
    public class TranscendentalCurves : Trajectory
    {
        /// <summary>
        /// Свободный член в формул подсчета значения функции синусойды
        /// </summary>
        public decimal SinusoidFreeTerm;
        public override Point[] BuiltPoints(decimal[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < coefficients.Length; j++)
                {
                    Points[i].x = x[i];
                    Points[i].y = coefficients[j] * (decimal)Math.Sin((double)Points[i].x) + SinusoidFreeTerm;
                }
            }
            return Points;
        }
    }
}
