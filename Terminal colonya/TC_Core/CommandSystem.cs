using HOTTUI;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_colonya.TC_Core
{
    public class Commands
    {
        public string[] CommandInput { get; set; }

        public Commands(string[] input)
        {
            CommandInput = input;
        }

        public void Command(List<Colon> colons)
        {
            switch (CommandInput[0])
            {
                case "Zone":
                    switch (CommandInput[1])
                    {

                    }
                    break;
                case "Build":
                    switch (CommandInput[1])
                    {

                    }
                    break;
                case "Colon":
                    switch (CommandInput[1])
                    {
                        // a finir
                        case "list":
                            foreach (var colon in colons)
                            {
                                Tools.Horizontal_Line(15, ConsoleColor.White, '-');
                                Tools.Whrite.Color_Write(ConsoleColor.White, $"\n| Name : {colon.Name}\n");
                                Tools.Whrite.Color_Write(ConsoleColor.White, $"| Gender : {colon.Sexe}\n");
                                Tools.Whrite.Color_Write(ConsoleColor.White, $"| Age : {colon.Age} \n");
                                Tools.Horizontal_Line(15, ConsoleColor.White, '-');
                                Tools.Whrite.Color_Write(ConsoleColor.White, "\n");
                            }
                            break;
                    }
                    break;
            }
        }


    }
}
