using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab.Tests
{
    [TestClass()]
    public class CaesarCypherTests
    {
        [TestMethod()]
        public void cypherTest()
        {
            var testCypher = new CaesarCypher(" ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            testCypher.setOffset(4);
            testCypher.setTranspose();
            var outputStr = testCypher.cypher("JENNY");

            Assert.AreEqual(outputStr, "NIRRB");
        }

        [TestMethod()]
        public void transposeAlphabetTest()
        {
            var testTranspose = new CaesarCypher("ABCDE");
            testTranspose.setOffset(2);
            testTranspose.setTranspose();
            string result = testTranspose.getTranspose();
            string expected = "CDEAB";
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void transposeAlpha2()
        {
            var testTranspose2 = new CaesarCypher(" ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            testTranspose2.setOffset(4);
            testTranspose2.setTranspose();
            string result = testTranspose2.getTranspose();
            string expected = "DEFGHIJKLMNOPQRSTUVWXYZ ABC";
            Assert.AreEqual(expected, result);

        }

        [TestMethod()]
        public void decypherTest()
        {
            var testCypher = new CaesarCypher(" ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            testCypher.setOffset(4);
            testCypher.setTranspose();
            var outputStr = testCypher.decypher("NIRRB");

            Assert.AreEqual(outputStr, "JENNY");
        }
    }
}
