using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// we add using NUnit.Framwork; in order for this page to use the UNit software
// for testing code
using NUnit.Framework;
// using Prob3; is used to access the class Prob3 project and it's other 
// classes
using Prob3;

// for this class library project, I added .UnitTests to show that this project
// is use to test code or a method in this case.
namespace ClassProb.UnitTests
{
    // TestFixture tells the us that this class will be used for testing code
    // in this class while we added public to make it accessiable to other 
    // classes and Tests at the end of ClassProbTests to tell us that this 
    // class is running tests
    [TestFixture]
    public class ClassProbTests
    {
        // Test is used to have this method tested using the test explorer.
        // We created a public void method which the name describes what method
        // it'll run, what the method does and the expected result.
        [Test]
        public void MultiAdd_MultiplyAndSumWithinByteRange_ReturnCorrectEquation()
        {
            // we use Assert.AreEqual() to test inside the AreEqual() method
            // by giving it the expected result, the base class follow by the
            // sub class the method MultiAdd() came from as well as the 
            // arguments that goes with it.
            Assert.AreEqual(125, Prob3.ClassProb.MultiAdd(20, 5, 25));
        }

        // this method is just like the one from adove where test tells us 
        // that this method will be tested. Again this public void method()
        // describes what the method it'll use, expected behavior and expected
        // result
        [Test]
        public void MultiAdd_MultiplyAndSumOutsideByteRange_ReturnIncorrectEquation()
        {
            // similar lines of code as adove except we enter a value that
            // we know will be wrong and gives us a overflow.
            Assert.AreEqual(350, Prob3.ClassProb.MultiAdd(100, 2, 150));
        }
    }
}
