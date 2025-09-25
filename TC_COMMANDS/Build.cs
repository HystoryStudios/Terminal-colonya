using HOTTUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_CORE;

namespace TC_COMMANDS
{
    public class Build :ICommand
    {
        public string Name => "build";
        public string Description => "All commands for build";
        public void Execute(string[] args, GameContent gameContent, GameData gameData)
        {
            if (args.Length == 0)
            {
                Tools.Write.WriteLine("--Commands for build--");
                Tools.Write.WriteLine("-build create <type>");
                Tools.Write.WriteLine("-build upgrade");
                Tools.Write.WriteLine("-build delete");
                Tools.Write.WriteLine("-build list");
            }

            switch (args[0])
            {
                case null:
                    break;
                case "create":
                    gameContent.AvailableBuilds.TryGetValue(args[1], out var builds);
                    gameData.Builds.Add(builds);
                    break;
                case "delete":
                    break;
                case "list":
                    break;
                case "upgrade":
                    break;
            }
        }
    }
}
