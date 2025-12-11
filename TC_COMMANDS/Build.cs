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
                        if (build != null)
                        {
                            gameData.Builds.Add(build);
                            Tools.Write.WriteLine($"You have create one : {build.Name}");
                        }
                        else
                        {
                            Tools.Write.Color_Write(ConsoleColor.Red, $"ERROR : {args[1]} is not a build !");
                        }
                        break;
                    case "delete":
                        for (int i = 0; i < gameData.Builds.Count; i++)
                        {
                            Tools.Write.WriteLine($"{i} : {gameData.Builds[i].Name} ; {gameData.Builds[i].Level}");
                        }
                        Tools.Write.Color_Write(ConsoleColor.Red, "What build you delete ? : ");
                        int r= int.Parse(Console.ReadLine());
                        gameData.Builds.Remove(gameData.Builds[r]);

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
