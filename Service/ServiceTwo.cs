using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_for_one.Service
{
    public class ServiceTwo
    {
     public string ask_2_Questions(string name, string WakeUpTime)
        {
            return $"Hello I'm {name}, I woke up at {WakeUpTime} today!";
        }
    }
}