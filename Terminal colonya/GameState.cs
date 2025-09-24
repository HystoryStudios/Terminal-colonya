using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_CORE
{
    public class GameState
    {
        public Dictionary<string, ICommand> AvailableCommands { get; } = new();
    }
}
