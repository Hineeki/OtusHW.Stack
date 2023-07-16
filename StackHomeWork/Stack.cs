using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomeWork
{
    internal class Stack
    {
        List<string> Strings;
        public Stack(params string[] strings)
        {
            Strings = new List<string>();
            foreach (string s in strings)
            {
                Strings.Add(s);
            }
        }
        public void Add(string s)
        {
            Strings.Add(s);
        }
        public void Pop()
        {
            if (Strings.Count == 0)
            {
                throw new EmptyEx("Стек пустой");
            }
            Strings.RemoveAt(Strings.Count - 1);
        }
        public void Clear()
        {
            Strings.Clear();
        }
        public int Size
        {
            get
            {                
                return Strings.Count;
            }
        }
        public string Top
        {
            get
            {
                if (Strings.Count == 0)
                {
                    return null;
                }
                return Strings[Strings.Count-1];
            }
        }
    }    
}
