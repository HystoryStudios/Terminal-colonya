using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal_colonya.TC_Core;

namespace Terminal_colonya.TC_UI
{
    internal class MainWindow
    {
        public static void Main(string[] args)
        {
            List<Colon> list = new List<Colon>();
            Colonie colonie = new Colonie(list);
            colonie.Genarate_Begin_Colonie(3);
            string[] input = Console.ReadLine().Split(' ');
            Commands commands = new Commands(input);
            commands.Command(list);
        }
    }
    
}
