using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.RedikultsevaAA.Sprint7.Project.V3.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint7.Project.V3
{
    public partial class FormVariants : Form
    {
        public FormVariants()
        {
            InitializeComponent();
            openFileDialog_RAA.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*"; // ?
        }

        public string openFilePath;
        DataService ds = new DataService();

        static int columns;
        static int rows;
        public string path;

        public static string[,] Array(string path)
        {

            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r'); // ?
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); // ?
            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = strok[j];
                }
            }
            return matrix;
        }


        private void buttonReadFile_RAA_Click(object sender, EventArgs e)
        {
            openFileDialog_RAA.ShowDialog();
            path = openFileDialog_RAA.FileName;


            string[,] res = Array(path);
            dataGridView_RAA.Columns.Clear();
            dataGridView_RAA.Rows.Clear();

            dataGridView_RAA.ColumnCount = columns;
            dataGridView_RAA.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {

                    dataGridView_RAA.Rows[i].Cells[j].Value = res[i, j];
                    dataGridView_RAA.Columns[j].Width = 200;
                    dataGridView_RAA.Rows[i].Height = 25;
                }
            }

        }

        private void buttonSaveFile_RAA_Click(object sender, EventArgs e)
        {

            int rows = dataGridView_RAA.RowCount;
            int columns = dataGridView_RAA.ColumnCount;


            saveFileDialog_RAA.FileName = "Red_University.csv";
            saveFileDialog_RAA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_RAA.ShowDialog();

            string path = saveFileDialog_RAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView_RAA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView_RAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
            
        }


            private void buttonSortAlph_RAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortKafedra_RAA_Click(object sender, EventArgs e)
        {

        }

        private void buttonSortBySubject_RAA_Click(object sender, EventArgs e)
        {

        }
    }
}
