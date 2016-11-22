using System;

class ChristmasTreeExercise
{
    static void Main()
    {
        var christmasTreeSize = 
            int.Parse(Console.ReadLine());

        var christmasTreeHeight =
            christmasTreeSize + 1;

        for (var i = 0;
            i < christmasTreeHeight;
            i++)
        {
            Console.WriteLine("{0}{1} | {1}{0}",
                new string(' ', christmasTreeSize - i),
                new string('*', i));
        }
    }
}

