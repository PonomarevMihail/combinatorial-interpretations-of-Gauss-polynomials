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
    public partial class FormInversionResults : Form
    {
        public FormInversionResults(List<List<int>> inversions, List<List<string>> miniInversions, int k)
        {
            InitializeComponent();
            InitializeTable();
            label1.Text = $"Количество возможных перестановок: {inversions.Count}";

            if (miniInversions == null && inversions.Count == 1)
            {
                for (int i = 0; i < inversions.Count; i++)
                {
                    string p = string.Join(", ", inversions[i]);
                    string m = "Нет";
                    dataGridViewInversions.Rows.Add(0 + 1, p, m);
                }
            }
            else
            {
                for (int i = 0; i < inversions.Count; i++)
                {
                    string permutation = string.Join(", ", inversions[i].Take(k)) + " | " + string.Join(", ", inversions[i].Skip(k));
                    string miniForm = string.Join(Environment.NewLine, miniInversions[i]);

                    dataGridViewInversions.Rows.Add(i + 1, permutation, miniForm);
                }
            }
        }

        private void InitializeTable()
        {
            dataGridViewInversions.ColumnCount = 3;
            dataGridViewInversions.Columns[0].Name = "Номер";
            dataGridViewInversions.Columns[1].Name = "Перестановка";
            dataGridViewInversions.Columns[2].Name = "Инверсии";

            dataGridViewInversions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInversions.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewInversions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
