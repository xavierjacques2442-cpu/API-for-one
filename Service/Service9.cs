using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Services
{
    public class service9
    {
     private readonly Random _random = new Random();

        public string Guess(int userNumber, int maxNumber)
        {
            int generatedNumber = _random.Next(1, maxNumber + 1);
            if (userNumber == generatedNumber)
            {
                return $"Congratulations! You guessed the correct number: {generatedNumber}.";
            }
            else
            {
                return $"Sorry, the correct number was {generatedNumber}. Better luck next time!";
            }
        }
    }
}