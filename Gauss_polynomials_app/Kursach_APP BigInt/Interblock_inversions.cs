using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
namespace Gauss_1
{
    internal class Interblock_inversions
    {
        private int size;
        private int size_int_1;
        private int size_int_2;
        private List<int> interversions = new List<int>();
        private List<int> interversions1 = new List<int>();
        private List<int> interversions2 = new List<int>();

        public static string GetElementForm(int number)
        {
            int n = Math.Abs(number % 100);
            int lastDigit = n % 10;

            string form = (n >= 11 && n <= 14)
                ? "элементов"
                : new[] { "элементов", "элемент", "элемента", "элемента", "элемента", "элементов", "элементов", "элементов", "элементов", "элементов" }[lastDigit];

            return $"{number} {form}";
        }

        //Тасование Фишера-Йетса.
        private static readonly Random _rand = new Random();
        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = _rand.Next(n + 1);
                (list[k], list[n]) = (list[n], list[k]);
            }
        }

        public int GetSizeIntOne()
        {
            return size_int_1;
        }

        public void Determining_the_size_of_the_list(int input, int firstBlockSize,int secondBlockSize)
        {
          size = input;
          size_int_1 = firstBlockSize;
          size_int_2 = secondBlockSize;
        }

        public void Create_blocks()
        {
            interversions1.Clear(); 
            for (int i = 0; i < size; i++)
            {
                interversions1.Add(i + 1);
            }
            Shuffle(interversions1);
        }


        public (List<int>, List<int>) sorting(List<int> list1, List<int> list2, List<int> common_vector) 
        {
            Shuffle(common_vector);
            list1.Clear();
            list2.Clear();

            for (int i = 0; i < size_int_1; i++)
            {
                list1.Add(common_vector[i]);
            }
            for (int j = 0; j < size_int_2; j++)
            {
                list2.Add(common_vector[j + size_int_1]);
            }
            return (list1,list2);

        }


        public (List<List<int>>, List<List<string>>) Count_of_inversions(int required_quantity)
        {
            List<List<int>> vector_of_interversions_combination = new List<List<int>>();
            List<List<string>> vector_of_mini_interversions_combination = new List<List<string>>();

            
            HashSet<string> uniquePermutations = new HashSet<string>();
            HashSet<string> uniqueBlock1 = new HashSet<string>();
            Gauss_polinom gauss_Polinom = new Gauss_polinom();

            List<int> common_vector = new List<int>();
            for(int i = 0; i < size_int_1 + size_int_2; i++)
            {
                common_vector.Add(i + 1);
            }


            if(required_quantity == 0)
            {
                vector_of_interversions_combination.Add(common_vector);
                return (vector_of_interversions_combination,null);
            }



            
            List<long> result = new List<long>();

            if (size_int_1 + size_int_2 < 25)
            {
                result = gauss_Polinom.recursion_way_for_fing_coeff(size_int_1 + size_int_2, size_int_1);
            }
            else
            {
                result = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(size_int_1 + size_int_2, size_int_1);
            }

            long the_number_of_possible_permutations_with_k_inversions = result[required_quantity];
            



            List<string> inversions_on_result = new List<string>();

            long temp_of_count_interversions_all_types = 0;
            int imp = 0;

            while (temp_of_count_interversions_all_types < the_number_of_possible_permutations_with_k_inversions)
            {

                List<int> sort_vector = new List<int>(common_vector);

                (interversions1,interversions2) = sorting(interversions1, interversions2, sort_vector);

                long count_inversions = 0;
                string mini_interversion = "";

                List<string> vector_of_mini_interversions = new List<string>();
                for (int i = 0; i < size_int_1; i++)
                {
                    for (int j = 0; j < size_int_2; j++)
                    {
                        if (interversions1[i] > interversions2[j])
                        {
                            count_inversions++;
                            mini_interversion = interversions1[i].ToString() + "," + interversions2[j].ToString();
                            vector_of_mini_interversions.Add(mini_interversion);

                        }
                    }
                    if (count_inversions > required_quantity)
                    {
                        break;
                    }
                }

                if (count_inversions == required_quantity)
                {
                   string hashKey = string.Join(",", sort_vector);

                   List<int> temp_1 = interversions1;
                   temp_1.Sort();

                   string block1Key = string.Join(",", temp_1);

                    if (uniquePermutations.Contains(hashKey) || uniqueBlock1.Contains(block1Key))
                        continue;

                    uniquePermutations.Add(hashKey);
                    uniqueBlock1.Add(block1Key);

                    vector_of_interversions_combination.Add(new List<int>(sort_vector));
                    vector_of_mini_interversions_combination.Add(vector_of_mini_interversions);

                    
                    temp_of_count_interversions_all_types++;
                }
            }

            return (vector_of_interversions_combination, vector_of_mini_interversions_combination);
        }

        public void Print()
        {
            foreach(int i in interversions1) Console.WriteLine(i);
        }
    }
}
