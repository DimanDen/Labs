using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{

    interface IPolygon
    {
        void Draw(int x1, int x2, int x3, int x4, int x5, int xcenter, int ycenter, string str1); //method for output points of the polygon and the coordinates of its center (the number of points here to change). If x4 and x5 is zero, then we have a triangle
    }


    class Polygon : IPolygon
    {
        public void Draw(int x1, int x2, int x3, int x4, int x5, int xcenter, int ycenter, string str1)
        {
            {
                Console.Write("\nx1 = {0} \nx2 = {1} \nx3 = {2} \nx4 = {3} \nx5 = {4}\n", x1, x2, x3, x4, x5); //output points of the polygon
                Console.Write("\ncenter of the polygon ({0};{1})", xcenter, ycenter); //output coordinates of the center
                Console.Write("\n------------------------------------"); //separation
            }
        }
    }


    class Triangle : Polygon
    {
        public void Draw(int xcenter, int ycenter)
        {
            Console.Write("center of the triangle ({0};{1})", xcenter, ycenter); //output coordinates of the center
            Console.Write("\n------------------------------------"); //separation
        }
    }


    class Text
    {
        public void Draw(string str1) 
        {
            Console.Write("\nstring1 = {0}", str1); //output a string of text
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

            objectss[0].Draw(11, 22, 33, 0, 0, 17, 17, ""); //Set parameters
            objectss[1].Draw(1, 2, 9, 0, 0, 6, 7, ""); 
            objectss[2].Draw(48, 92, 103, 0, 0, 56, 67, "");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();

            Text[] objecttext = new Text[2]; //declaration of an array of two objects (text)
            objecttext[0] = new Text {}; //initialize each object
            objecttext[1] = new Text {};

            objecttext[0].Draw("Текст - зафиксированная на каком-либо материальном носителе человеческаямысль."); //Set parameters
            Console.WriteLine();
            Console.WriteLine();
            objecttext[1].Draw("Let's make a SuperScientific test!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Polygon NewPolygon = new Polygon(); //call the constructor
            Console.WriteLine("Сoordinates of the points of the polygon:");
            NewPolygon.Draw(12, 123, 123, 23, 56, 5, 5, ""); //call a method with parameters
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Triangle NewTriangle = new Triangle();
            Console.WriteLine();
            Console.WriteLine("Сoordinates of the points of the triangle:");
            NewTriangle.Draw(15, 25, 2, 0, 0, 7, 7, ""); //call a method with parameters
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Text NewText = new Text();
            Console.WriteLine();
            Console.WriteLine("Information about text:\n");
            NewText.Draw("Say it once, tell me twice, are you certain I'm alright?"); //call a method with parameters
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Array of objects:");
            DrawObjects.Iniciallization();
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
//Все объекты задавать в исходном коде (не меньше 3-х различных треугольников и двух текстов
