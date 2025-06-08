using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kursach_APP;

namespace Kursach_APP
{
    public partial class FormResults : Form
    {
        public FormResults(List<long> coefficients,int n,int k)
        {
            InitializeComponent();
            label1.Text =  $"Многочлен Гаусса со значениями n = {n}, k = {k}";
            // Настраиваем таблицу
            dataGridView1.Columns.Add("degree", "Степень q");
            dataGridView1.Columns.Add("coefficient", "Коэффициент");

            for (int i = 0; i < coefficients.Count; i++)
            {
                dataGridView1.Rows.Add(i, coefficients[i]);
            }
        }

      
    }
}
