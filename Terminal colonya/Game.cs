using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terminal_colonya.TC_Core;
using Hystory_Open_Technologie_Terminal_User_Interface;
using System.Drawing;
using System.Reflection;



// Terminal Colonya is a Open-Source Colony game 
// Terminal Colonya is a H.O.T (Hystory-Open-Technologie)
// Terminal Colonya was created by Kotama_chio 

namespace Game
{
    
    internal class Game
    {
        
        static void Main(string[] args)
        {
            string? playerenter;
            int width = 1080, height = 1920;
            var ColorLine = Hystory_Open_Technologie_Terminal_User_Interface.UI.Color_Whrite_line;
            Console.SetWindowSize(width, height);
            Console.Title = "Terminal Colonya";
            

            ColorLine(ConsoleColor.Red, "--Welcome ");
            ColorLine(ConsoleColor.DarkYellow, "to ");
            ColorLine(ConsoleColor.Yellow, "Terminal ");
            ColorLine(ConsoleColor.Green, "Colonya--\n");
            ColorLine(ConsoleColor.DarkBlue, "  --Created ");
            ColorLine(ConsoleColor.Magenta, "by ");
            ColorLine(ConsoleColor.White, "Kotama");
            ColorLine(ConsoleColor.Blue, "_Chio--\n");
            
            
            
            



            while (true)
            {
                
                ColorLine(ConsoleColor.Yellow, "§ ");
                ColorLine(ConsoleColor.White, "T");
                ColorLine(ConsoleColor.Magenta,"C ");
                Console.BackgroundColor = ConsoleColor.White;
                ColorLine(ConsoleColor.Black, ": ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                playerenter = Console.ReadLine();
                Comands.Command_Game(playerenter);
                Comands.Command_Help(playerenter);
                Comands.Command_Colon(playerenter);
                
                
                
            }
            

        }       
    }
}
