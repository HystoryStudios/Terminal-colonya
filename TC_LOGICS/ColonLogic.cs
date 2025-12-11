using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_CORE;

namespace TC_LOGICS
{
    public class ColonLogic : ILogic
    {
        public string Name => "ColonLogic";
        public string Description => "the logic and IA of colon";
        public List<IAction> Actions => new List<IAction>();
        public void Init(GameContent gameContent, GameData gameData)
        {

        }
        public void Execute(GameContent gameContent, GameData gameData)
        {
            
        }
    }
}
