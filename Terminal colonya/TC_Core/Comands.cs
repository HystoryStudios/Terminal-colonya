﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal_colonya;


namespace Terminal_colonya.TC_Core
{
    public class Comands
    {
        public static void Command_Game(string command)
        {

            string commande;
            commande = command;
            string[] partiesCommande = commande.Split(' ');

            string? type = partiesCommande[0];
            string? name = partiesCommande[1];


            if (type == "Game")
            {
                switch (name)
                {
                    case "credit":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("--A game created by--");
                        Console.WriteLine("-----Kotama_chio-----");
                        Console.WriteLine("---------Or----------");
                        Console.WriteLine("---Hystory Studios---");
                        break;

                    case "command_list":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("----Colon----");
                        Console.WriteLine("§ list");
                        Console.WriteLine("§ info [Colon Name]");
                        Console.WriteLine("§ action");
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a correct command ! or take Help");
                        break;
                }
            }

        }

        public static void Command_Help(string command)
        {

            string commande;
            commande = command;
            string[] partiesCommande = commande.Split(' ');

            string? type = partiesCommande[0];
            string? name = partiesCommande[1];


            if (type == "Help")
            {
                switch (name)
                {

                    case "_":
                        Console.WriteLine("Terminal colonya works with commands ");
                        Console.WriteLine("Type Name Value");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a correct command ! or take Help");
                        break;
                }
            }

        }
        public static void Command_Colon(string command)
        {

            string commande;
            commande = command;
            string[] partiesCommande = commande.Split(' ');

            string? type = partiesCommande[0];
            string? name = partiesCommande[1];
            string? value = partiesCommande[2];


            if (type == "Colon")
            {
                switch (name)
                {

                    case "count":

                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Please enter a correct command ! or take Help");
                        break;
                }
            }

        }

        public static void Command_Day(string command)
        {

            string commande;
            commande = command;
            string[] partiesCommande = commande.Split(' ');

            string? type = partiesCommande[0];
            string? name = partiesCommande[1];

            if (type == "Day")
            {
                switch (name)
                {

                    case "get":
                        Console.WriteLine("You are " + "day");
                        break;
                    case "end":



                    default:
                        Console.WriteLine("Please enter a correct command ! take Help");
                        break;
                }
            }


        }
    }
}
