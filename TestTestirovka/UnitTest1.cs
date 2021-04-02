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
            var input = new List<object>() { 1, 2, "a", "b" };
            var output = new List<int>() { 1, 2 };

            var result = new Tasks().Task1<int>(input);
            if (!(output.All(result.Contains) && output.Count == result.Count))
                throw new Exception("WRONG");

            var input1 = new List<object>() { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            var output1 = new List<int>() { 1, 2, 231 };

            var result1 =new  Tasks().Task1<int>(input1);
            if (!(output1.All(result1.Contains) && output1.Count == result1.Count))
                throw new Exception("WRONG");
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
