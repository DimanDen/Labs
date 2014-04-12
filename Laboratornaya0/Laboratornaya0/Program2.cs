using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{
<<<<<<< HEAD

=======
>>>>>>> parent of a73e55a... 1
    interface IDraw
    {
        void Draw(); //method to display the objects
    }


<<<<<<< HEAD
    class Points
    {
        public int b = 0; //auxiliary variables to create three different triangles
        public int c = 0; //auxiliary variables to create three different triangles
        public static int a;
        public int[] x = new int[a]; //the array of points on the axis of abscissas
        public int[] y = new int[a]; //the array of points on the vertical axis
        public void Create() //method for create points
        {

          for (int i = 1; i < a; i++)
            {
                x[i] = x[i - 1] + 10; 
                y[i] = y[i - 1] + 5;
            }
=======
    class Point
    {
        public int x; //coordinates of points
        public int y;
        public Point(int x, int y) //constructor with a pointer to the object
        {
            this.x = x;
            this.y = y;
>>>>>>> parent of a73e55a... 1
        }
    }


<<<<<<< HEAD
    class Polygon : Points, IDraw
    {

        public void Draw() 
        {
            a = int.Parse(Console.ReadLine()) + 1; //auxiliary variables for determining the number of points
            Points point = new Points();
            point.Create(); //call a method for creare points
            for (int i = 1; i < a; i++)
            {
                Console.Write("\nx = {0}", point.x[i] + b); //output points of the polygon
                Console.Write("\ny = {0}", point.y[i] + c); 
                Console.Write("\n------------------------------------"); //separation
=======
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
>>>>>>> parent of a73e55a... 1
            }
        }
    }


    class Triangle : Polygon
    {
<<<<<<< HEAD

        public void Draw()
        {
            Points point = new Points();
            point.Create();  //create a points
            for (int i = 1; i < 4; i++)
            {
                Console.Write("\nx = {0}", point.x[i] + 11 + b); //output points of the triangle
                Console.Write("\ny = {0}", point.y[i] + 23 + c); 
                Console.Write("\n------------------------------------"); //separation
=======
        public Triangle(Point[] Points)
        {
            if (Points != null && Points.Length == 3) //Condition for the vertices of the triangle
            {
                this.Points = Points;
>>>>>>> parent of a73e55a... 1
            }
        }
    }



    class Text : IDraw
    {
<<<<<<< HEAD
        public int x; //point on the abscissa, in which the cursor is moved
        public int y = 33; //point on the ordinate axis in which the cursor is moved
        string text = "Give me life, give me love \nScarlet angel from above \nNot so low, not so high \nKeep it perfectly disguised";
        public void Draw() 
        {
            Console.SetCursorPosition(x, y); //move the cursor
            Console.Write("Text: \n{0}", text); //output a text
            Console.Write("\n------------------------------------"); //separation
=======
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
>>>>>>> parent of a73e55a... 1
        }
    }


    class DrawObjects
<<<<<<< HEAD
    {
        public static void Iniciallization() //Method for work with object
        {
            Triangle[] objectss = new Triangle[3]; //declaration of an array of 3 objects (triangles)

            Console.WriteLine("Triangle1:");
            objectss[0] = new Triangle { };  //initialize object
            objectss[0].b = 27;
            objectss[0].c = 12;
            objectss[0].Draw(); //call a method

            Console.WriteLine("\nTriangle2:");
            objectss[1] = new Triangle { };
            objectss[1].b = 47;
            objectss[1].c = 19;
            objectss[1].Draw(); //call a method

            Console.WriteLine("\nTriangle3:");
            objectss[2] = new Triangle { };
            objectss[2].b = 3;
            objectss[2].c = 9;
            objectss[2].Draw(); //call a method

            Console.ReadKey();
            Console.WriteLine("\n");

            Text[] objecttext = new Text[2]; //declaration of an array of two objects (text)

            objecttext[0] = new Text { }; //initialize object
            objecttext[0].y = 80; //determine the position of the cursor
            objecttext[0].Draw(); //call a method

            Console.WriteLine("\n");

            objecttext[1] = new Text { };
            objecttext[1].y = 90; //determine the position of the cursor
            objecttext[1].Draw(); //call a method
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Polygon NewPolygon = new Polygon(); //call the constructor
            Console.WriteLine("Сoordinates of the points of the polygon:");
            Console.WriteLine("Please, enter a number of points:");
            NewPolygon.Draw(); //call a method

            Console.WriteLine("\n");
            Console.ReadKey();

            Triangle NewTriangle = new Triangle();
            Console.WriteLine("\nСoordinates of the points of the triangle:");
            NewTriangle.Draw(); //call a method

            Console.WriteLine("\n");
            Console.ReadKey();

            Text NewText = new Text();
            Console.WriteLine();
            NewText.Draw(); //call a method

            Console.ReadKey();
            Console.WriteLine("\n\n\nArray of objects:");

            DrawObjects.Iniciallization(); //call a method
=======
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
>>>>>>> parent of a73e55a... 1
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
<<<<<<< HEAD
//Все объекты задавать в исходном коде (не меньше 3-х различных треугольников и двух текстов
=======
//Все объекты задавать в исходном коде
>>>>>>> parent of a73e55a... 1
