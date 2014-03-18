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


    class Polygon : IDraw
    {
        public int[] x = new int[6]; //The array of points on the axis of abscissas
        int[] y = new int[6]; //The array of points on the vertical axis
        public void Draw()
        {
            for (int i = 1; i < 6; i++)
            {
                x[i] = x[i-1] + 10;
                y[i] = y[i-1] + 5;
                Console.Write("\nx = {0}", x[i]); //output points of the polygon
                Console.Write("\ny = {0}", y[i]); 
                Console.Write("\n------------------------------------"); //separation
            }
        }
    }


    class Triangle : Polygon
    {
        public int[] x = new int[4];
        public int[] y = new int[4];
        public void Draw()
        {
            for (int i = 1; i < 4; i++)
            {
                x[i] = x[i - 1] + 7;
                y[i] = y[i - 1] + 11;
                Console.Write("\nx = {0}", x[i]); //output points of the triangle
                Console.Write("\ny = {0}", y[i]); 
                Console.Write("\n------------------------------------"); //separation
            }
        }
    }



    class Text : IDraw
    {
        public int x; //point on the abscissa, in which the cursor is moved
        public int y = 33; //point on the ordinate axis in which the cursor is moved
        string text = "Give me life, give me love \nScarlet angel from above \nNot so low, not so high \nKeep it perfectly disguised";
        public void Draw() 
        {
            Console.SetCursorPosition(x, y); //move the cursor
            Console.Write("Text: \n{0}", text); //output a text
            Console.Write("\n------------------------------------"); //separation
        }
    }


    class DrawObjects
    {
        public static void Iniciallization() //Method for work with object
        {
            Triangle[] objectss = new Triangle[3]; //declaration of an array of 3 objects (triangles)
            objectss[0] = new Triangle {}; //initialize each object
            objectss[1] = new Triangle {};
            objectss[2] = new Triangle {};

            Console.WriteLine("Triangle1:");
            objectss[0].Draw();
            Console.WriteLine("\nTriangle2:");
            objectss[1].Draw();
            Console.WriteLine("\nTriangle3:");
            objectss[2].Draw();

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Text[] objecttext = new Text[2]; //declaration of an array of two objects (text)
            objecttext[0] = new Text {}; //initialize each object
            objecttext[1] = new Text {};

            objecttext[0].y = 80;
            objecttext[0].Draw(); 
            Console.WriteLine();
            Console.WriteLine();
            objecttext[1].y = 90;
            objecttext[1].Draw();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Polygon NewPolygon = new Polygon(); //call the constructor
            Console.WriteLine("Сoordinates of the points of the polygon:");
            NewPolygon.Draw(); //call a method
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Triangle NewTriangle = new Triangle();
            Console.WriteLine();
            Console.WriteLine("Сoordinates of the points of the triangle:");
            NewTriangle.Draw(); //call a method
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Text NewText = new Text();
            Console.WriteLine();
            NewText.Draw(); //call a method
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array of objects:");
            DrawObjects.Iniciallization(); //call a method
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
//Все объекты задавать в исходном коде (не меньше 3-х различных треугольников и двух текстов
