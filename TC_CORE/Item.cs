using System.Reflection;

namespace TC_CORE
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
        void Execute(GameContent content, GameData gameData, GameVars gameVars);
    }
    public class ItemManager
    {
        private GameContent _Content;

        public ItemManager(GameContent content)
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
                    if (typeof(IItem).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var item = (IItem)Activator.CreateInstance(type);
                        _Content.AvailableItems[item.Name] = item;
                        Console.WriteLine($"Item chargée : {item.Name}");
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

