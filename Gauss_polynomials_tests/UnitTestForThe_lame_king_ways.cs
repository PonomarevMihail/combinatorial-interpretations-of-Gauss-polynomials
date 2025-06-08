using Gauss_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Test_Of_Kursach
{
    [TestClass]
    public class UnitTestForThe_lame_king_ways
    {
        public void The_lame_king_waysNegativeSize1()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 10;
            int size_of_ones = -7;
            int size_of_twos = n - size_of_ones;

            int required_quantity = 0;



            var ex = Assert.ThrowsException<Exception>(() => tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }
        [TestMethod]
        public void The_lame_king_waysNegativeSize2()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = -10;
            int size_of_ones = 7;
            int size_of_twos = n - size_of_ones;

            int required_quantity = 0;



            var ex = Assert.ThrowsException<Exception>(() => tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }
        [TestMethod]
        public void The_lame_king_waysNegativeSize3()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 5;
            int size_of_ones = 8;
            int size_of_twos = n - size_of_ones;

            int required_quantity = 0;



            var ex = Assert.ThrowsException<Exception>(() => tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }


        [TestMethod]
        public void The_lame_king_waysNegativeRequired_quantity()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 15;
            int size_of_ones = 7;
            int size_of_twos = n - size_of_ones;

            int required_quantity = -10;
            tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos);

            List<List<int>> list_of_inversions = new List<List<int>>();


            var ex = Assert.ThrowsException<Exception>(() => (list_of_inversions) = tlk1.Count_of_steps_lame_king(required_quantity));
            Assert.AreEqual("Недопустимое значение", ex.Message);
        }


        [TestMethod]
        public void The_lame_king_ways_Create1_With_0_Inversions()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 5;
            int size_of_ones = 2;
            int size_of_twos = n - size_of_ones;
            int required_quantity = 0;
            List<List<int>> list_of_inversions = new List<List<int>>();

            tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos);
            list_of_inversions = tlk1.Count_of_steps_lame_king(required_quantity);



            List<List<int>> answer = new List<List<int>> {
                new List<int> { 1, 1, 2, 2, 2 }
            };

            for (int i = 0; i < answer.Count; i++)
            {
                CollectionAssert.AreEqual(answer[i], list_of_inversions[i]);
            }

        }

        [TestMethod]
        public void The_lame_king_ways_Create2_With_Max_Coeff_Gauss_Polinom()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 7;
            int size_of_ones = 4;
            int size_of_twos = n - size_of_ones;
            int required_quantity = size_of_ones * size_of_twos;
            List<List<int>> list_of_inversions = new List<List<int>>();
            tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos);
            list_of_inversions = tlk1.Count_of_steps_lame_king(required_quantity);

            List<List<int>> answer = new List<List<int>> {
                new List<int> { 2, 2, 2, 1, 1,1,1 }
            };

            for (int i = 0; i < answer.Count; i++)
            {
                CollectionAssert.AreEqual(answer[i], list_of_inversions[i]);
            }

        }

        [TestMethod]
        public void The_lame_king_ways_UniquePermutations()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 11;
            int size_of_ones = 5;
            int size_of_twos = 6;
            tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos);

            int required_quantity = 12;

            var results = tlk1.Count_of_steps_lame_king(required_quantity);

            HashSet<string> seen = new HashSet<string>();

            foreach (var perm in results)
            {
                string key = string.Join(",", perm);
                Assert.IsFalse(seen.Contains(key));
                seen.Add(key);
            }
        }

        [TestMethod]
        public void The_lame_king_ways_TooManyInversions()
        {
            The_lame_king tlk1 = new The_lame_king();
            int n = 5;
            int size_of_ones = 2;
            int size_of_twos = 3;
            tlk1.Determining_the_size_of_the_list(n, size_of_ones, size_of_twos);

            int required_quantity = 100; 

            var ex = Assert.ThrowsException<Exception>(() => tlk1.Count_of_steps_lame_king(required_quantity));
            Assert.AreEqual("Слишком большое значение количества инверсий", ex.Message);
        }
    }
}
