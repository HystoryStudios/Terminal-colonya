using HOTTUI;

namespace Terminal_colonya.TC_Core
{
    
    public abstract class Build 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void Logic();

        public Build(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
    public class Bed_Room : Build
    {
        public int Number = 0;
        public Bed_Room(int number) 
            : base("Bed_Room", "For do good dream")
        {
            Number = number;
        }
        public override void Logic()
        {

        }
    }
    public class Build_System
    {
        public List<Build> Builds = new List<Build>();

        public void Add(Build build)
        {
            Builds.Add(build);
        }
        
        public Build_System(List<Build> builds)
        {
            Builds = builds;
        }
    }
}