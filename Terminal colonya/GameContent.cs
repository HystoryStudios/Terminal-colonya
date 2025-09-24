

namespace TC_CORE
{
    public class GameContent
    {
        public Dictionary<string, ICommand> AvailableCommands { get; } = new();
        public Dictionary<string, IBuild> AvailableBuilds { get; } = new();
        public Dictionary<string , IItem> AvailableItems { get; } = new();
        public Dictionary<string , IZone> AvailableZones { get; } = new();
    }
}
