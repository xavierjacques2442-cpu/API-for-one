using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceSeven
    {
     public string ReverseNumber(string input)
     {
           if(string.IsNullOrEmpty(input)) 
           return "Input is null or empty";

           if(!input.All(char.IsDigit))
           return "Error: Input contains non-numeric characters";

           string resversed = new string(input.Reverse().ToArray());
           return $"You entered {input} and the reversed number is {resversed}";
    }
    }
}