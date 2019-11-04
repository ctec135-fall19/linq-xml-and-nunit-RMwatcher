using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// we added using NUnit.Framework; to allow this class to use the NUnit 
// software for testing code
using NUnit.Framework;
// using Prob3; allows us to access the Prob3 project as well as the classes
// within it.
using Prob3;

// we added .UnitTests to the namespace to tell us that this class library
// project is used for testing code.
namespace ClassProb2.UnitTests
{
    // TestFixture tells us that this class will be used to test out code
    // and in this case two methods. We added Tests to ClassProb2 to tell
    // us that this class will have it's code tested.
    [TestFixture]
    public class ClassProb2Tests
    {
        // Test is used to tell us that the following method will be tested 
        // with the test explorer. This public void method named is based on
        // the method being called, that this method will do and the expected
        // result
        [Test]
        public void MultiAdd_MultiplyAndSumWithinByteRange_ReturnCorrectEquation()
        {
            // The following lines of code will assert the following method
            // which the code before it shows where this method came from as 
            // well as arguments and the expected result at the Is.EqualTo()
            // section at the end
            Assert.That(Prob3.ClassProb2.MultiAdd(20, 5, 25), Is.EqualTo(125));
        }

        // this is similar to the following code adove this one where Test
        // let us know that the following code will be tested. The name of this
        // method describes the method that is being called, the behavior the
        // method will perform and the expected result, which it'll throuw
        // an exception.
        [Test]
        public void MulitAdd_MulitplyAndAddOutsideByteRange_ThrowsException()
        {
            // The following lines of code works like the one inside the first
            // method just another way of writing it using => instead and it show
            //s the path of the method MultiAdd() and the arguments. The 
            // expected results of this method will throw an exception due to 
            // overflow
            Assert.That(() => Prob3.ClassProb2.MultiAdd(100, 2, 150), Throws.Exception);
        }
    }
}
