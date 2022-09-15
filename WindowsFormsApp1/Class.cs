using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Class
    {

        private int[,] matrix = new int[5, 5];

        public Class()
        {
            matrix = new int[5, 5]
            {
                {  1,  2,  3,  4,  5 },
                {  6,  7,  8,  9, 10 },
                { 11, 12, 13, 14, 15 },
                { 16, 17, 18, 19, 20 },
                { 21, 22, 23, 24, 25 }
            };
        }

        public void InputMas(int i, int j)
        {
            matrix = mas;
        }

        public int[,] OutputMas()
        {
            return this.matrix;
        }

        public void InputRandomMas()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }
        }

        public string Result()
        {
            int index = 0;
            int sum = int.MaxValue;

            for (int i = 0; i < 5; i++)
            {
                int temp = 0;
                for (int j = 0; j < 5; j++)
                {
                    temp += matrix[i, j];

                    if (temp < sum)
                    {
                        index = i + 1;
                        sum = temp;
                    }
                }
            }
            return $"Наименьшая сумма элементов в {index}";
        }
    }
}
