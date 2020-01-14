/**
 * Author:
 * Date:
 * Platform: Visual Studio / C#
 * 
 * Revision History:
 *
 * 
 * ===========================================================================
 *                              Class Invariants
 * ===========================================================================
 *
 * 
 * ===========================================================================
 *                            Interface Invariants
 * ===========================================================================
 *
 */

using p1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace p1Test {
    [TestClass]
    public class intDivTest {

        [TestMethod]
        public void intDivTest_ObjectInstantiation() {
            intDiv idTest = new intDiv();

            Assert.IsInstanceOfType(idTest, typeof(intDiv),
                "Object returned is not of type intDiv!");
        }
    }
}

/**
 * ===========================================================================
 *                        Implementation Invariants
 * ===========================================================================
 *
 */

