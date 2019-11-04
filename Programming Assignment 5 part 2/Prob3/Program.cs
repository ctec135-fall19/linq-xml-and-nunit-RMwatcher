/*
Author: Richard Mora
Date: 11/3/2019
CTEC 135: Microsoft Software Development with C#

Programming Assignment 5: LINQ and Unit Testing

Prob3: NUnit

After creating a new solution and project, add a new class then create 
    a new static method called MulitAdd that takes three bytes arguments and 
    return a byte value type. 

The first method should return a value below 256 while the second method 
    will return a value greater than 256

Print out the results of each method. The first method should return a value
    that is less than 256 while the second method should return a value greater
    than 256 and give you a wrong answer.

Create a second class and add the same method as the first class except use 
    add catch and add the same method from the previous class and add a  
    catch {} in each one. If the value is outside of byte range 256, same as 
    before, it'll throw an exception instead. Run the program.

Create a new class library project and name it after the second class while
    adding .UnitTests at the end. Rename the default source file by adding
    Tests at the end. Install NUnit and it's test adapter to this library 
    and set it to the default project. Be sure to add public to the access 
    modifier before the class keyword.

Go the reference file of the current and make sure you add the base file
    (in this case Prob3) as a reference and confirm the change. Be sure to add
    using NUnit.Framework;and using Prob3; at the top of the file.

Add the text [TestFixture] at top of the public class modifier and [test]
    over the method you're about to create. The new method name should first
    include the method you're running, what's it going to do and the expected
    result which in this case you get a correct value. The second method name
    should be mostly the same excepted you expected a incorrect value when it
    runs.

Use the Assert keyword with AreEqual() method where the first thing that 
    appears inside the method is the expected result, the base file the main
    method came from, the sub class where you call the main method with added
    arguments. Do the same with the second method only give a incorrect value.

Open the test explorer and run 'test' on the methods from this library 
    class.

Create a second class library project and perform the same tasks as adove 
    except inside the first method use Assert.That(Base class.subclass.method 
    name (arguments), Is.EqualTo(expected results)); and the second method 
    enter Assert.That(() => base class. sub class. method name(arguments), 
    Throws.Exception); and run the test again.

     
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Complex math at work");

            // we use the try statement to test code inside this statement
            try
            {
                // We print out the results of three byte data types using 
                // the method MultiAdd() from ClassProb2 class inside of a 
                // try statement to see if the results are correct or not
                // for both methods. If one of them have a overflow exception
                // the catch will throw a message.
                Console.WriteLine("20 * 5 + 25 = {0}", ClassProb2.MultiAdd(20, 5, 25));
                Console.WriteLine("100 * 2 + 100 = {0}", ClassProb2.MultiAdd(100, 2, 150));
            }

            // if the try statement finds a exception, this catch statement 
            // will run the code inside of this statement
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
