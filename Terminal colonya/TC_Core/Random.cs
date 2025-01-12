using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Terminal_colonya.TC_Core
{
    public class HOTRandom
    {
        public static void genererSeed(int seed)
        {
            seed = 0;
            seed = seed * DateAndTime.Now.Nanosecond;
            seed = seed * DateAndTime.Now.Year;
            seed = seed / DateAndTime.Now.Month;
            seed = seed / DateAndTime.Now.Second;
            seed = seed % DateAndTime.Now.Millisecond;
            seed = seed * DateAndTime.Now.Hour;
        }
    }
}
