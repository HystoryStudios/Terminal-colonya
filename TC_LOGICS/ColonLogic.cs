using TC_CORE;

namespace TC_LOGICS
{
    public class ColonLogic : ILogic
    {
        public string Name => "ColonLogic";
        public string Description => "the logic of IA of colon";
        public List<IAction> Actions => new List<IAction>();
        public void Execute(GameContent gameContent, GameData gameData)
        {
            
        }
    }
}
