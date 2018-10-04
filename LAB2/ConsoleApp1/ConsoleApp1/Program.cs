using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StringOperators
    {
        public string concatonate(String X, String Y)
        {
            string merged = X + Y;
            return merged;
        }

        public bool comparison(String X, String Y)
        {

            if (X == Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string copystring(string x)
        {
            string y = x;
            return y;
        }

        public bool empty(string x)
        {
            if(String.IsNullOrEmpty(x))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }

    class Program
    {
       

        static void Main(string[] args)
        {
        }
    }
}
