﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasit tasit = new Tasit();
            tasit.Kullan();

            Console.ReadKey();
        }
    }
}
