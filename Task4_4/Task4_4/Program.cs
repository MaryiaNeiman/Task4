using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cart cl = new Cart();
            IContinentFactory product1 = new Type1();
            var concProduct1 = product1.CreateProductA(1, "Asus computer" , 200, "black");
            cl.Add(concProduct1);

            IContinentFactory product3 = new Type1();
            var concProduct3 = product3.CreateProductB(3, "Asus phone", 400, "white");
            cl.Add(concProduct3);

            IContinentFactory product2 = new Type2();
            var concProduct2 = product2.CreateProductA(2, "Acer computer", 300, "black");
            cl.Add(concProduct2);

            cl.Delete(concProduct1);

            Console.WriteLine($"Common cost = {cl.Count()}");


            Console.ReadKey();
        }
    }
}
