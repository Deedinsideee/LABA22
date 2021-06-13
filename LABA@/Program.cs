using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{   
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Введите доллары");
            x = Convert.ToInt32(Console.ReadLine());

            Currency val = new Dollar(x);
            val.InEuros(); 
            val.InRubles();
            val.Print();

            Console.WriteLine("Введите евро");
            x = Convert.ToInt32(Console.ReadLine());

            val = new Euro(x);
            val.InRubles();
            val.InDollars();
            val.Print();
        }
    }
}
