using System.ComponentModel;

namespace Terminal_Colonya
{
    
    public class Colon
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }



        public Colon(int age, string name, string sexe)
        {
            Name = name;
            Age = age;
            Sexe = sexe;
        }

    }
    
    
        public class Colonie
        {
            public List<Colon> Colons { get; set; }

            public Colonie()
            {
                Colons = new List<Colon>();
            }

            public void AddColon(Colon colon)
            {
                Random random = new Random();
                colon.Name = "Celeste";
                colon.Age = random.Next(18, 100);
                Colons.Add(colon);
                
                
            }
        }


}