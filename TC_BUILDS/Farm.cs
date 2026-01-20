using TC_CORE;

namespace TC_BUILDS
{
    public class Farm : IBuild
    {
        public string Name => "Farm";
        public string Description => "For plant";
        public int Level => 1;
        public int Size = new int();
        public void Init(string[] args)
        {
            Size = int.Parse(args[0]);
        }
    }
}
