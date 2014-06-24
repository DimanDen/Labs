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
        /// Конструктор синусоиды. В виде параметра поступает свободная компонента
        /// </summary>
        /// <param name="SinusoidFreeTerm"></param>
        public Sinusoid(decimal SinusoidFreeTerm)
        {
            this.SinusoidFreeTerm = SinusoidFreeTerm;
        }
    }
}
