using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceFive
    {
    public string IsOdd(int number)
        {
            return number % 2 != 0
             ? $"{number} is odd"
             : $"{number} is even";
        }
    }
}