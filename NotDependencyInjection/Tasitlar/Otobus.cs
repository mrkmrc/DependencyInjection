using System;

namespace NotDependencyInjection.Tasitlar
{
    public class Otobus
    {
        public void GazVer()
        {
            Console.WriteLine("Otobüs gaz verildi.");
        }

        public void FrenYap()
        {
            Console.WriteLine("Otobüs fren yapıldı.");
        }
    }
}
