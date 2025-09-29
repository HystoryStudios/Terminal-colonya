using HOTTUI;
using TC_CORE;

namespace TC_COMMANDS
{
    public class Availible : ICommand
    {
        public string Name => "availble";
        public string Description => "[DEBUG] to know what the game/mod content is loading";
        public void Execute(string[] args, GameContent gameContent, GameData gameData)
        {
            if (args.Length == 0)
            {
                return;
            }
            else
            {
                switch (args[0])
                {
                    case "build":
                        Tools.Write.WriteLine("--Builds--");

                        foreach (string name in gameContent.AvailableBuilds.Keys)
                        {
                            Tools.Write.WriteLine($"|-{name}");
                        }
                        break;
                }
            }
        }
    }
}
