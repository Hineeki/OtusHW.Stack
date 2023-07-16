using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomeWork
{
    internal class Stack
    {
        List<string> _strings;
        public Stack(params string[] strings)
        {
            _strings = new List<string>();
            foreach (string s in strings)
            {
                _strings.Add(s);
            }
        }
        public void Add(string s)
        {
            _strings.Add(s);
        }
        public string Pop()
        {
            if (_strings.Count == 0)
            {
                throw new EmptyEx("Стек пустой");
            }
            string poopedString = (_strings[_strings.Count - 1]);
            _strings.RemoveAt(_strings.Count - 1);
            return poopedString;
        }
        public void Clear()
        {
            _strings.Clear();
        }

        //public int Size
        //{
        //    get
        //    {                
        //        return _strings.Count;
        //    }
        //}
        public string Size => Convert.ToString(_strings.Count);
        public string Top
        {
            get
            {
                if (_strings.Count == 0)
                {
                    return null;
                }
                return _strings[_strings.Count-1];
            }
        }
    }    
}
