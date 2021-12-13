using System;
using System.Collections.Generic;
using System.Linq;

namespace TimeCode
{
    public class Program
    {
        private const string Format = "Your account balance is {0:C2} {1:C2} {0:C2}.";

        static void Main()
        {
            var item = new SaleItem("Shoes", 19.95m);
            Console.WriteLine($"{item.Name}: sells for {item.Price:C2}");

            decimal t = 432.321m;
            decimal value = 123.456m;
            Console.WriteLine(Format, value, t);
        }
    }
}
