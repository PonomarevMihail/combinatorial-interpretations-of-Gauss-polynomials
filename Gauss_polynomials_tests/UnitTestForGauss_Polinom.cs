using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Gauss_1;
using System.Collections.Generic;
namespace Test_Of_Kursach
{
    [TestClass]
    public class UnitTestForGauss_Polinom
    {
        [TestMethod]
        
        public void Gauss_polinomCreatorWithNulls()
        {
            List<int> result = new List<int> { 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 0, k = 0;
            
            var ex = Assert.ThrowsException<Exception>(
                () => gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k)
            );
            Assert.AreEqual("Недопустимое значение", ex.Message);

        }

        [TestMethod]
        public void Gauss_polinomCreatorWithSimilarValues()
        {
            List<int> result = new List<int> { 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 10;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);

        }

        
        [TestMethod]
        public void Gauss_polinomCreatorWithNegativeN_ThrowsException()
        {
            
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = -5, k = 4;

            
            var ex = Assert.ThrowsException<Exception>(
                () => gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k)
            );

            Assert.AreEqual("Недопустимое значение", ex.Message);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNegativeK_ThrowsException()
        {
            
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 7, k = -3;

            
            var ex = Assert.ThrowsException<Exception>(
                () => gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k)
            );

            Assert.AreEqual("Недопустимое значение", ex.Message);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithBothNegative_ThrowsException()
        {
            
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = -7, k = -7;

            var ex = Assert.ThrowsException<Exception>(
                () => gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k)
            );

            Assert.AreEqual("Недопустимое значение", ex.Message);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues1()
        {
            List<int> result = new List<int> { 1,1,2,1,1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 4, k = 2;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues2()
        {
            List<int> result = new List<int> { 1, 1, 2,2,2,1, 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 5, k = 2;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }


        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues3()
        {
            List<int> result = new List<int> { 1, 1, 2,2,3, 2, 2, 1, 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 6, k = 2;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues4()
        {
            List<int> result = new List<int> { 1, 1, 2, 3,3,3, 3,  2, 1, 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 6, k = 3;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues5()
        {
            List<int> result = new List<int> { 1, 1, 2, 2, 3, 3, 3, 2, 2, 1, 1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 7, k = 2;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues6()
        {
            List<int> result = new List<int> { 1,1,2,3,4,4,5,4,4,3,2,1,1 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 7, k = 3;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues7()
        {
            List<int> result = new List<int> {1,1,2,2,3,3,4,3,3,2,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 8, k = 2;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues8()
        {
            List<int> result = new List<int> {1,1,2,3,4,5,6,6,6,6,5,4,3,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 8, k = 3;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues9()
        {
            List<int> result = new List<int> {1,1,2,3,5,5,7,7,8,7,7,5,5,3,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 8, k = 4;
            List<int> list = new List<int>();
           
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }


        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues10()
        {
            List<int> result = new List<int> {1,1,2,2,3,3,4,4,4,3,3,2,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 9, k = 2;
            List<int> list = new List<int>();
           
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues11()
        {
            List<int> result = new List<int> {1,1,2,3,4,5,7,7,8,8,8,7,7,5,4,3,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 9, k = 3;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
            CollectionAssert.AreEqual(list, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues12()
        {
            List<int> result = new List<int> {1,1,2,3,5,6,8,9,11,11,12,11,11,9,8,6,5,3,2};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 9, k = 4;
            List<int> list = new List<int>();
            
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
          
            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues13()
        {
            List<int> result = new List<int> {1,1,2,2,3,3,4,4,5,4,4,3,3,2,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 2;
            List<int> list = new List<int>();
            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues14()
        {
            List<int> result = new List<int> {1,1,2,3,4,5,7,8,9,10,10,10,10,9,8,7,5,4,3};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 3;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }


        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues15()
        {
            List<int> result = new List<int> {1,1,2,3,5,6,9,10,13,14,16,16,18,16,16,14,13,10,9};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 4;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues16()
        {
            List<int> result = new List<int> {1,1,2,3,5,7,9,11,14,16,18,19,20,20,19,18,16,14,11};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 5;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues17()
        {
            List<int> result = new List<int> {1,1,2,2,3,3,4,4,5,5,5,4,4,3,3,2,2,1,1};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 11, k = 2;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues18()
        {
            List<int> result = new List<int> {1,1,2,3,4,5,7,8,10,11,12,12,13,12,12,11,10,8,7};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 11, k = 3;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues19()
        {
            List<int> result = new List<int> {1,1,2,3,5,6,9,11,14,16,19,20,23,23,24,23,23,20,19};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 11, k = 4;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }


        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues20()
        {
            List<int> result = new List<int> { 1, 1, 2, 3, 5, 6, 9, 11, 14, 16, 19, 20, 23, 23, 24, 23, 23, 20, 19 };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 11, k = 4;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues21()
        {
            List<int> result = new List<int> {1,1,2,3,5,7,10,12,16,19,23,25,29,30,32,32,32,30,29};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 11, k = 5;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues22()
        {
            List<int> result = new List<int> {1,1,2,2,3,3,4,4,5,5,6,5,5,4,4,3,3,2,2};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 12, k = 2;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues23()
        {
            List<int> result = new List<int> {1,1,2,3,4,5,7,8,10,12,13,14,15,15,15,15,14,13,12};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 12, k = 3;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues24()
        {
            List<int> result = new List<int> {1,1,2,3,5,6,9,11,15,17,21,23,27,28,31,31,33,31,31};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 12, k = 4;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues25()
        {
            List<int> result = new List<int> {1,1,2,3,5,7,10,13,17,21,26,30,35,39,43,46,48,49,49};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 12, k = 5;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithNormalValues26()
        {
            List<int> result = new List<int> {1,1,2,3,5,7,11,13,18,22,};
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 12, k = 6;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }

        [TestMethod]
        public void Gauss_polinomCreatorWithOnlyOneCoeffs()
        {
            List<int> result = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, };
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            int n = 10, k = 9;
            List<int> list = new List<int>();

            list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);

            List<int> actualPartial = list.GetRange(0, result.Count);

            CollectionAssert.AreEqual(actualPartial, result);
        }
    }
}
