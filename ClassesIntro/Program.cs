using System;


namespace ClassesIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Car myCare = new Car();
            myCare.Accelerate();
            myCare.Accelerate();
            myCare.Accelerate();
            myCare.Accelerate();
            myCare.Accelerate();
            myCare.Brake();
            myCare.Accelerate();

        }
    }

    class Car
    {
        private int speed = 0;
        public void Accelerate()
        {
            speed++;
            Console.WriteLine($"You're going {speed} kilometers per hour.");
        }

        public void Brake()
        {
            speed--;
            Console.WriteLine($"You're going {speed} kilometers per hour.");
        }
    }
}
