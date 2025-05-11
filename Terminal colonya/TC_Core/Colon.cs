using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Transactions;
using System.Resources;

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
        public List<Colon> Colons = new List<Colon>();
        public void AddColon(string name, int age, char gender)
        {
            Colon colon = new Colon(age, name, gender);
            Colons.Add(colon); 
        }
        public void Generate_colon(Colon colon)
        {
            Random rd = new Random();
            var reader = new StreamReader("C:\\Users\\natsu\\Source\\Repos\\Terminal colonya\\Terminal colonya\\Resources\\Prenoms.csv");
            int randomname = rd.Next(1, 11628);
            for (int i = 1; i < randomname; i++)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                string name = values[0];
                string sexe = values[1];
                if (sexe == "m,f")
                {
                    sexe = "n";
                }
                int age = rd.Next(1, 100);
                colon.Name = name;
                colon.Sexe = sexe.ToCharArray()[0];
                colon.Age = age;
            }
        }
        public void Genarate_Begin_Colonie(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Colon colon = new Colon(0, null, 'n');
                Generate_colon(colon);
                AddColon(colon.Name, colon.Age, colon.Sexe);
            }
        }
        public Colonie(List<Colon> colons)
        {
            Colons = colons;
        }
    }
}