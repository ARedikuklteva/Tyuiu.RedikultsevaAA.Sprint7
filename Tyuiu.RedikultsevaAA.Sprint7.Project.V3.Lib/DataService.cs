using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3.Lib
{
    public class DataService
    {
        
        public string[,] SortAlhp(string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            string[] mas2 = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                mas2[i] = array[i, 1];
            }

            IEnumerable<string> sortAscendingQuery =
            from mas in mas2
            orderby mas
            select mas;

            int c = 0;
            foreach (string s in sortAscendingQuery)
            {
                mas2[c] = s;
                c++;
            }

            int count = 0;
            while (count != rows - 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    if(mas2[count] == "ФИО")
                    {
                        count++;
                        break;
                    }
                    if (mas2[count] == array[i, 1])
                    {
                        count++;
                        for (int j = 0; j < columns; j++)
                        {
                            matrix[count, j] = array[i, j];
                        }
                        break;
                    }
                }
            }

            for(int j = 0; j < columns; j++)
            {
                matrix[0,j] = array[0, j];
            }

            return matrix;
        }

        public string[,] FiltrKaf(string num, string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            for(int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            int count = 1;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 10] == num)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[count, j] = array[i, j];
                    }
                    count++;
                }
            }
            return matrix;
        }

        public string[,] FiltrRazd(string num, string[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            string[,] matrix = new string[rows, columns];

            for (int j = 0; j < columns; j++)
            {
                matrix[0, j] = array[0, j];
            }

            int count = 1;
            for (int i = 1; i < rows; i++)
            {
                if (array[i, 5] == num)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        matrix[count, j] = array[i, j];
                    }
                    count++;
                }
            }
            return matrix;
        }
    }
}
