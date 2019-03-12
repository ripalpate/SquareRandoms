using System;
using System.Collections.Generic;
using System.Text;

namespace RandomSquare
{
    class Randomize
    {
        public List<int> ListOfNumbers = new List<int> () ;
        public List<int> squareNumbers = new List<int>();
        public void PopulateNumbers()
        {
            var randomNumbersString = "";
            var squareNumbersString = "";
            var ListofEvenNumbers = "";

            Random random = new Random();
            for (var i = 0; i < 20; i++)
            {
                var populateRandomNaumber = random.Next(1, 50);
               
                     ListOfNumbers.Add(populateRandomNaumber);
                 
            }

            foreach (var number in ListOfNumbers)
            {
                 randomNumbersString += number + ",";
            }

            foreach (var number in ListOfNumbers)
            {
                var square = number * number;
                squareNumbers.Add(square);
                squareNumbersString += square + ",";
            }

            foreach (var squareNumber in squareNumbers)
            {
                if (squareNumber % 2 == 0)
                {
                    ListofEvenNumbers += squareNumber + ",";
                }
            }

            Console.WriteLine($"List of Random numbers: {randomNumbersString.TrimEnd(',')}");
            Console.WriteLine($"List of Square numbers: {squareNumbersString.TrimEnd(',')}");
            Console.WriteLine($"List of Even Square Numbers: {ListofEvenNumbers.TrimEnd(',')}");
        }
    }
}
