using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            //var listOfNumbers = new List<int>();

            //Random random = new Random();
            //for (var i = 0; i < 20; i++)
            //{
            //    var populateRandomNaumber = random.Next(1, 50);
            //   // Console.WriteLine(populateRandomNaumber);
            //    if (!listOfNumbers.Contains(populateRandomNaumber))
            //    {
            //        listOfNumbers.Add(populateRandomNaumber);
            //    }
            //    Console.WriteLine(listOfNumbers);
            //}

            var gerenrateNumbers = new Randomize();
            gerenrateNumbers.PopulateNumbers();

            Console.ReadLine();
        }
    }
}
