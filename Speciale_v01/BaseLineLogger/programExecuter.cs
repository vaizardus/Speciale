﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLineLogger
{
    class programExecuter
    {
        //Starts a program
        public static void executeProgram(string programPath)
        {
            Process.Start(programPath);
        }
    }
}
