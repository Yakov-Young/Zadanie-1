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
        public bool Transfer(int[,] mas, int mode)
        {
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    try
                    {
                        if (mode == 0)
                        {
                            dataGridView.Rows[i].Cells[j].Value = mas[i, j];
                        }
                        else
                        {
                            mas[i, j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Ошибка в {i + 1} строке и {j + 1} столбце");
                        return false;
                    }

                }
            }
            return true;
        }
        public Form1()
        {
            InitializeComponent();
            dataGridView.ColumnCount = 5;
            dataGridView.RowCount = 6;
            dataGridView.AllowUserToAddRows = false;
            textBox1.Enabled = false;

            Transfer(matrix.OutputMas(), 0);
        }

        private void решениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = matrix.Result(Transfer(matrix.OutputMas(), 1));

        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer(matrix.InputRandomMas(), 0);
        }
    }
}
