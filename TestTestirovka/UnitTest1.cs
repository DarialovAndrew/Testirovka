using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Testirovka;

namespace TestTestirovka
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CollectionAssert.AreEquivalent(new Tasks().Task1<int>(new List<object> { "Andrew", "Victor", 1, 2, 3 }), new List<int> { 1,2,3});
            CollectionAssert.AreEquivalent(new Tasks().Task1<int>(new List<object> { "Andrew", "Victor", 1, 2, 3,5,6 }), new List<int> { 1, 2, 3 ,5,6});
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(new Tasks().Task2("Abacalama"), "b");
            Assert.AreEqual(new Tasks().Task2("Aacalama"), "c");
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(new Tasks().Task3(123456789), 9);
            Assert.AreEqual(new Tasks().Task3(12345), 6);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(new Tasks().Task4(new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 },5), 2);
            Assert.AreEqual(new Tasks().Task4(new int[] { -4, -3, -2, -1, 0, 1, 2, 3 }, 5), 1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(new Tasks().Task5("Andrew:Darialov;Victor:Gorkustenko;Maksym:Brazhniy;Anton:Brazhniy"), "(BRAZHNIY, ANTON)(BRAZHNIY, MAKSYM)(DARIALOV, ANDREW)(GORKUSTENKO, VICTOR)");
            Assert.AreEqual(new Tasks().Task5("Andrew:Darialov;Vitalii:Gurianov;Maksym:Brazhniy;Anton:Brazhniy"), "(BRAZHNIY, ANTON)(BRAZHNIY, MAKSYM)(DARIALOV, ANDREW)(GURIANOV, VITALII)");
        }
    }
}
