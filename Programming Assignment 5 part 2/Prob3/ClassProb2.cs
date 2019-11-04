using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    // we added a public keyword to make this class avaliable to all other 
    // classes
    public class ClassProb2
    {
        // here we created a public static byte method called MultiAdd that
        // takes in three arguments that are byte data types
        public static byte MultiAdd(byte x, byte y, byte z)
        {
            // The check keyword is able to cause the method to throw an
            // exception if the value of the three arguments causes an 
            // overflow
            checked
            {
                // When the method is called, it'll return the results of x 
                // multiple by y plus z
                return (byte)((x * y) + z);
            }
            
        }
    }
}
