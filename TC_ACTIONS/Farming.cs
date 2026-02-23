using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_CORE;

namespace TC_ACTIONS
{
    public class Farming : IAction
    {
        public string Name => "Faming";
        public string Description => "for demand to a colon to farm";
        public string Type => " ";
        public int Priority => 5;
        public void Logic(GameContent gameContent, GameData gameData, GameVars vars)
        {

        }
    }
}
