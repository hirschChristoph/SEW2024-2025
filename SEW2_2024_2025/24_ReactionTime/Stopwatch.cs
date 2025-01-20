using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _26_Zufallszahlraten
namespace _24_ReactionTime
{
    internal class Stopwatch
    {
        private DateTime start;

        public Stopwatch() 
        { 
            start = DateTime.Now;
        }

        public TimeSpan Elapsed()
        {
            return DateTime.Now - start;
        }

        public void Reset()
        {
            start = DateTime.Now;
        }


    }
}
