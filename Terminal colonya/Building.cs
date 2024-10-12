using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal_Colonya
{
    public class Building
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

    }
    public class House : Building
    {
        new public string Name = "House";
        new public string Description = "For Heberging Colon";
        public int Bed = 3;
    }

}