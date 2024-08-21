using DependencyInjectionWithProperty.Tasitlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasit tasit = new Tasit();
            tasit._tasit = new Otomobil();
            tasit.Kullan();

            Console.ReadKey();
        }
    }
}
