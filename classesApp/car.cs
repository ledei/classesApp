using System;

namespace classesApp
{
    internal class Car
    {
        private string _model = "";
        private string _brand = "";

        public string Model { get => _model; set => _model = value; }

        public string Brand
        {
            get => _brand; set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEAFULT";
                }
                else
                {
                    _brand = value;
                }
            }
        }

        //Constructor
        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine($"A {Brand} of the model {Model} has been created");
        }
    }
}