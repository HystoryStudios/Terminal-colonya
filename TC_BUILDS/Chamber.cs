using HOTTUI;
using System;
using System.Runtime;
using System.Windows.Input;
using TC_CORE;

namespace TC_BUILDS
{
    public class Chamber : IBuild
    {
        public string Name => "Chamber";
        public string Description => "To Dream !";
        public int Size => 0;
        public void Logic(GameContent gameState)
        {
        }
        public void Init(int Size)
        {

        }
    }
}