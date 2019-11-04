using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    // we add the public keyword to make it accessiable to other classes
    public class ClassProb
    {
        // here we create a public static byte method that is called MultiAdd
        // that takes in three arguments that are byte data types
        public static byte MultiAdd(byte x, byte y, byte z)
        {
            // when this method is called, it'll return the a value when 
            // the value of x is multiple by y and adds z, all as bytes data
            // types thanks to casting.
            return (byte)((x * y) + z);
        }
    }
}
