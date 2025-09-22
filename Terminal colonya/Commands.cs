using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System.Reflection;
using System.Runtime.Loader;

namespace TC_CORE
{
    public interface ICommand
    {
        string Name { get; }
        string Description { get; }
        void Execute(string[] args, GameState gameState);
    }
    public class CommandManager
    {
        private Dictionary<string, ICommand> _commands = new();
        private GameState _state;

        public CommandManager(GameState state)
        {
            _state = state;
        }
    }
}
