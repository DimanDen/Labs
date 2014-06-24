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
        /// <summary>
        /// Конструктор синусоиды
        /// </summary>
        /// <param name="SinusoidFreeTerm">Свободный член</param>
        /// <param name="x">Массив абсцисс</param>
        public Sinusoid(decimal SinusoidFreeTerm, decimal[] x)
            : base(SinusoidFreeTerm, x)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
        }
    }
}
