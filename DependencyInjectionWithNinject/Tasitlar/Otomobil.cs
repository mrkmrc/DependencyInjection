using DependencyInjectionWithNinject.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithNinject.Tasitlar
{
    public class Otomobil : ITasit
    {
        public void FrenYap()
        {
            Console.WriteLine("Otomobil Fren Yapıldı."); ;
        }

        public void GazVer()
        {
            Console.WriteLine("Otomobil Gaz verildi.");
        }
    }
}
