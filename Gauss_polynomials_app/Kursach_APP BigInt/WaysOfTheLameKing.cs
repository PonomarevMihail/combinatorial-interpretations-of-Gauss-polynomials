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
    public partial class WaysOfTheLameKing : Form
    {
        public WaysOfTheLameKing(List<List<int>> ways_of_the_lame_king, List<List<string>> vector_of_ways_lame_king)
        {

            InitializeComponent();
            InitializeTable();

            label1.Text = $"Количество возможных перестановок: {ways_of_the_lame_king.Count}";
           

            for (int i = 0; i < ways_of_the_lame_king.Count; i++)
            {
                string multip = string.Join(",", ways_of_the_lame_king[i]);
                string miniForm = string.Join(Environment.NewLine, vector_of_ways_lame_king[i]);
                dataGridViewWaysLameKing.Rows.Add(i + 1, multip, miniForm);
            }

        }

        private void InitializeTable()
        {
            dataGridViewWaysLameKing.ColumnCount = 3;
            dataGridViewWaysLameKing.Columns[0].Name = "Номер";
            dataGridViewWaysLameKing.Columns[1].Name = "Перестановки мультимножества";
            dataGridViewWaysLameKing.Columns[2].Name = "Пути хромого короля";

            dataGridViewWaysLameKing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewWaysLameKing.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridViewWaysLameKing.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
