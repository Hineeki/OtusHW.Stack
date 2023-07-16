using System.Runtime.InteropServices;

namespace StackHomeWork
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            var pook = new Stack("213", "asd", "qwe", "asd", "zxc");
            
            pook.Pop();
            pook.Add("qwerty");
            pook.Clear();
            //pook.Pop();
            Console.WriteLine(pook.Size);
            Console.WriteLine(pook.Top);
        }
    }
}
