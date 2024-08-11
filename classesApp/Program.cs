using System;

namespace classesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A3", "audi");
            audi.Brand = Console.ReadLine();

            Console.WriteLine(audi.Brand);
        }
    }
}