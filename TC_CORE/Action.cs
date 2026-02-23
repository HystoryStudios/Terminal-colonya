using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TC_CORE
{
    public interface IAction
    {
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }
        public int Priority { get; }
        public void Logic(GameContent gameContent, GameData gameData, GameVars vars);
    }

    public class ActionManager
    {
        private GameContent _Content;

        public ActionManager(GameContent content)
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
                    if (typeof(IAction).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var action = (IAction)Activator.CreateInstance(type);
                        _Content.AvailableActions[action.Name] = action;
                        Console.WriteLine($"Action chargée : {action.Name}");
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
