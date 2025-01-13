using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hystory_Open_Technology_Terminal_User_Interface
{
    public class Texture
    {
        public static void ReadTextureUNICOLOR(string filePath, List<string> FinalTexture)
        {
            var texture = new StreamReader(filePath);

            
            for (int i = 0; i < texture.ReadToEnd().Length; i++)
            {
                string rest = texture.ReadLine();
                FinalTexture.Add(rest);
            }
        }
        public static void WhriteTextureUNICOLOR(List<string> FinalTexture, ConsoleColor color)
        {
            foreach (var texture in FinalTexture)
            {
                Tools.Color_Write(color, texture);
            }
        }
    }
}
