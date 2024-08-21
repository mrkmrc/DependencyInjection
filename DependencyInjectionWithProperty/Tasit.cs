using DependencyInjectionWithProperty.Interface;
using DependencyInjectionWithProperty.Tasitlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithProperty
{
    public class Tasit
    {
        public ITasit _tasit { get; set; }

        public Tasit()
        {
        }

        public void Kullan()
        {
            _tasit.GazVer();
            _tasit.FrenYap();
        }
    }
}
