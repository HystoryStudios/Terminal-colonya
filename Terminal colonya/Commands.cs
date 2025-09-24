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
        private GameState _state;

        public CommandManager(GameState state)
        {
            _state = state;
        }

        public void LoadCommandsFromAssembly(string dllPath)
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                foreach (var type in assembly.GetTypes())
                {
                    if (typeof(ICommand).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var command = (ICommand)Activator.CreateInstance(type);
                        _state.AvailableCommands[command.Name] = command;
                        Console.WriteLine($"Commande chargée : {command.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error to loading {dllPath}: {ex.Message}");
            }
        }

        public void ExecuteCommand(string input, GameState state)
        {
            if (string.IsNullOrWhiteSpace(input)) return;

            var parts = input.Split(' ');
            string cmdName = parts[0].Trim('/');
            string[] args = parts.Skip(1).ToArray();

            if (_state.AvailableCommands.TryGetValue(cmdName, out var command))
            {
                command.Execute(args, state);
            }
            else
            {
                Console.WriteLine($"this command not exist : {cmdName}");
            }
        }
            
    }
}