using HOTTUI;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace HOTTGF
{
    public class Texture
    {
        private string File {  get; set; }
        public Dictionary<Vector2, char> TextureDic{  get; set; }
        private StreamReader TextureFile { get; set; }
        public Texture(string file)
        {
            File = file;
            TextureDic = new Dictionary<Vector2, char>();
            TextureFile = new StreamReader(file);
            CreateTexture();
        }

        private void CreateTexture()
        {
            while (TextureFile.EndOfStream)
            {
                string? line = TextureFile.ReadLine();
                foreach (char c in line)
                {
                    TextureDic.Add(new Vector2(), c);
                }
            }
        }
        public void Print()
        {
            foreach (var j in TextureDic)
            {
                Console.SetCursorPosition((int)j.Key.X, (int)j.Key.Y);
                Console.WriteLine(j.Value);
            }
        }
    }
}
