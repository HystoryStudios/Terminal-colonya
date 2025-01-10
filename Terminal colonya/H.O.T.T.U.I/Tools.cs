using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Hystory_Open_Technology_Terminal_User_Interface
{
    public class Tools
    {
        
        public static void Color_Write(ConsoleColor Color, string Text)
        {
            Console.ForegroundColor = Color;
            Console.Write(Text);
            Console.ResetColor();
        }
        public static void Color_Write_Back(ConsoleColor Color, ConsoleColor BackGround, string Text)
        {
            Console.BackgroundColor = BackGround;
            Console.ForegroundColor = Color;
            Console.Write(Text);
            Console.ResetColor();
        }
        public static void Button(string Button_Name)
        {
            var cursor = Console.GetCursorPosition;
        }
        public static void Horizontal_Line(int size, ConsoleColor color, char type)
        {
            for (int i = 0; i < size; i++)
            {
                Tools.Color_Write(color, type.ToString());
            }
        }
        public static void Vertical_Line(int size, ConsoleColor color)
        {
            //This Fonction is for create a vertical line in the left of the terminal
            for (int i = 0; i < size; i++)
            {
                Tools.Color_Write(color, "|\n");
            }
        }
        public static void Loading_Bar(int size, ConsoleColor color, int DelayTime)
        {
            for(int i = 0;i < size;i++) 
            {
                Thread.Sleep(DelayTime);
                Color_Write_Back(color, color, " "); 
            }
        }
        public static int Menu(string Menu_Name, int choise, List<string> ellement)
        {
            for (int i = 1;i < ellement.Count(); i++ )
            {
                string jsp = ellement.ElementAt<string>(i);
                Console.WriteLine($"{i} : {jsp}");
            }
            choise = int.Parse(Console.ReadLine());
            return choise;
        }
        public static void Print_List_Int(List<int> ellementInt)
        {
            for (int i = 1; i < ellementInt.Count(); i++)
            {
                int ell = ellementInt.ElementAt<int>(i);
                Console.WriteLine(ell);
            }
        }
        public static void Print_List_String(List<string> ellementString)
        {
            for (int i = 1; i < ellementString.Count(); i++)
            {
                string ell = ellementString.ElementAt<string>(i);
                Console.WriteLine(ell);
            }
        }
        public static void PixelArt(ConsoleColor color, string symbol)
        {
            Color_Write(color, symbol);
        }
        public static void RainbowString(string text)
        {
            Random rd = new Random();
            
            foreach (var character in text)
            {
                var consoleColors = (ConsoleColor)rd.Next(0, 16);
                Color_Write(consoleColors, character.ToString());
            }
        }
        public static void WriteMachine(string text, int speed)
        {
            foreach (var character in text)
            {
                Console.Write(character.ToString());
                Thread.Sleep(speed);
            }
        }
    }
}
