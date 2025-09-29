using HOTTUI;
using TC_CORE;

namespace Terminal_colonya
{
    public class Program
    {
        public static void Main()
        {
            var gs = new GameContent();
            var cm = new CommandManager(gs);
            var bc = new BuildingManager(gs);
            var gd = new GameData();
            Console.WriteLine("Welcome to TC !");

            string commandsDllPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                @"TC_COMMANDS.dll"
            );
            string buildsDllPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                @"TC_BUILDS.dll"
            );

            cm.LoadCommandsFromAssembly(commandsDllPath);
            bc.LoadBuildsFromAssembly(buildsDllPath);

            while (true)
            {
                Tools.Write.Color_Write(ConsoleColor.Green, "\n> ");
                var UserInput = Console.ReadLine();
                if (UserInput == "exit")
                {
                    break;
                }
                cm.ExecuteCommand(UserInput, gs, gd);
            }
        }
    }
}
