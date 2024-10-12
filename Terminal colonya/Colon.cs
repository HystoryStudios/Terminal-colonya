using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace Terminal_Colonya
{
    
    public class Colon
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sexe { get; set; }
        

        public class Colon_Member
        {
            
        }



        public Colon(int age, string name, string sexe)
        {
            Name = name;
            Age = age;
            Sexe = sexe;
        }

    }
    
    
        public class Colonie
        {
            public List<Colon> colons = new List<Colon>();
            static void GetName()
            { 
                
                
                
            }

            
            public void AddColon(Colon colon)
            {
                Random random = new Random();
                colon.Name = "Celeste";
                colon.Age = random.Next(1, 100);
                colon.Sexe = "N";
                colons.Add(colon);
            }
            
        }
}