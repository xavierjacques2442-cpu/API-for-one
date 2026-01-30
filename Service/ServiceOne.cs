using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceOne
    {
       public string SayHello(string name)
        {
            return $"hello,{name}!";
        }
    }
}