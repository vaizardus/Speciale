﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShannonPOC.ShannonLogger
{
    class ProgramExecuter
    {
        //Starts a program
        public static void executeProgram(string programPath)
        {
            Process.Start(programPath);
        }
    }
}
