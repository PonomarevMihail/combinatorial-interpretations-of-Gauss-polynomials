using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_APP
{
    public partial class Input_window : Form
    {
        
        private int CountOfInversions;
        private int Size;
        private int FirstCountSize;
        private int SecondCountSize;

        public Input_window(int n,int k)
        {
            InitializeComponent();
            Size = n;
            FirstCountSize = k;
            SecondCountSize = n - k;

            if (SecondCountSize < 0)
            {
                MessageBox.Show("Выход за границы массива");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }


            int Max_Degree = FirstCountSize * SecondCountSize;
            label3.Text = $"Сколько инверсий вы хотите получить между двумя блоками от 0 до {Max_Degree}";     
        }

        public int GetCountOfInversions()
        {
            return CountOfInversions;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int Max_Degree = FirstCountSize * SecondCountSize;
            
            if (int.TryParse(InputCountOfInversions.Text, out CountOfInversions) && ((int.Parse(InputCountOfInversions.Text) > -1 && (int.Parse(InputCountOfInversions.Text)) <= Max_Degree)))
            {
                CountOfInversions = int.Parse(InputCountOfInversions.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(Max_Degree < 0)
            {
                MessageBox.Show("Выход за границы массива");
            }
            else
            {
                MessageBox.Show($"Введите корректное значение: от 0 до {Max_Degree}");
            }
        }

        

      
    }
}
