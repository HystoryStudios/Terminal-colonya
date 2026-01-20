

using System.Reflection;

namespace TC_CORE
{
    public interface IZone
    {
        string Name { get; }
        string Description { get; }
        int Size { get; }
        void Execute(GameContent gameContent);
    }
    public class ZoneManager
    {
        private GameContent _Content;

        public ZoneManager(GameContent content)
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
                    if (typeof(IZone).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var zone = (IZone)Activator.CreateInstance(type);
                        _Content.AvailableZones[zone.Name] = zone;
                        Console.WriteLine($"Zone chargée : {zone.Name}");
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
