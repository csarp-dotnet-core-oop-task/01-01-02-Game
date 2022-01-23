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
    public class DogTests
    {
        [TestMethod()]
        public void RunTest()
        {
            Dog dog = new Dog();
            string expected = "A kutya szalad.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            dog.Run();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Run függvény nem a megfelelő szöveget írja a képernyőre!");
        }

        [TestMethod()]
        public void StandTest()
        {
            Dog dog = new Dog();
            string expected = "A kutya áll.\r\n";

            StringWriter sw = new StringWriter();
            Console.SetOut(sw);
            dog.Stand();

            string actual = sw.ToString();
            Assert.AreEqual(expected, actual, "A Stand függvény nem a megfelelő szöveget írja a képernyőre!");
        }
    }
}