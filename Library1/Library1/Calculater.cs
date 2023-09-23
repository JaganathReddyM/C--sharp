using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
     public class Calculater
     {
        public int Add(int x, int y)
        {
            return x+y;
        }
        public int Multiply(int x, int y)
        {
            return x*y;
        }
        public int Divide(int x, int y)
        {
            return x/y;
        }
     }
}
