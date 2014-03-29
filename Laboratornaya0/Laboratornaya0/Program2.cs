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
                return heaps; 
            }
            set
            {
                if (value < 3)
                {
                    heaps = 3;
                }
                else
                {
                    heaps = value;
                }
            }
        }
        public Polygon(Point[] Points) //constructor with a pointer to the object
        {
            this.Points = Points;
        }
        public void Draw() //method which output points to the screen
        {
            for (int i = 0; i < heaps; i++)
            {
                Console.WriteLine("x = {0}; y = {1}", Points[i].x, Points[i].y);
            }
        }
    }


    class Triangle : Polygon
    {
        public Triangle(Point[] Points)
            : base(Points) 
        {
            if (Points != null && Points.Length == 3) //Condition for the vertices of the triangle
            {
                this.Points = Points;
            }
        }

        public void Draw() //method which output points to the screen
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("x = {0}; y = {1}", Points[i].x, Points[i].y);
            }
        }
    }



    class Text : IDraw
    {
        protected Point[] Points;
        private String text = "Give me life, give me love \nScarlet angel from above \nNot so low, not so high \nKeep it perfectly disguised";
        public Text(Point[] Points)
        {
            this.Points = Points;
        }
        public void Draw()
        {
            Console.SetCursorPosition(Points[0].x, Points[0].y); //move the cursor to this coordinates
            Console.Write("Text: \n{0}", text); //output a text
        }
    }


    class DrawObjects
    {
        static protected Point[] Points1 = { new Point(11, 22), new Point(33, 44), new Point(55, 66) }; //Initialize an array of points
        static protected Point[] Points2 = { new Point(77, 88), new Point(99, 100), new Point(111, 222) }; //Initialize an array of points
        static protected Point[] Pointstext = { new Point(0, 18) }; //Initialize an array of points
        public static void Iniciallization() //Method for work with object
        {
            Polygon[] polygons = new Polygon[] { new Triangle(Points1), new Triangle(Points2) };
            foreach (Triangle p in polygons)
            {
                p.Draw();
                Console.WriteLine();
            }
            Text[] text = new Text[] {new Text(Pointstext)};
            foreach (Text t in text)
            {
                t.Draw();
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static protected Point[] Points = { new Point(1, 2), new Point(3, 4), new Point(5, 6), new Point(7, 8), new Point(9, 10) };
        static void Main(string[] args)
        {
            Polygon pol = new Polygon(Points);
            pol.Heaps = 5;
            Console.WriteLine("Polygon");
            pol.Draw();

            Console.WriteLine();
            Console.WriteLine("Triangle 1, Triangle 2 and Text");
            DrawObjects.Iniciallization();
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
//Все объекты задавать в исходном коде
