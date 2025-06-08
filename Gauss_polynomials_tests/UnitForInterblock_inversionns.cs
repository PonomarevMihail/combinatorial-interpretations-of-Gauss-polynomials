using Gauss_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_Of_Kursach
{
    [TestClass]
    public class UnitForInterblock_inversionns
    {
        [TestMethod]
        public void Interblock_inversionsNegativeSize1()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = 10;
            int size_of_first_block = -7;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = 0;
            var ex = Assert.ThrowsException<Exception>(() => inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }
        [TestMethod]
        public void Interblock_inversionsNegativeSize2()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = -10;
            int size_of_first_block = 7;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = 0;
            var ex = Assert.ThrowsException<Exception>(() => inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }
        [TestMethod]
        public void Interblock_inversionsNegativeSize3()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = 5;
            int size_of_first_block = 8;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = 0;



            var ex = Assert.ThrowsException<Exception>(() => inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block));

            Assert.AreEqual("Недопустимое значение", ex.Message);


        }


        [TestMethod]
        public void Interblock_inversionsNegativeRequired_quantity()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = 15;
            int size_of_first_block = 7;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = -10;
            inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block);

            List<List<int>> list_of_inversions = new List<List<int>>();
            List<List<string>> list_of_mini_inversions = new List<List<string>>();

            var ex = Assert.ThrowsException<Exception>(() => (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity));
            Assert.AreEqual("Недопустимое значение", ex.Message);
        }


        [TestMethod]
        public void Interblock_inversionsWithRequired_quantity0()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = 15;
            int size_of_first_block = 7;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = 0;
            inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block);


            List<List<int>> list_of_inversions = new List<List<int>>();
            List<List<string>> list_of_mini_inversions = new List<List<string>>();

            List<List<int>> answer = new List<List<int>> { 
            new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15}
            };


            (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            for (int i = 0; i < list_of_inversions.Count; i++)
            {
                CollectionAssert.AreEqual(list_of_inversions[i], answer[i]);
               
            }


        }


        [TestMethod]
        public void Interblock_inversionsNegativeRequired_quantityMaxDegree()
        {
            Interblock_inversions inv = new Interblock_inversions();
            int n = 15;
            int size_of_first_block = 7;
            int size_of_second_block = n - size_of_first_block;

            int required_quantity = size_of_first_block*(n- size_of_first_block);
            inv.Determining_the_size_of_the_list(n, size_of_first_block, size_of_second_block);

            List<List<int>> list_of_inversions = new List<List<int>>();
            List<List<string>> list_of_mini_inversions = new List<List<string>>();

            List<List<int>> answer = new List<List<int>> {
            new List<int> {11,10,12,9,14,15,13}
            };

           
            (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
               .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
               .ToList();
            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            answer = answer
            .Select(l => l.OrderBy(x => x).ToList())
            .OrderBy(l => string.Join(",", l))
            .ToList();

            for (int i = 0; i < answer.Count; i++)
            {
                CollectionAssert.AreEqual(actualFirstBlockInversions[i], answer[i]);

            }


        }




        [TestMethod]
        public void Interblock_inversionsCreate1()
        {
            var inv = new Interblock_inversions();
            int n = 5;
            int size_of_first_block = 3;
            int required_quantity = 3;

            inv.Determining_the_size_of_the_list(n, size_of_first_block, n - size_of_first_block);

            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
                .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
                .ToList();

            var expectedFirstBlocks = new List<List<int>>
            {
                new List<int> {1,3,5},
                new List<int> {2,3,4}
            };

            var expectedMiniInversions = new List<List<string>>
            {
                new List<string> { "3,2", "5,2", "5,4" },
                new List<string> { "2,1", "3,1", "4,1" }
            };

            // Сортируем всё лексикографически
            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            expectedFirstBlocks = expectedFirstBlocks.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(",", l)).ToList();

            list_of_mini_inversions = list_of_mini_inversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();
            expectedMiniInversions = expectedMiniInversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();

            for (int i = 0; i < expectedFirstBlocks.Count; i++)
            {
                CollectionAssert.AreEqual(expectedFirstBlocks[i], actualFirstBlockInversions[i], $"Ошибка в блоке {i}");
                CollectionAssert.AreEqual(expectedMiniInversions[i], list_of_mini_inversions[i], $"Ошибка в мини-инверсиях {i}");
            }
        }


        [TestMethod]
        public void Interblock_inversionsCreate2()
        {
            var inv = new Interblock_inversions();
            int n = 8;
            int size_of_first_block = 4;
            int required_quantity = 4;

            inv.Determining_the_size_of_the_list(n, size_of_first_block, n - size_of_first_block);

            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
                .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
                .ToList();

            var expectedFirstBlocks = new List<List<int>>
            {
                new List<int> { 1, 4, 7,2},
                new List<int> {1,2,3,8},
                new List<int> {1,3,4,6},
                new List<int> {2,3,4,5},
                new List<int> { 1,2,6,5}
            };

            var expectedMiniInversions = new List<List<string>>
            {
                new List<string> {"4,3","7,3","7,6","7,5"},
                new List<string> {"8,6","8,5", "8,4","8,7"},
                new List<string> {"3,2","4,2", "6,2","6,5"},
                new List<string> {"3,1","5,1","2,1","4,1"},
                new List<string> {"6,3","6,4","5,3","5,4"}
            };


            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            expectedFirstBlocks = expectedFirstBlocks.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(",", l)).ToList();

            list_of_mini_inversions = list_of_mini_inversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();
            expectedMiniInversions = expectedMiniInversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();

            for (int i = 0; i < expectedFirstBlocks.Count; i++)
            {
                CollectionAssert.AreEqual(expectedFirstBlocks[i], actualFirstBlockInversions[i], $"Ошибка в блоке {i}");
                CollectionAssert.AreEqual(expectedMiniInversions[i], list_of_mini_inversions[i], $"Ошибка в мини-инверсиях {i}");
            }
        }

        [TestMethod]
        public void Interblock_inversionsCreate3()
        {
            var inv = new Interblock_inversions();
            int n = 10;
            int size_of_first_block = 6;
            int required_quantity = 5;

            inv.Determining_the_size_of_the_list(n, size_of_first_block, n - size_of_first_block);

            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
                .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
                .ToList();

            var expectedFirstBlocks = new List<List<int>>
            {
                new List<int> {1,2,4,6,5,8},
                new List<int> {6,2,3,10,1,4},
                new List<int> {1,2,3,5,7,8},
                new List<int> {4,2,7,3,9,1},
                new List<int> {5,1,6,9,2,3},
                new List<int> {7,5,6,4,3,1}
            };

            var expectedMiniInversions = new List<List<string>>
            {
                new List<string> {"4,3","6,3","5,3", "8,7","8,3"},
                new List<string> {"6,5","10,8","10,9","10,7","10,5"},
                new List<string> {"5,4","8,4","8,6","7,4","7,6"},
                new List<string> {"7,5","7,6","9,5","9,6","9,8"},
                new List<string> {"5,4","6,4","9,8","9,7","9,4"},
                new List<string> {"7,2","5,2","6,2","4,2","3,2"}
            };


            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            expectedFirstBlocks = expectedFirstBlocks.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(",", l)).ToList();

            list_of_mini_inversions = list_of_mini_inversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();
            expectedMiniInversions = expectedMiniInversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();

            for (int i = 0; i < expectedFirstBlocks.Count; i++)
            {
                CollectionAssert.AreEqual(expectedFirstBlocks[i], actualFirstBlockInversions[i], $"Ошибка в блоке {i}");
                CollectionAssert.AreEqual(expectedMiniInversions[i], list_of_mini_inversions[i], $"Ошибка в мини-инверсиях {i}");
            }
        }

        [TestMethod]
        public void Interblock_inversionsCreate4()
        {
            var inv = new Interblock_inversions();
            int n = 11;
            int size_of_first_block = 8;
            int required_quantity = 5;

            inv.Determining_the_size_of_the_list(n, size_of_first_block, n - size_of_first_block);

            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
                .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
                .ToList();

            var expectedFirstBlocks = new List<List<int>>
            {
                new List<int> {2,6,1,3,5,7,9,8},
                new List<int> {9,6,4,2,1,11,5,3},
                new List<int> {5,3,7,1,11,2,4,8},
                new List<int> {3,4,8,6,7,2,10,1},
                new List<int> {2,5,10,4,9,3,1,7}
            };

            var expectedMiniInversions = new List<List<string>>
            {
                new List<string> {"6,4","5,4","7,4","9,4","8,4"},
                new List<string> {"9,8","9,7","11,8","11,7","11,10"},
                new List<string> {"7,6","11,9","11,10","11,6","8,6"},
                new List<string> {"8,5","6,5","7,5","10,5","10,9"},
                new List<string> {"10,6", "10,8", "9,6", "9,8", "7,6"}
            };

            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            expectedFirstBlocks = expectedFirstBlocks.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(",", l)).ToList();

            list_of_mini_inversions = list_of_mini_inversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();
            expectedMiniInversions = expectedMiniInversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();

            for (int i = 0; i < expectedFirstBlocks.Count; i++)
            {
                CollectionAssert.AreEqual(expectedFirstBlocks[i], actualFirstBlockInversions[i], $"Ошибка в блоке {i}");
                CollectionAssert.AreEqual(expectedMiniInversions[i], list_of_mini_inversions[i], $"Ошибка в мини-инверсиях {i}");
            }
        }


        [TestMethod]
        public void Interblock_inversionsCreate5()
        {
            var inv = new Interblock_inversions();
            int n = 11;
            int size_of_first_block = 8;
            int required_quantity = 6;

            inv.Determining_the_size_of_the_list(n, size_of_first_block, n - size_of_first_block);

            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            var actualFirstBlockInversions = list_of_inversions
                .Select(tmp => tmp.GetRange(0, size_of_first_block).OrderBy(x => x).ToList())
                .ToList();

            var expectedFirstBlocks = new List<List<int>>
            {
               new List<int> {7,2,9,1,5,4,3,11},
               new List<int> {10,6,2,3,1,5,11,4},
               new List<int> {9,3,10,2,1,5,8,4},
               new List<int> {2,7,5,1,10,8,3,6},
               new List<int> {1,10,9,2,7,4,3,6},
               new List<int> {2,11,7,1,4,8,3,6},
               new List<int> {7,9,1,6,4,2,8,5}
            };

            var expectedMiniInversions = new List<List<string>>
            {
                new List<string> {"7,6","9,6","9,8","11,10","11,6","11,8"},
                new List<string> {"10,8","10,7","10,9","11,8","11,7","11,9"},
                new List<string> {"9,6","9,7","10,6","10,7","8,6","8,7" },
                new List<string> {"7,4","5,4","10,9","10,4","8,4","6,4" },
                new List<string> {"10,8","10,5","9,8","9,5","7,5","6,5" },
                new List<string> {"11,5", "11,10", "11,9", "7,5", "8,5", "6,5"},
                new List<string> {"7,3", "9,3", "6,3", "4,3", "8,3", "5,3"},

            };

            actualFirstBlockInversions = actualFirstBlockInversions.OrderBy(l => string.Join(",", l)).ToList();
            expectedFirstBlocks = expectedFirstBlocks.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(",", l)).ToList();

            list_of_mini_inversions = list_of_mini_inversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();
            expectedMiniInversions = expectedMiniInversions.Select(l => l.OrderBy(x => x).ToList()).OrderBy(l => string.Join(";", l)).ToList();

            for (int i = 0; i < expectedFirstBlocks.Count; i++)
            {
                CollectionAssert.AreEqual(expectedFirstBlocks[i], actualFirstBlockInversions[i], $"Ошибка в блоке {i}");
                CollectionAssert.AreEqual(expectedMiniInversions[i], list_of_mini_inversions[i], $"Ошибка в мини-инверсиях {i}");
            }
        }

        [TestMethod]
        public void Interblock_inversionsInvalidRequiredQuantity_TooLarge_ShouldThrow()
        {
            var inv = new Interblock_inversions();
            inv.Determining_the_size_of_the_list(6, 4, 2);

            // максимум возможных инверсий 4*2 = 8
            var ex = Assert.ThrowsException<Exception>(() => inv.Count_of_inversions(10));
            Assert.AreEqual("Слишком большое значение количества инверсий", ex.Message);
        }

        [TestMethod]
        public void Interblock_inversionsNoDuplicatePermutations()
        {
            var inv = new Interblock_inversions();
            inv.Determining_the_size_of_the_list(6, 3, 3);

            var (list, _) = inv.Count_of_inversions(3);

            var unique = new HashSet<string>(list.Select(l => string.Join(",", l)));
            Assert.AreEqual(list.Count, unique.Count, "Найдены повторяющиеся перестановки");
        }

        [TestMethod]
        public void Interblock_inversionsTestEachSolutionHasCorrectInversionCount()
        {
            var inv = new Interblock_inversions();
            int n = 4;
            int k = 3;
            inv.Determining_the_size_of_the_list(n, k, n-k);
            int required_quantity = 3;
            var (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);

            Assert.AreEqual(1, list_of_inversions.Count);
        }



    }

}
