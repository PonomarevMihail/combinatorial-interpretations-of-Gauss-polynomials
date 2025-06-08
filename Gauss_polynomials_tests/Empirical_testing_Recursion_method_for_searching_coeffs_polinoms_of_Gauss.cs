using Gauss_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Of_Kursach
{
    [TestClass]
    public class Empirical_testing_Recursion_method_for_searching_coeffs_polinoms_of_Gauss
    {
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK1()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 29, 39, 50 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 17, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK2()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 40 , 52};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 18, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK3()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 53};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 19, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK4()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 20, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK5()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 21, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK6()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 22, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK7()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 23, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK8()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 24, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK9()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 25, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK10()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 26, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK11()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 27, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK12()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 28, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK13()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 29, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK14()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 30, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK15()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 31, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK16()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 32, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK17()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 33, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK18()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 34, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK19()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK20()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 36, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK21()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 41 , 54};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 37, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK22()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 41, 54 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 38, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK23()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 41, 54 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 39, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedK24()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 41 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 40, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }


        //Тесты с фиксированным n
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN1()
        {
            List<int> result = new List<int> { 1,
           1,1,1,1,1,1,1,1,1,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 1;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN2()
        {
            List<int> result = new List<int> { 1,
           1,2,2,3,3,4,4,5,5,6,6};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 2;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN3()
        {
            List<int> result = new List<int> { 1,
           1,2,3,4,5,7,8,10,12};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 3;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN4()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 6, 9, 11, 15, 18, 23, 27, 34 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 4;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN5()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 10, 13, 18, 23, 30, 37 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 5;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN6()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,14,20,26,35,44,58};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 6;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN7()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 21, 28, 38, 49, 65 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 7;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN8()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,15,22,29,40,52,70,89};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 8;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN9()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,15,22,30,41,54,73,94};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 9;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN10()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,15,22,30,42,55,75,97,128};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 10;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN11()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,15,22,30,42,56,76,99,131,169};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 11;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN12()
        {
            List<int> result = new List<int> { 1,
           1,2,3,5,7,11,15,22,30,42,56,77,100,133,172};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 12;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN13()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 13;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN14()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101, 135 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 14;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN15()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101, 135 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 15;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN16()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101, 135 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 16;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN17()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 42 , 56 , 77 , 101 , 135};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 17;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN18()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 42 , 56 , 77 , 101 , 135};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 18;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN19()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 42 , 56 , 77 , 101 , 135};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 19;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN20()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 42 , 56 , 77 , 101 , 135};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 20;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN21()
        {
            List<int> result = new List<int> { 1,
           1,2 , 3 , 5 , 7 , 11 , 15 , 22 , 30 , 42 , 56 , 77 , 101 , 135};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 21;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN22()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 101, 134 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 22;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN23()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 77, 100, 133 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 23;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN24()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 56, 76, 99, 131, 169 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 24;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN25()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 42, 55, 75, 97, 128 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 25;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN26()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 30, 41, 54, 73, 94, 123 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 26;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN27()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 22, 29, 40, 52, 70, 89, 116 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 27;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN28()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 15, 21, 28, 38, 49, 65, 82, 105 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 28;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN29()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 11, 14, 20, 26, 35, 44, 58, 71, 90 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 29;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN30()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 7, 10, 13, 18, 23, 30, 37, 47, 57, 70, 84 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 30;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }
        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN31()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 6, 9, 11, 15, 18, 23, 27, 34, 39, 47, 54 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 31;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN32()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 4, 5, 7, 8, 10, 12, 14, 16, 19, 21, 24, 27 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 32;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN33()
        {
            List<int> result = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 33;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN34()
        {
            List<int> result = new List<int> { 1,
           1,1,1,1,1,1,1,1,1,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 34;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValuesFixedN35()
        {
            List<int> result = new List<int> { 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 35, k = 35;
            List<int> list = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
            CollectionAssert.AreEqual(result, list.GetRange(0, result.Count));
        }

    }
}
