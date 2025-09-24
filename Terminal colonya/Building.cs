

namespace TC_CORE
{
    public interface IBuild
    {
        string Name { get; }
        string Description { get; }
        void Execute(GameContent gameState);
    }
    public class BuildingManager
    {

    }
}
