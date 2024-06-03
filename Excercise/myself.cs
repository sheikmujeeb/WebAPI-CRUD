using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    class myself
    {
        public void wordreverse()
        {
            string str;
            string a = "";
            Console.WriteLine("Enter the string:");
            str = Console.ReadLine();
            str = str.ToLower();
            for(int i=str.Length;i>=0;i++)
            {
                a = a + str[i];
                
            }
            Console.WriteLine(a);
        }
    }
}
