using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gauss_1
{
    public class Gauss_polinom
    {
        private int n, k;

        private List<string> the_numerator = new List<string>();
        private List<string> the_denominator = new List<string>();

        private List<int> coeff_the_numerator_total = new List<int>();
        private List<int> coeff_the_denominator_total = new List<int>();

        public void Result_coeff_the_num_total()
        {
            
           

                List<int> Total_coef = new List<int> { 1 };

                foreach (string s in the_numerator)
                {
                    Total_coef = MultiplyPolynomial(s, Total_coef);
                }

                coeff_the_numerator_total = Total_coef;
            
        }



        public void Result_coeff_the_den_total()
        {
           

                List<int> Total_coef = new List<int> { 1 };

                foreach (string s in the_denominator)
                {
                    Total_coef = MultiplyPolynomial(s, Total_coef);
                }

                coeff_the_denominator_total = Total_coef;
            
        }

        public void Print_coeff(List<int> coefficient)
        {
            string answer = "";
            answer += coefficient[0] * 1 + " ";

            for (int i = 1; i < coefficient.Count; i++)
            {
                if (coefficient[i] != 0)
                {
                    if (coefficient[i] == -1)
                    {
                        answer +=  "q^" + i + " ";
                    }
                    else if(coefficient[i] == 1)
                    {
                        answer += "+" + "q^" + i + " ";
                    }
                    else
                    {
                        answer += coefficient[i] + "q^" + i + " ";
                    }
                }
            }
            Console.WriteLine(answer);
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
                        answer +=  "q^" + i + " ";
                    }
                    else if (coefficient[i] == 1)
                    {
                        answer += "+ " + "q^" + i + " ";
                    }
                    else
                    {
                        if (coefficient[i] < 0)
                        {
                            answer += "- "  + Math.Abs(coefficient[i]) + "q^" + i + " ";
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



        public List<string> Get_the_numerator()
        {
            return the_numerator;
        }

        public List<string> Get_the_denominator()
        {
            return the_denominator;
        }


        public void CreateNumeratorAndDenominator()
        {
            the_numerator.Clear();
            the_denominator.Clear();
           
                // Числитель: (1 - q^n)(1 - q^{n-1})...(1 - q^{n-k+1})
                the_numerator = Create_polinom(n, n - k + 1);

                // Знаменатель: (1 - q^k)(1 - q^k-1)...(1 - q^1)
                the_denominator = Create_polinom(k, 1);
            
           
        }

        public void CreateNumeratorAndDenominator(int n, int k)
        {
            the_numerator.Clear();
            the_denominator.Clear();

            // Числитель: (1 - q^n)(1 - q^{n-1})...(1 - q^{n-k+1})
            the_numerator = Create_polinom(n, n - k + 1);

            // Знаменатель: (1 - q)(1 - q^2)...(1 - q^k)
            the_denominator = Create_polinom(k, 1);


        }

        public void PrintPolinom()
        {
           
            Console.WriteLine("\nМногочлен Гаусса:");
            Console.WriteLine($"Числитель: {string.Join(" * ", the_numerator)}");

            Console.WriteLine($"Знаменатель: {string.Join(" * ", the_denominator)}");
        }

  
        public void SimplfyTerms()
        {
            if (the_numerator.SequenceEqual(the_denominator))
            {
                the_numerator.Clear();
                the_denominator.Clear();
                the_numerator.Add("1");
                the_denominator.Add("1");
                return;
            }

            var newNumerator = new List<string>(the_numerator);
            var newDenominator = new List<string>(the_denominator);

           
                // Помечаем элементы для удаления
                bool[] markedNum = new bool[newNumerator.Count];
                bool[] markedDen = new bool[newDenominator.Count];

                for (int i = 0; i < newNumerator.Count; i++)
                {
                    for (int j = 0; j < newDenominator.Count; j++)
                    {
                        //Проверка, что элемент знаменателя еще не помечен для удаления
                        if (!markedDen[j] && newNumerator[i] == newDenominator[j])
                        {
                            markedNum[i] = true;
                            markedDen[j] = true;
                            break;
                        }
                    }
                }


                for (int i = newNumerator.Count - 1; i >= 0; i--)
                {
                    if (markedNum[i]) newNumerator.RemoveAt(i);
                }

                for (int j = newDenominator.Count - 1; j >= 0; j--)
                {
                    if (markedDen[j]) newDenominator.RemoveAt(j);
                }


            if (newNumerator.Count() == 0 && newDenominator.Count() == 0)
            {
                newNumerator.Add("1");
                newDenominator.Add("1");
            }

            the_numerator = newNumerator;
            the_denominator = newDenominator;
            

        }

        public List<string> Create_polinom(int start, int end)
        {
            var terms = new List<string>();

            
            for (int i = start; i >= end; i--)
            {
                terms.Add($"(1 - q^{i})");
            }
            return terms.Count > 0 ? terms : new List<string> { "1" };
        }

        public (List<int>, List<int>) Divide()
        {
            coeff_the_numerator_total = RemoveLeadingZeros(coeff_the_numerator_total);
            coeff_the_denominator_total = RemoveLeadingZeros(coeff_the_denominator_total);

            if (coeff_the_denominator_total.Count == 0 || coeff_the_denominator_total.All(x => x == 0))
                throw new DivideByZeroException("Знаменатель не может быть нулевым.");

            if (coeff_the_denominator_total.Count == 1 && coeff_the_denominator_total[0] == 1)
            {
                return (new List<int>(coeff_the_numerator_total), new List<int>());
            }

            if (coeff_the_numerator_total.Count < coeff_the_denominator_total.Count)
                return (new List<int> { 0 }, new List<int>(coeff_the_numerator_total));

            List<int> quotient = new List<int>();
            List<int> remainder = new List<int>(coeff_the_numerator_total);

            while (remainder.Count >= coeff_the_denominator_total.Count)
            {
                int coef = remainder[0] / coeff_the_denominator_total[0];
                quotient.Add(coef);

                List<int> temp = new List<int>(coeff_the_denominator_total);
                for (int i = 0; i < temp.Count; i++)
                    temp[i] *= coef;

                int shift = remainder.Count - coeff_the_denominator_total.Count;
                for (int i = 0; i < shift; i++)
                    temp.Add(0);

                for (int i = 0; i < remainder.Count; i++)
                    remainder[i] -= temp[i];

                remainder = RemoveLeadingZeros(remainder);
            }

            return (quotient, remainder);
        }

        // Удаляет ведущие нули из списка коэффициентов
        private List<int> RemoveLeadingZeros(List<int> coefficients)
        {
            int firstNonZero = coefficients.FindIndex(x => x != 0);
            if (firstNonZero == -1)
                return new List<int> { 0 };
            return coefficients.Skip(firstNonZero).ToList();
        }


        public List<int> MultiplyPolynomial(string vector, List<int> Total_koef)
        {
            // Обработка случая с "1"
            if (vector.Trim() == "1")
                return Total_koef;

            // Исправленный парсинг
            string cleaned = vector.Replace(" ", "").Replace("(", "").Replace(")", "");
            int qIndex = cleaned.IndexOf("q^", StringComparison.OrdinalIgnoreCase);

            if (qIndex == -1 && cleaned == "1")
                return Total_koef;

            if (qIndex == -1)
                throw new ArgumentException("Некорректный формат полинома: " + vector);

            // Используем регулярные выражения для парсинга
            var match = Regex.Match(
                vector,
                @"\(1\s*-\s*q\^(\d+)\)",
                RegexOptions.IgnoreCase
            );

            if (!match.Success)
            {
                throw new ArgumentException("Некорректный формат полинома: " + vector);
            }

            // Извлекаем числовое значение степени
            int exponent = int.Parse(match.Groups[1].Value);

            // Создаем полином (1 - q^exponent)
            List<int> polynomial = new List<int>(new int[exponent + 1]);
            polynomial[0] = 1;          // q^0 коэффициент
            polynomial[exponent] = -1;  // q^exponent коэффициент

            return MultiplyPolynomial(polynomial, Total_koef);
        }

        public List<int> MultiplyPolynomial(List<int> vector, List<int> Total_koef)
        {
            int resultSize = vector.Count + Total_koef.Count - 1;
            var result = new List<int>(new int[resultSize]);

            // Умножение многочленов
            for (int i = 0; i < Total_koef.Count; i++)
            {
                for (int j = 0; j < vector.Count; j++)
                {
                    result[i + j] += Total_koef[i] * vector[j];
                }
            }

            return RemoveLeadingZeros(result);
        }



        public void Print_condition(ref int temp1, ref int temp2)
        {

           
            bool tmp_checker_for_n = false;

            while (!tmp_checker_for_n)
            {
                Console.WriteLine("Введите значение n: ");
                Console.Write("n = ");
                temp1 = int.Parse(Console.ReadLine()); // Преобразуем строку в число
                if(temp1 >= 0)
                {
                    tmp_checker_for_n = true;
                }
            }
            n = temp1;

            bool tmp_checker_for_k = false;
            while (!tmp_checker_for_k)
            {
                Console.WriteLine("Введите значение k: ");
                Console.Write("k = ");
                temp2 = int.Parse(Console.ReadLine());
                if (temp2 >= 0)
                {
                    tmp_checker_for_k = true;
                }
            }
            k = temp2;
        }

        public List<int> A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(int temp1 , int temp2)
         {
          
            // Получаем параметры от пользователя
            

            if (temp2 == temp1 && temp1 > 0)
            {
                List<int> result = new List<int>();
                result.Add(1);
                return result;
            }
            
            else if (temp1 <= 0 || temp2 <= 0)
            {
                throw new Exception("Недопустимое значение");
                return  new List<int>();
            }

            else if (temp2 > temp1)
            {
                List<int> result = new List<int>();
                result.Add(0);
                return result;
            }

            else
            {
                // Создаем числитель и знаменатель
                CreateNumeratorAndDenominator(temp1, temp2);

                SimplfyTerms();
                // Выводим результат

                

                Result_coeff_the_num_total();
                Result_coeff_the_den_total();

                List<int> quotient;

                List<int> remainder;

                (quotient, remainder) = Divide();

                return quotient;
            }

        }
        public List<int> addition_polinoms(List<int> coeff1, List<int> coeff2)
        {
            int maxLength = Math.Max(coeff1.Count, coeff2.Count);
            List<int> result = new List<int>(new int[maxLength]);

            for(int i = 0; i < coeff1.Count();i++)
            {
                result[i] += coeff1[i];
            }

            for(int j = 0; j < coeff2.Count(); j++)
            {
                result[j] += coeff2[j];
            }
            

            return result;
        }

        public List<int> MultiplyByQPower(List<int> polynomial, int power)
        {
            var result = new List<int>(new int[power]);
            result.AddRange(polynomial);
            return result;
        }

        public List<int> recursion_way_for_fing_coeff(int temp1, int temp2)
        {
            if (temp2 == 0 || temp2 == temp1)
            {
                List<int> result = new List<int>();
                result.Add(1);
                return result;
            }
            if (temp2 < 0 || temp2 > temp1)
            {
                List<int> result = new List<int>();
                result.Add(0);
                return result;
            }


            var term1 = recursion_way_for_fing_coeff(temp1 - 1, temp2 - 1);
            var term2 = MultiplyByQPower(recursion_way_for_fing_coeff(temp1 - 1, temp2), temp2);

            return addition_polinoms(term1, term2);


        }

        

    }
}