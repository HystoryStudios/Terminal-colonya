using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TC_CORE
{
    public interface ICraft
    {
        public string Name { get; }
        public string Description { get; }
        public IItem OutItem { get; }
        public Dictionary<IItem, int> InItems { get; }
    }

    public class CraftManager
    {
        private GameContent _Content;

        public CraftManager(GameContent content)
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
                    if (typeof(ICraft).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var craft = (ICraft)Activator.CreateInstance(type);
                        _Content.AvailableCrafts[craft.Name] = craft;
                        Console.WriteLine($"Craft chargée : {craft.Name}");
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
