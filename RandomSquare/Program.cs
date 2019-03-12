using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenrateNumbers = new Randomize();
            gerenrateNumbers.PopulateNumbers();

            Console.ReadLine();
        }
    }
}
