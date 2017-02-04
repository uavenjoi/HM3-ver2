using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3
{
    class String1
    {
        public delegate string Filter(string str);
        public string UpperRegister(string str)
        {
            str = str.ToUpper();
            return str;
        }
        public string Revers(string str)
        {
            string buffer = String.Empty;
            for(int i= str.Length; i>0; i--)
            {
                buffer += str[i-1];
            }
            str = buffer;
            return str;
        }
        public string SpaceAdd(string str)
        {
            string buffer = String.Empty;
            for (int i = 0; i<str.Length; i++)
            {
                buffer += str[i]+" ";
            }
            str = buffer;
            return str;
        }
        public string GetFiltered(string str1, Filter filter1)
        {
            return filter1(str1);
        }
    }
}
