using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook yarik = new Cook("Yarik");

            yarik.MakeDinner(new SaladMeal());
            Console.WriteLine();
            yarik.MakeDinner(new PotatoMeal());

        }
    }
}
