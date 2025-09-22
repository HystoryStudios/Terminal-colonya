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
        public void Execute(string[] args, GameState gameState)
        {
            Tools.Write.WriteLine("Welcome to Terminal Colonya !");
        }
    }
}
