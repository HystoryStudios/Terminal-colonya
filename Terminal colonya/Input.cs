namespace TC_CORE
{
    public class Input
    {
        public string Read_Input()
        {
            StreamReader input = new StreamReader("C:\\Users\\natsu\\Source\\Repos\\Terminal-colonya\\Terminal colonya\\Resources\\Current_Input.txt");
            return input.ReadToEnd().Trim();
        }
        public string[] Get_Input()
        {
            return Read_Input().Split(' ');
        }
    }
}
