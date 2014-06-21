using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
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
