using System.ComponentModel;
using System;
using System.Collections.Generic;

namespace Terminal_colonya.TC_Core
{

    public class Colon
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public char Sexe { get; set; }
        private string Humeur { get; set; }

        public class Colon_Humeur
        {
            public static void Happy()
            {
                
            }
        }
        public class Colon_Member
        {

        }


        public class Colon_AI
        {

        }


        public Colon(int age, string name, char sexe)
        {
            Name = name;
            Age = age;
            Sexe = sexe;
            
        }

    }


    public class Colonie
    {

        public List<Colon> colons = new List<Colon>();

        public void AddColon(string name, int age, char gender)
        {
            
            Colon colon = new Colon(age, name, gender);
            colons.Add(colon); 
        }

        

    }
}