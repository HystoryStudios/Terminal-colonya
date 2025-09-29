

using System.Reflection;

namespace TC_CORE
{
    public interface IBuild
    {
        string Name { get; }
        string Description { get; }
        void Logic(GameContent gameContent, GameData gameData);
        void Init(string[] args);
    }
    public class BuildingManager
    {
        private GameContent _content;

        public BuildingManager(GameContent content)
        {
            _content = content;
        }
        public void LoadBuildsFromAssembly(string dllPath)
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                foreach (var type in assembly.GetTypes())
                {
                    if (typeof(ICommand).IsAssignableFrom(type) && !type.IsInterface)
                    {
                        var build = (IBuild)Activator.CreateInstance(type);
                        _content.AvailableBuilds[build.Name] = build;
                        Console.WriteLine($"Build chargée : {build.Name}");
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
