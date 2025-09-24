using HOTTUI;
using TC_CORE;
using System;
using System.Runtime;

namespace TC_COMMANDS
{
    public class Help : ICommand
    {
        public string Name => "help";
        public string Description => "to introduce to TC";
        public void Execute(string[] args, GameContent gameState)
        {
            Tools.Write.WriteLine("Welcome to Terminal Colonya !");
            Tools.Write.WriteLine("--Available Commands--");

            foreach (var cmd in gameState.AvailableCommands.Values)
            {
                Console.WriteLine($"/{cmd.Name}: {cmd.Description}");
            }
        }
    }
}
