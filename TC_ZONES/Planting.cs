using HOTTUI;
using System;
using System.Runtime;
using System.Windows.Input;
using TC_CORE;

namespace TC_ZONES
{
    public class Planting : IZone
    {
        public string Name => "Planting";
        public string Description => "To EAT !";
        public int Size => 0;
        public void Execute(GameContent gameState)
        {

        }
    }
}
