using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Класс, в котором траектория представлена в виде прямой
    /// </summary>
    public class Straight : Polynomial
    {
        public Straight(decimal[] coefficients)
        {
            if (coefficients.Length == 2)
            {
                this.coefficients = coefficients;
            }
        }
    }
}
