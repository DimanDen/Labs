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

    class SecondOrderCurve : Trajectory  //Кривая второго порядка, имеет вид: a{11}x^2 + a{22}y^2 + 2a{12}xy + 2a{13}x + 2a{23}y + a{33}=0,
    {
        protected double a11; //параметры для задания кривой второго порядка, они могут иметь разные значения, взависимости от функции
        protected double a22;
        protected double a12;
        protected double a13;
        protected double a23;
        protected double a33;

        public void Function() //В данном методе находим значения функции
        {
        }

        public void Terms() //Указываем условия для существования кривой второго порядка
        {
        }
    }


    class Parabola //Парабола
          : SecondOrderCurve
    {
        public void Terms() // В этом методе задаются условия определения функции. 
        {
        }
    }

    class straight  //Прямая
        : SecondOrderCurve
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

    class TranscendentalCurves : Trajectory  // рансцендентные кривые
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


