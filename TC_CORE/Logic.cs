using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TC_CORE
{
    public interface ILogic
    {
        string Name { get; }
        string Description { get; }
        void Execute(GameContent content, GameData gameData, GameVars gameVars);
    }
    public class LogicManager
    {
        private GameContent _Content;

        public LogicManager(GameContent content)
        {
            _Content = content;
        }
        public void LoadCommandsFromAssembly(string dllPath)
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                foreach (var type in assembly.GetTypes())
                {
                    if (typeof(ILogic).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var logic = (ILogic)Activator.CreateInstance(type);
                        _Content.AvailableLogics[logic.Name] = logic;
                        Console.WriteLine($"Logic chargée : {logic.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error to loading {dllPath}: {ex.Message}");
            }
        }
    }
}
