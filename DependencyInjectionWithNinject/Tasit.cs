using DependencyInjectionWithNinject.Interface;
using Ninject;

namespace DependencyInjectionWithNinject
{
    public class Tasit
    {
        ITasit _tasit;

        [Inject]
        public void TasitAl(ITasit tasit)
        {
            _tasit = tasit;
        }

        public void Kullan()
        {
            _tasit.GazVer();
            _tasit.FrenYap();
        }
    }
}
