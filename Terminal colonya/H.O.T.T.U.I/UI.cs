using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hystory_Open_Technologie_Terminal_User_Interface
{
    public class UI
    {
         
            public static void Color_Whrite_line(ConsoleColor Color, string Text)
            {
                Console.ForegroundColor = Color;
                Console.Write(Text);
            }
            public static void Color_Whrite_Back(ConsoleColor Color, ConsoleColor BackGround, string Text)
            {
                Console.BackgroundColor = BackGround;
                Console.ForegroundColor = Color;
                Console.Write(Text);
            }
            public static void Button(string Button_Name)
            {
                var cursor = Console.GetCursorPosition;
                
            }
        public class Window
        {
            public string? WindowName;
            public Window(string? WindowName)
            {
                this.WindowName = WindowName;
                Console.Clear();
                Color_Whrite_Back(ConsoleColor.White, ConsoleColor.Black, "------------------------------------" + WindowName + "------------------------------------\n");
            }
            
        }
    }
}
