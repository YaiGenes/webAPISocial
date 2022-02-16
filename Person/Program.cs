using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal pp = new Animal();
            pp.Name = "guajiro";
            Console.WriteLine(pp.Name);
            pp.Age(12);
            Console.WriteLine(pp.Delegate());
            Console.WriteLine(pp.Anoying());
            var flag = pp.Scream = false;
            Console.WriteLine(flag);
        }
    }
}
