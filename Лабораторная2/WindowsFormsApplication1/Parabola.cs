using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде параболы
    /// </summary>
    public class Parabola : Polynomial
    {
        public Parabola(decimal[] coefficients)
        {
            if (coefficients.Length == 3)
            {
                this.coefficients = coefficients;
                
            }
        }
    }
}
