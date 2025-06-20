﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Gauss_1
{
    internal class The_lame_king
    {


        private List<int> multiset = new List<int>();
        private int size_list_for_units = 0;
        private int size_list_for_twos = 0;
        private int size_multiset = 0;


        public int GetSize_list_for_units()
        {
            return size_list_for_units;
        }

        public int GetSize_list_for_twos()
        {
            return size_list_for_twos;
        }


        public void Determining_the_size_of_the_list(int n, int k, int size2)
        {
            if (n < 0 || k < 0 || size2 < 0)
            {
                throw new Exception("Недопустимое значение");
            }

            size_multiset = n;


            size_list_for_units = k;

            size_list_for_twos = n - k;


        }

        public List<int> initialization_muliset()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < size_list_for_units; i++)
            {
                result.Add(1);
            }
            for (int y = 0; y < size_list_for_twos; y++)
            {
                result.Add(2);
            }
            return result;
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


        public void Print_answer(List<int> coefficient)
        {
            string answer = "";
            answer += coefficient[0] * 1 + " ";

            for (int i = 1; i < coefficient.Count; i++)
            {
                if (coefficient[i] != 0)
                {
                    if (coefficient[i] == -1)
                    {
                        answer += "q^" + i + " ";
                    }
                    else if (coefficient[i] == 1)
                    {
                        answer += "+ " + "q^" + i + " ";
                    }
                    else
                    {
                        if (coefficient[i] < 0)
                        {
                            answer += "- " + Math.Abs(coefficient[i]) + "q^" + i + " ";
                        }
                        else
                        {
                            answer += "+ " + coefficient[i] + "q^" + i + " ";
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }

        public List<int> GetPolinomGauss()
        {
            Gauss_polinom gauss_Polinom = new Gauss_polinom();
            List<int> coeff_of_Gauss = new List<int>();
            if (size_multiset < 50)
            {

                coeff_of_Gauss = gauss_Polinom.recursion_way_for_fing_coeff(size_list_for_units + size_list_for_twos, size_list_for_units);
            }
            else
            {

                coeff_of_Gauss = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(size_list_for_units + size_list_for_twos, size_list_for_units);
            }

            return coeff_of_Gauss;
        }


        public List<List<int>> Count_of_steps_lame_king(int required_quantity)
        {
            if (required_quantity < 0)
            {
                throw new Exception("Недопустимое значение");
            }
            if (required_quantity > size_list_for_units * (size_multiset - size_list_for_units))
            {
                throw new Exception("Слишком большое значение количества инверсий");
            }

            List<List<int>> vector_of_steps_lame_king = new List<List<int>>();
            multiset = initialization_muliset();
            HashSet<string> uniquePermutations = new HashSet<string>();

            if (required_quantity == 0)
            {
                vector_of_steps_lame_king.Add(multiset);
                return (vector_of_steps_lame_king);
            }


            List<int> coeff_of_gaus = GetPolinomGauss();

            int targetCount = coeff_of_gaus[required_quantity];
            int temp_steps = 0;
            Random rand = new Random();


            while (temp_steps < targetCount)
            {



                List<int> shuffled = new List<int>(multiset);

                for (int i = shuffled.Count - 1; i > 0; i--)
                {
                    int j = rand.Next(i + 1);
                    int temp = shuffled[i];
                    shuffled[i] = shuffled[j];
                    shuffled[j] = temp;
                }


                int inversions = 0;
                for (int i = 0; i < shuffled.Count; i++)
                {
                    for (int j = i + 1; j < shuffled.Count; j++)
                    {
                        if (shuffled[i] > shuffled[j]) inversions++;
                    }
                    if (inversions > required_quantity)
                    {
                        break;
                    }
                }


                string hash = string.Join(",", shuffled);
                if (inversions == required_quantity && !uniquePermutations.Contains(hash))
                {
                    uniquePermutations.Add(hash);
                    vector_of_steps_lame_king.Add(new List<int>(shuffled));
                    temp_steps++;
                }
            }

            return vector_of_steps_lame_king;
        }

        public List<string> VisualizePath(List<int> permutation)
        {

            List<string> WayOfLameKing = new List<string>();

            int width = size_list_for_units + 1;  // Ширина таблицы (столбцы)
            int height = size_list_for_twos + 1;  // Высота таблицы (строки)

            string[,] grid = new string[height, width];

            // Инициализация сетки
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[y, x] = " . ";
                }
            }

            // Начальная позиция (правый верхний угол)
            int currentX = size_list_for_units;
            int currentY = 0;
            grid[currentY, currentX] = "S";  // Начало

            // Обработка шагов
            foreach (int step in permutation)
            {
                // Обновление координат
                if (step == 1)
                {
                    currentX--;
                }
                else if (step == 2)
                {
                    currentY++;
                }

                // Проверка границ
                if (currentX < 0 || currentY >= height)
                {
                    Console.WriteLine("Выход за границы таблицы!");
                    break;
                }

                // Отметка текущей позиции
                grid[currentY, currentX] = "X";
            }

            // Отметка конечной точки
            grid[currentY, currentX] = "E";

            string temp = "";

            // Вывод таблицы
            WayOfLameKing.Add("\nМаршрут:");
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    temp += grid[y, x] + " ";
                }
                WayOfLameKing.Add(temp);
                temp = "";
            }

            return WayOfLameKing;


        }


    }
}
