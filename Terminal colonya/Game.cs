using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal_Colonya ; 

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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--Welcome to Terminal Colonya--");
            Console.ResetColor();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;  
                Console.BackgroundColor = ConsoleColor.Black;  
                Console.WriteLine("TC : "); 
                playerenter = Console.ReadLine();
                Comands.Command_Game(playerenter);
                Comands.Command_Help(playerenter);
                Comands.Command_Colon(playerenter);
                
            }
            

        }       
    }
}
