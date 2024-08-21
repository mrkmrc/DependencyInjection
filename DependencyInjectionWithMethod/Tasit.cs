using DependencyInjectionWithMethod.Interface;
using DependencyInjectionWithMethod.Tasitlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithMethod
{
    public class Tasit
    {
        public Tasit()
        {
        }

        public void Kullan(ITasit tasit)
        {
            tasit.GazVer();
            tasit.FrenYap();
        }
    }
}
