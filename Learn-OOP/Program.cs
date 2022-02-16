using System;

namespace Learn_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            Console.WriteLine(newCar.calculateSpeed(20, 10));
        }
    }
}
