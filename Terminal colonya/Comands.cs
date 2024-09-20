using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_Colonya
{
    public class Comands
    {
        public string? Command { get; set; }
        public void ReadPlayerEnter()
        {
            Command = Console.ReadLine();
            Command?.Split(" ");
        }
        
        
        public object CheckCommandsEnter(string command)
        {
            if (Command != command)
            {
                return true;
            }
            else
            {
                return "This commands doesn't exist";
            }
        }
        // Principal class for all the Command if you want a create other commands 
        public class Commands
        {
            public string? Type { get; set; }
            public string? Name { get; set; }
            public string? Description { get; set; }
            
        }
    }
}
