using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
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
}
