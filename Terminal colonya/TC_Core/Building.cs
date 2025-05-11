using Hystory_Open_Technology_Terminal_User_Interface;

namespace Terminal_colonya.TC_Core
{
    
    public abstract class Build 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public abstract void Logic();

        public Build(string name, string description, int number)
        {
            Name = name;
            Description = description;
            Number = number;
        }
    }
    public class Bed_Room : Build
    {
        public string Name = "Bed_Room";
        public string Description = "For Do good dream";
        public int Number = 0;
        public Bed_Room(int number) : base(null, null, number)
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