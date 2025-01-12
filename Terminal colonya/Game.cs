using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Terminal_colonya.TC_Core;
using Hystory_Open_Technology_Terminal_User_Interface;
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
            Console.OutputEncoding = Encoding.UTF8;
            List<Colon> colon = new List<Colon>();
            Colonie colonie = new Colonie(colon);

            colonie.Genarate_Begin_Colonie();
            foreach (Colon c in colon)
            {
                Console.WriteLine((c.Name, c.Sexe, c.Age));
            }
        }       
    }
}
