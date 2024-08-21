using DependencyInjectionWithNinject.Interface;
using DependencyInjectionWithNinject.Tasitlar;
using Ninject;
using System;

namespace DependencyInjectionWithNinject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ninject çekirdeği oluşturuluyor.
            IKernel kernel = new StandardKernel();

            //Ninject çekirdiğine ITasit bağlanıyor ve ITasit arayüzü kullanıldığında bunun Otobus nesnesi olduğu belirtiliyor.
            kernel.Bind<ITasit>().To<Otobus>();

            //Ninject çekirdeğinde Tasit nesnesinin örneği oluşturuluyor. 24.satırdaki kullanımın aynısı.
            Tasit tasit = kernel.Get<Tasit>();

            //25.satırdaki kullanımın aynısı.
            tasit.Kullan();

            //Tasit tasit = new Tasit(new Otomobil());
            //tasit.Kullan();

            Console.ReadKey();
        }
    }
}