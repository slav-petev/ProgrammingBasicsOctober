using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersEndingInSeven
{
    class NumbersEndingInSevenExercise
    {
        static void Main(string[] args)
        {
            /*
                We want to print only the
                numbers between 1 and 1000
                that end in 7. The first such
                number is 7. We get every next
                such number when we add 10 to the
                preceeding number. 
            */
            for (var i = 7;
                i <= 1000;
                i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
