using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.NumberTable
{
    class NumberTableExercise
    {
        static void Main(string[] args)
        {
            var tableSize = int.Parse(
                 Console.ReadLine());

            for (var tableRow = 1;
                tableRow <= tableSize;
                tableRow++)
            {
                var numberToPrint = tableRow;
                var isMaxNumberPrinted = false;
                for (var tableColumn = 1;
                    tableColumn <= tableSize;
                    tableColumn++)
                {
                    Console.Write("{0} ", numberToPrint);
                    if (numberToPrint == tableSize)
                    {
                        isMaxNumberPrinted = true;
                    }
                    if (isMaxNumberPrinted)
                    {
                        numberToPrint--;
                    }
                    else
                    {
                        numberToPrint++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
