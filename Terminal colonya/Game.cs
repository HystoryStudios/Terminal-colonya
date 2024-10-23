using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terminal_colonya.TC_Core;


// Terminal Colonya is a Open-Source Colony game 
// Terminal Colonya is a H.O.T (Hystory-Open-Technologie)
// Terminal Colonya created by Kotama_chio 

namespace Game
{
    internal class Game
    {

        static void Main(string[] args)
        {
            
            string? playerenter;
            Console.Title = "Terminal Colonya";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("--Welcome ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("to ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Terminal ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Colonya--");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  --Created ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("by ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Kotama");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("_Chio--\n");
            Console.ResetColor();
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("§ ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("T");
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.BackgroundColor = ConsoleColor.Black;  
                Console.Write("C : "); 
                playerenter = Console.ReadLine();
                Comands.Command_Game(playerenter);
                Comands.Command_Help(playerenter);
                Comands.Command_Colon(playerenter);
                
            }
            

        }       
    }
}
