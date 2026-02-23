

namespace TC_CORE
{
    public class GameVars
    {
        public Dictionary<string, int> MemoryInts = new Dictionary<string, int>();
        public Dictionary<string, string> MemoryStrings = new Dictionary<string, string>();
        public Dictionary<string, List<string>> MemoryListStrings = new Dictionary<string, List<string>>();
        public Dictionary<string, List<object>> MemoryListObjects = new Dictionary<string, List<object>>();
        public Dictionary<string, object> MemoryObjects = new Dictionary<string, object>();
        public Random Random = new Random();
    }
}
