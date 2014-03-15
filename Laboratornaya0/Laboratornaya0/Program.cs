using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects1
{

    interface IMnogougolnik
    {
        void WriteCoordinatesOfTheCenterAndNumberOfAngles(int x, int y, int numberofangles); //Output Method coordinates of the center of the polygon and the number of angles
    }

    class Mnogougolnik : IMnogougolnik
    {
        public int numberofangles;  //variable indicating the number of angles of the polygon

        public int x, y;  //variables denoting the coordinates of the center of the polygon

        public void WriteCoordinatesOfTheCenterAndNumberOfAngles(int x, int y, int numberofangles)
        {
            Console.Write("x = {0} y = {1} angles = {2}\n", x, y, numberofangles); //Output coordinates and number of angles on the screen
        }
    }

    class Triangle : Mnogougolnik
    {
        public int Height; //variable indicating the height of the triangle 

        public void WriteCoordinatesOfTheCenterAndNumberOfAngles(int x, int y, int numberofangles)
        {
            Console.Write("x = {0} y = {1} angles = {2}\n", x, y, numberofangles);
        }

        public void WriteHeight(int Height) //method for deriving the height of the triangle on the screen
        {
            Console.Write("Height = {0}\n", Height);
        }
    }

    class Text
    {
        public int numberofwords, numberofstrings; //Variables indicating the number of words and strings in text

        public void Writecharacteristics(int numberofwords, int numberofstrings) //method for deriving the number of words and strings of text on the screen
        {
            Console.Write("numberofwords = {0} numberofstrings = {1}\n", numberofwords, numberofstrings);
        }
    }

    class PrintObjects
    {
        public static void Iniciallization()
        {
            Triangle[] objectss = new Triangle[3]; //declaration of an array of 3 objects (triangles)
            objectss[0] = new Triangle { x = 50, y = 7, Height = 2, numberofangles = 3 }; //initialize each object
            objectss[1] = new Triangle { x = 12, y = 3, Height = 4, numberofangles = 3 };
            objectss[2] = new Triangle { x = 23, y = 9, Height = 14, numberofangles = 3 };

            for (int i = 0; i < 3; i++) //output objects on the screen
            {
                Console.WriteLine("objecttriangle{0}: x = {1} y = {2} Height = {3} numberofangles = {4}\n", i, objectss[i].x, objectss[i].y, objectss[i].Height, objectss[i].numberofangles);
            }

            Text[] objecttext = new Text[2]; //declaration of an array of two objects (text)
            objecttext[0] = new Text { numberofwords = 50, numberofstrings = 5 }; //initialize each object
            objecttext[1] = new Text { numberofwords = 60, numberofstrings = 3 };

            for (int i = 0; i < 2; i++) //output objects on the screen
            {
                Console.WriteLine("objecttext{0}: numberofwords = {1} numberofstrings = {2}\n", i, objecttext[i].numberofwords, objecttext[i].numberofstrings);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Mnogougolnik NewMnogougolnik = new Mnogougolnik(); //call the constructor
            Console.WriteLine("Coordinates of the center and the number of corners of the polygon:");
            NewMnogougolnik.WriteCoordinatesOfTheCenterAndNumberOfAngles(12, 123, 5); //call a method with parameters
            Triangle NewTriangle = new Triangle();
            Console.WriteLine();
            Console.WriteLine("Coordinates of the center and the number of corners of the triangle:");
            NewTriangle.WriteCoordinatesOfTheCenterAndNumberOfAngles(15, 25, 3); //call a method with parameters
            Console.WriteLine("height of the triangle:");
            NewTriangle.WriteHeight(1); //call a method with parameters
            Text NewText = new Text();
            Console.WriteLine();
            Console.WriteLine("Number of words and strings in the text:");
            NewText.Writecharacteristics(10, 4); //call a method with parameters
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Array of objects:");
            PrintObjects.Iniciallization();
            Console.ReadKey();
        }
    }
}
//9.Создать класс для описания многоугольников в общем и треугольника в частности. 
//Также создать класс для описания текста. Все классы должны иметь метод вывода на экран. 
//Создать отдельный класс для операций над объектами. В классе должен быть метод вывода массива объектов на экран. 
//Все объекты задавать в исходном коде (не меньше 3-х различных треугольников и двух текстов