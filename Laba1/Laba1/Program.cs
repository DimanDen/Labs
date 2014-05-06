using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trajectory
{
    interface IFunction //Метод определения значения функции
    {
        void Function();
    }

    interface ITerms //Условия определения функции и существования функции
    {
        void Terms();
    }

    public class Trajectory : IFunction, ITerms // Траектория
    {
        static public double x; //координаты точек функции
        static public double y;
        public void Function()
        { 
        }
        public void Terms()
        { 
        }
    }

    class Polynomial : Trajectory  //Многочлен n-ого порядка. Имеет вид c0 + c1*x + c2*(x^2) + ...
    {
        protected double[] coefficients; //В массиве содержатся коэффициенты для определение многочлена той или иной степени
        //В данном методе определяется уравнение для нахождения значений фукнции. 
        //Например: если в массиве коэффициентов будет три элемента, значит степень многочлена будет второй. 
        //Следовательно мы имеем дело с параболой
        public void Function() 
        {
        }

        public void Terms() //Указываем условия для существования того или иного многочлена. Например: Коэффициенты должны быть действительными числами.
        {
        }
    }


    class Parabola //Парабола
          : Polynomial
    {
        public void Terms() // В этом методе задаются условия определения функции. 
        {
        }
    }

    class straight  //Прямая
        : Polynomial
    {
        public void Terms() // В этом методе задаются условия определения функции. 
        {
        }
    }

    class Сollision //Столкновение
    {
        public int x; //Координаты точек, где находятся посторенние объекты (препятствия)
        public int y;
    }

    class TranscendentalCurves : Trajectory  // Трансцендентные кривые
    {
        protected double b; // свободный член для синусоиды

        public void Function() //В данном методе находим значения функции
        { 
        }

        public void Terms() //Указываем условия
        { 
        }
    }

    class Sinusoid //Синусоида
        : TranscendentalCurves
    {
        public void Function() //Функция синусоиды
        { 
        }
    }


    class Program
    {
        static void Main()
        {
        }
    }
}


