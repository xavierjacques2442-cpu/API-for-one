using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceThree
    {
public string AddTwoNumbers(int number1, int number2)
        {
             var sum = number1 + number2;
             return $"The sum of {number1} and {number2} is {sum}";
        }
    }
}