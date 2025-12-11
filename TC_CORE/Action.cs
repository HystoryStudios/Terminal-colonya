using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_CORE
{
    public interface IAction
    {
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }
        public int Priority { get; }
        public void Logic(GameContent gameContent, GameData gameData);
    }
}
