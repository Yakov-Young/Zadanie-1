using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Class matrix = new Class();
        public Form1()
        {
            InitializeComponent();
            dataGridView.ColumnCount = 5;
            dataGridView.RowCount = 5;

            int[,] outMartix = matrix.OutputMas();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    //Преобразуем значения из ячеек в числа, и пишем в массив
                    //Если не число то происходит вызов исключения и его обработка
                    dataGridView.Rows[i].Cells[j].Value = outMartix[i, j];
                }
            }
        }

        private void решениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            matrix.InputMas(dataGridView.);
            MessageBox.Show(matrix.Result());
        }
    }
}
