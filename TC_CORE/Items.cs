
namespace TC_CORE
{
    public interface IItem
    {
        string Name { get; }
        string Description { get; }
        void Execute(GameContent gameState);
    }
    public class ItemManager
    {

    }
}

