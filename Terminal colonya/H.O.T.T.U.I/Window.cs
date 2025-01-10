using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hystory_Open_Technology_Terminal_User_Interface
{
    public class Window
    {
        public static void SetWindow(string? WindowName, ConsoleColor color)
        {
            int ConsoleSizeWidth = Console.WindowWidth;
            int ConsoleSizeHeight = Console.WindowHeight;
            char jsp = '-';
            Console.Clear();  
            Console.Title = WindowName;
            Tools.Horizontal_Line(ConsoleSizeWidth, color, jsp);
            Tools.Color_Write(color, (WindowName + "\n"));
            Tools.Horizontal_Line(ConsoleSizeWidth, color, jsp);
        }
    }
}