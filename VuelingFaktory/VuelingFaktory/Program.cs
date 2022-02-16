using System;
using System.Collections.Generic;
using VuelingFaktory.Domain;

namespace VuelingFaktory
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            OrderService orderService = new OrderService();

            Console.WriteLine(orderService.GetOrder().Order);

            Console.ReadLine();
        }
    }
}
