﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLogic;

namespace UseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PKApp RunningApp = new PKApp();
            RunningApp.TheApp();
        }
    }
}
