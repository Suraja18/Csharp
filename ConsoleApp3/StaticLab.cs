using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class StopWatch
    {
        //Using Static will remember the old values
        public static int NoOfInstances = 0;
        //Creating Instance Constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }
}

