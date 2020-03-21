using System;
using System.Collections.Generic;

namespace RandomSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Create a list
            List<int> listOfNumbers = new List<int> { };

            // Populate the random numbers list
            for (int ctr = 0; ctr <= 19; ctr++)
                listOfNumbers.Add(random.Next(0, 51));

            // Create squared numbers list
            List<int> squaredNumbersList = new List<int> { };

            // Populate the squared numbers list
            foreach (var randomNumber in listOfNumbers)
            {
                squaredNumbersList.Add(randomNumber * randomNumber);
            }

            // Removing all odd numbers from the list
            squaredNumbersList.RemoveAll(i => i % 2 != 0);
        }
    }
}
