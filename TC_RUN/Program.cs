using HOTTUI;
using TC_CORE;

namespace TC_RUN
{
    public class Program
    {
        public static void Main()
        {
            var gc = new GameContent();
            var cm = new CommandManager(gc);
            var bm = new BuildingManager(gc);
            var lm = new LogicManager(gc);
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
            string logicsDllPath = Path.Combine(
                Directory.GetCurrentDirectory(),
                @"TC_LOGICS.dll"
            );

            cm.LoadCommandsFromAssembly(commandsDllPath);
            bm.LoadBuildsFromAssembly(buildsDllPath);
            lm.LoadCommandsFromAssembly(logicsDllPath);

            while (true)
            {
                foreach (var logic in gc.AvailableLogics.Values)
                {
                    logic.Execute(gc, gd);
                }
                Tools.Write.Color_Write(ConsoleColor.Green, "\n> ");
                var UserInput = Console.ReadLine();
                if (UserInput == "exit")
                {
                    break;
                }
                cm.ExecuteCommand(UserInput, gc, gd);
            }
        }
    }
}
