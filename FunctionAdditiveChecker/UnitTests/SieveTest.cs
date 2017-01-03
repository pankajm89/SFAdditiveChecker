using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionAdditiveChecker;
using System.Collections.Generic;

namespace SievePrimeNumberGenerator
{
    [TestClass]
    public class SieveTest
    {
        [TestMethod]
        public void GeneratePrimeNumbers_Limit0()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(0);

            List<int> expectedResult = new List<int>();
            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_LimitMinus1()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(-1);

            List<int> expectedResult = new List<int>();
            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_Limit1()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(1);

            List<int> expectedResult = new List<int>();
            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_Limit3()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(3);
            List<int> expectedResult = new List<int>();
            expectedResult.Add(2);
            expectedResult.Add(3);

            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_Limit10()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(10);
            List<int> expectedResult = new List<int>();
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(5);
            expectedResult.Add(7);

            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_Limit100()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(100);
            List<int> expectedResult = new List<int>();
            expectedResult.Add(2); expectedResult.Add(3); expectedResult.Add(5); expectedResult.Add(7);
            expectedResult.Add(11); expectedResult.Add(13); expectedResult.Add(17); expectedResult.Add(19);
            expectedResult.Add(23); expectedResult.Add(29); expectedResult.Add(31); expectedResult.Add(37);
            expectedResult.Add(41); expectedResult.Add(43); expectedResult.Add(47); expectedResult.Add(53);
            expectedResult.Add(59); expectedResult.Add(61); expectedResult.Add(67); expectedResult.Add(71);
            expectedResult.Add(73); expectedResult.Add(79); expectedResult.Add(83); expectedResult.Add(89);
            expectedResult.Add(97);

            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GeneratePrimeNumbers_Limit300()
        {
            SievePrimeGenerator spg = new SievePrimeGenerator(300);
            List<int> expectedResult = new List<int>();
            expectedResult.Add(2); expectedResult.Add(3); expectedResult.Add(5); expectedResult.Add(7);
            expectedResult.Add(11); expectedResult.Add(13); expectedResult.Add(17); expectedResult.Add(19);
            expectedResult.Add(23); expectedResult.Add(29); expectedResult.Add(31); expectedResult.Add(37);
            expectedResult.Add(41); expectedResult.Add(43); expectedResult.Add(47); expectedResult.Add(53);
            expectedResult.Add(59); expectedResult.Add(61); expectedResult.Add(67); expectedResult.Add(71);
            expectedResult.Add(73); expectedResult.Add(79); expectedResult.Add(83); expectedResult.Add(89);
            expectedResult.Add(97); expectedResult.Add(101); expectedResult.Add(103); expectedResult.Add(107);
            expectedResult.Add(109); expectedResult.Add(113); expectedResult.Add(127); expectedResult.Add(131);
            expectedResult.Add(137); expectedResult.Add(139); expectedResult.Add(149); expectedResult.Add(151); expectedResult.Add(157);
            expectedResult.Add(163); expectedResult.Add(167); expectedResult.Add(173); expectedResult.Add(179);
            expectedResult.Add(181); expectedResult.Add(191); expectedResult.Add(193); expectedResult.Add(197);
            expectedResult.Add(199); expectedResult.Add(211); expectedResult.Add(223); expectedResult.Add(227);
            expectedResult.Add(229); expectedResult.Add(233); expectedResult.Add(239); expectedResult.Add(241);
            expectedResult.Add(251); expectedResult.Add(257); expectedResult.Add(263); expectedResult.Add(269);
            expectedResult.Add(271); expectedResult.Add(277); expectedResult.Add(281); expectedResult.Add(283);
            expectedResult.Add(293);

            List<int> actualResult = spg.GeneratePrimeNumbers();

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}