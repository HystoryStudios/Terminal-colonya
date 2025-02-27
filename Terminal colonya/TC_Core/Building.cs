﻿using Hystory_Open_Technology_Terminal_User_Interface;

namespace Terminal_colonya.TC_Core
{
    
    public class Build 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }

        public Build(string name, string description, int number)
        {
            Name = name;
            Description = description;
            Number = number;
        }
        public void Print_info(Build build)
        {
            Tools.Horizontal_Line(Console.WindowWidth, ConsoleColor.Red, '-');
            Tools.Color_Write(ConsoleColor.Green, $"| Name : {build.Name}");
            Tools.Color_Write(ConsoleColor.Green, $"| Utilityes : {build.Description}");
            Tools.Color_Write(ConsoleColor.Green, $"| Number : {build.Number}");
            Tools.Horizontal_Line(Console.WindowWidth, ConsoleColor.Red, '-');
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
            Print_info(this);
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