using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gauss_1;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursach_APP
{
    public partial class Kursach : Form
    {
        public Kursach()
        {
            InitializeComponent();
        }

        public int GetN()
        {
            return int.Parse(InputN.Text);
        }

        public int GetK()
        {
            return int.Parse(InputK.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if ((int.TryParse(InputN.Text, out int n) && int.Parse(InputN.Text) >= 0) && (int.TryParse(InputK.Text, out int k) && int.Parse(InputK.Text) >= 0))
            {
                Gauss_polinom gauss_Polinom = new Gauss_polinom();
                List<long> list = new List<long>();
                List<long> list2 = new List<long>();

                if (n + k > 40)
                {

                    list = gauss_Polinom.A_simple_way_to_find_the_coefficients_of_a_Gauss_polynomial(n, k);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < 0)
                        {
                            MessageBox.Show("Программа может содержать отрицательные коэффициенты при больших степенях, это связано с переполнением типа данных long");
                            break;
                        }
                    }
                    gauss_Polinom.Print_answer(list);
                    FormResults resultForm = new FormResults(list,n,k);
                    resultForm.Show();

                    Console.WriteLine("\n");
                }

                else
                {
                        list2 = gauss_Polinom.recursion_way_for_fing_coeff(n, k);
                        FormResults resultForm = new FormResults(list2,n,k);
                        resultForm.Show();
                }
            }

            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для n и k.");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(InputN.Text, out int n) && n > 0) && (int.TryParse(InputK.Text, out int k) && k > 0))
            {
                Interblock_inversions inv = new Interblock_inversions();
                inv.Determining_the_size_of_the_list(n, k, n - k);

                if (k > n)
                {
                    MessageBox.Show("K не может быть больше N. Ответ: 0");
                    return;
                }

                Input_window I_I_I = new Input_window(n, k);

                if (I_I_I.ShowDialog() == DialogResult.OK)
                {
                    int required_quantity = I_I_I.GetCountOfInversions();

                    List<List<int>> list_of_inversions = new List<List<int>>();
                    List<List<string>> list_of_mini_inversions = new List<List<string>>();

                    (list_of_inversions, list_of_mini_inversions) = inv.Count_of_inversions(required_quantity);
                    FormInversionResults resultsForm = new FormInversionResults(list_of_inversions, list_of_mini_inversions,k);
                    resultsForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для n и k.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(InputN.Text, out int n) && n > 0) && (int.TryParse(InputK.Text, out int k) && k > 0))
            {
                The_lame_king inv = new The_lame_king();
                inv.Determining_the_size_of_the_list(n,k,n-k);

                if (k > n)
                {
                    MessageBox.Show("K не может быть больше N. Ответ: 0");
                    return;
                }

                Input_window I_I_I = new Input_window(n, k);

                if (I_I_I.ShowDialog() == DialogResult.OK)
                {
                    int required_quantity = I_I_I.GetCountOfInversions();

                    List<List<int>> vector_of_steps_lame_king = new List<List<int>>();

                    vector_of_steps_lame_king = inv.Count_of_steps_lame_king(required_quantity);

                    
                    List<List<string>> vector_of_ways_lame_king = new List<List<string>>();
                    foreach (List<int> answer in vector_of_steps_lame_king)
                    {
                        vector_of_ways_lame_king.Add(inv.VisualizePath(answer));
                    }
                    WaysOfTheLameKing WaysForm = new WaysOfTheLameKing(vector_of_steps_lame_king, vector_of_ways_lame_king);
                    WaysForm.Show();
                }
            }
            else { 
             MessageBox.Show("Пожалуйста, введите корректные значения для n и k.");
            }
            
        }
    }
}
