using System;

namespace LabExercise6
{
    class Car
    {
        private string make;
        private string model;
        private string colour;
        private string registrationNumber;

        public Car(string make, string model, string colour, string registrationNumber)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.registrationNumber = registrationNumber;
        }

        // read-only property
        public string RegistrationNumber
        {
            get { return registrationNumber; }
        }

        public string Make
        {
            get { return make; }
            set
            {
                // only change make if there is a value
                if (!string.IsNullOrWhiteSpace(value))
                {
                    make = value;
                }
            }
        }

        public string GetCarInfo()
        {
            return "Make: " + make + ", Model: " + model +
                   ", Colour: " + colour + ", Registration: " + registrationNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", "Red", "ABC123");
            Console.WriteLine(myCar.GetCarInfo());

            myCar.Make = "";
            Console.WriteLine(myCar.GetCarInfo());

            Console.ReadLine();
        }
    }
}