using System;
using System.Collections.Generic;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            Rectangle rectangle = new Rectangle(5, 4);
            Circle circle = new Circle(4.5);
            Triangle triangle = new Triangle(6,5);

            Dog dog = new Dog();
            Rabbit rabbit = new Rabbit();
            Whale whale = new Whale();

            Console.WriteLine("What do animals eat?");
            Console.WriteLine("");
            Console.WriteLine(dog.Eat());
            Console.WriteLine("");
            Console.WriteLine(rabbit.Eat());
            Console.WriteLine("");
            Console.WriteLine(whale.Eat());

            Console.WriteLine("");
            Console.WriteLine("What are the areas of shapes?");
            Console.WriteLine("");
            Console.WriteLine(circle.Area());
            Console.WriteLine("");
            Console.WriteLine(rectangle.Area());
            Console.WriteLine("");
            Console.WriteLine(triangle.Area());
        }
    }
}
