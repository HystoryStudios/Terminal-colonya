using TC_CORE;

namespace TC_BUILDS
{
    public class Chamber : IBuild
    {
        public string Name => "Chamber";
        public string Description => "To Dream !";
        public int Level => 1;
        public int Bed = new int();
        public void Init(string[] args)
        {
            Bed = int.Parse(args[0]);
        }
    }
}