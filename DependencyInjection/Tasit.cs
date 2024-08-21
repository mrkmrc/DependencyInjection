using DependencyInjectionWithConstructor.Interface;
using DependencyInjectionWithConstructor.Tasitlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithConstructor
{
    public class Tasit
    {
        ITasit _tasit;

        public Tasit(ITasit tasit)
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
