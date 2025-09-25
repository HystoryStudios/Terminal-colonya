

namespace TC_CORE
{
    public interface IBuild
    {
        string Name { get; }
        string Description { get; }
        int Size {get;}
        void Logic(GameContent gameState);
        void Init(int Size);
    }
    public class BuildingManager
    {

    }
}
