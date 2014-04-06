using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{
    interface IDraw
    {
        void Draw(); //method to display the objects
    }


    class Point
    {
        public int x; //coordinates of points
        public int y;
        public Point(int x, int y) //constructor with a pointer to the object
        {
            this.x = x;
            this.y = y;
        }
    }


    class Polygon : IDraw
    {
        protected Point[] Points; //array of points
        protected int heaps; //the number of vertices
        public int Heaps //properties, which specifies the conditions the number of vertices
        {
            get
            {
                heaps = Points.Length;
                return heaps; 
            }
            set
            {   }
        }

        protected Polygon()
        {
        }

        public Polygon(Point[] Points) //constructor with a pointer to the object
        {
            this.Points = Points;
        }
        
        public void Draw() //method which output points to the screen
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Console.WriteLine("x = {0}; y = {1}", Points[i].x, Points[i].y);
            }
        }
    }


    class Triangle : Polygon
    {
        public Triangle(Point[] Points)
        {
            if (Points != null && Points.Length == 3) //Condition for the vertices of the triangle
            {
                this.Points = Points;
            }
        }
    }



    class Text : IDraw
    {
        protected Point Point1;
        private String text;
        public Text(Point Point1, String text)
        {
            this.Point1 = Point1;
            this.text = text;
        }

        public void Draw()
        {
            Console.SetCursorPosition(Point1.x, 0); //move the cursor to this coordinates
            Console.Write("Text: \n{0}", text); //output a text
        }
    }


    class DrawObjects
    {         
        public static void Iniciallization(ref Polygon[] arrayofobjects) //Method for work with object
        {
            for (int i = 0; i < arrayofobjects.Length; i++)
            {             
                arrayofobjects[i].Draw();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static Point[] Points1 = { new Point(11, 22), new Point(33, 44), new Point(55, 66) }; //Initialize an array of points
        static Point[] Points = { new Point(1, 2), new Point(3, 4), new Point(5, 6), new Point(7, 8), new Point(9, 10) };
        static Point Point1 = new Point(10,0);

        static void Main()
        {
            Polygon[] arrayofobjects = { new Polygon(Points), new Triangle(Points1)};//, new Text(Point1, "Give me life, give me love \nScarlet angel from above \nNot so low, not so high \nKeep it perfectly disguised") };

            Console.WriteLine("Вывод в методе мэйн");
            foreach (Polygon p in arrayofobjects)
            {
                p.Draw();
                Console.WriteLine();
            }

            Console.WriteLine("Через метод вывода массива на экран");
            DrawObjects.Iniciallization(ref arrayofobjects);
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
//Все объекты задавать в исходном коде
