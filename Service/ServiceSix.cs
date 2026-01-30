using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceSix
    {
     public string ReverseTheString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
              return "Input string is null or empty.";
            }
            else
            {
               string reversed = new string(input.Reverse().ToArray());
               return $"You entered:{input}. Reversed:{reversed} ";
            }
        }
    }
}