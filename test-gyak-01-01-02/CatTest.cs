using Microsoft.VisualStudio.TestTools.UnitTesting;
using gyak_01_01_02_poliomorf_metodusok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace gyak_01_01_02_poliomorf_metodusok.Tests
{
    [TestClass()]
    public class CatTests
    {
        [TestMethod()]
        public void RunTest()
        {
            Cat cat = new Cat();
            string expected = "A macska szalad.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            cat.Run();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Run függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void StandTest()
        {
            Cat cat = new Cat();
            string expected = "A macska áll.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            cat.Stand();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Stand függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}