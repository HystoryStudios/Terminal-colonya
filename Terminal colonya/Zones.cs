

namespace TC_CORE
{
    public interface IZone
    {
        string Name { get; }
        string Description { get; }
        int Size { get; }
        void Execute(GameContent gameState);
    }
    public class ZoneManager
    {

    }
}
