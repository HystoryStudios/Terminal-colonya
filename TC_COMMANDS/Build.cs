using HOTTUI;
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
            else
            {
                switch (args[0])
                {
                    case null:
                        break;
                    case "create":
                        gameContent.AvailableBuilds.TryGetValue(args[1], out var build);
                        gameData.Builds.Add(build);
                        Tools.Write.WriteLine($"You have create one : {build.Name}");
                        break;
                    case "delete":
                        break;
                    case "list":
                        Tools.Write.WriteLine("--Your builds--");
                        foreach (var building in gameData.Builds)
                        {
                            Tools.Write.WriteLine($"|- {building.Name}");
                        }
                        break;
                    case "upgrade":
                        break;
                }
            }
        }
    }
}
