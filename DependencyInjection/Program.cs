using DependencyInjectionWithConstructor.Tasitlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasit tasit = new Tasit(new Otomobil());
            tasit.Kullan();

            Console.ReadKey();
        }
    }
}
