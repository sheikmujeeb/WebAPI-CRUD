using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class revrse
    {
        public void reverse(string a)
        {
            Console.WriteLine("Reverse");
             string temp ;
            string temp2;
            string result;
            
            for(int i=0;i<a.Length; i++)
            {

                temp = Convert.ToString(a[i]);
                temp2 = temp;

                result = temp + temp2;
                
                Console.WriteLine(result);
                



            }
            

        }
    }
}
