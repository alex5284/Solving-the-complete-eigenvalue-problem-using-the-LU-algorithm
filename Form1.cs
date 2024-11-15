using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        int MatrixSize = 0;
        double[,] matrix;
        double[,] matrix2;
        double[,] L;
        double[,] U;
        double[] lamda;
        double[] x;
        public Form1()
        {
            InitializeComponent();
        }
        void ReadMatrixFromGrid()
        {
            matrix = new double[MatrixSize, MatrixSize];//создаем матрицу

            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = Convert.ToDouble(dgMatrix.Rows[i].Cells[j].Value);//запоминаем значения
                    matrix2[i, j] = Convert.ToDouble(dgMatrix.Rows[i].Cells[j].Value);
                }
            }


            ShowMatrixInGrid();//показываем матрицу

        }


        void ShowMatrixInGrid()
        {
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();//выводим матрицу
                }
            }
        }

        void CreateMatrixTest()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            int i = 0;
            for (i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }


            dgMatrix.Rows.Add(MatrixSize);

            i = 0;
            dgMatrix.Rows[i].Cells[0].Value = "0,64";
            dgMatrix.Rows[i].Cells[1].Value = "-0,35";
            dgMatrix.Rows[i].Cells[2].Value = "0,28";

            i = 1;
            dgMatrix.Rows[i].Cells[0].Value = "-1,43";
            dgMatrix.Rows[i].Cells[1].Value = "-0,84";
            dgMatrix.Rows[i].Cells[2].Value = "0,52";

            i = 2;
            dgMatrix.Rows[i].Cells[0].Value = "0,77";
            dgMatrix.Rows[i].Cells[1].Value = "0,54";
            dgMatrix.Rows[i].Cells[2].Value = "-0,64";



        }

        void CreateMatrix2()
        {
            MatrixSize = Convert.ToInt32(tbSize.Text);
            dgMatrix.Rows.Clear();
            dgMatrix.Columns.Clear(); // очищаем солонки
            //int i = 0;
            for (int i = 0; i < MatrixSize; i++)
            {
                dgMatrix.Columns.Add("x" + i.ToString(), "x" + i.ToString());
            }

            //dgMatrix.Columns.Add("R", "R");

            dgMatrix.Rows.Add(MatrixSize);
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    dgMatrix.Rows[i].Cells[j].Value = "1"; // записываем значеня в соответсвующие места
                }
            }
        }


        void LU()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            matrix = new double[MatrixSize, MatrixSize];
            matrix2 = new double[MatrixSize, MatrixSize];
            ReadMatrixFromGrid();
            L = new double[MatrixSize, MatrixSize];
            U = new double[MatrixSize, MatrixSize];
            double[,] A1 = new double[MatrixSize, MatrixSize];
            lamda = new double[MatrixSize];
            int itr = 0;
            double eps = 0.0001;
            double S;
            int iter;
            do
            {
                iter = MatrixSize;
                for (int i = 0; i < MatrixSize; i++)
                {
                    for (int j = 0; j < MatrixSize; j++)
                    {
                        if (i >= j)
                        {
                            L[i, j] = matrix[i, j];
                        }
                        else
                        {
                            L[i, j] = 0;
                        }

                        if (i < j)
                        {
                            U[i, j] = matrix[i, j];
                        }
                        else
                        {
                            if (i == j)
                            {
                                U[i, j] = 1;
                            }
                            else
                            {
                                U[i, j] = 0;
                            }
                        }
                    }
                }
                for (int i = 0; i < MatrixSize; i++)
                {
                    for (int j = 0; j < MatrixSize; j++)
                    {
                        S = 0;
                        if (i >= j)
                        {
                            for (int k = 0; k < j; k++)//-1
                            {
                                S = S + L[i, k] * U[k, j];
                            }
                            L[i, j] = matrix[i, j] - S;
                        }
                        else
                        {
                            for (int k = 0; k < i; k++)//-1
                            {
                                S = S + L[i, k] * U[k, j];
                            }
                            U[i, j] = (matrix[i, j] - S) / L[i, i];
                        }
                    }
                }

                for(int i = 0; i < MatrixSize; i++)
                {
                    for (int j = 0; j < MatrixSize; j++)
                    {
                        S = 0;
                        for (int k = 0; k < MatrixSize; k++)
                        {
                            S = S + U[i, k] * L[k, j];
                        }
                        A1[i, j] = S;
                    }
                }

                for(int i = 0; i < MatrixSize; i++)
                {
                    if (Math.Abs(A1[i, i] - matrix[i, i]) <= eps) iter--;
                }
                for (int i = 0; i < MatrixSize; i++)
                {
                    for (int j = 0; j < MatrixSize; j++)
                    {
                        matrix[i, j] = A1[i, j];
                    }
                }
                itr++;
                if(itr > 30)
                {
                    iter = 0;
                }

            } 
            while (iter != 0);

            for(int i = 0; i < MatrixSize; i++)
            {
                lamda[i] = matrix[i, i];
                listBox1.Items.Add("l" + i.ToString() + " = " + lamda[i]);
            }

            
        }


       void Vector()
        {
            matrix = new double[MatrixSize, MatrixSize];
            ReadMatrixFromGrid();
            double x1 = 0, x2 = 0, x3 = 1;
            double a, a1;
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[i, j] = matrix2[i, j];
                }
            }
            for (int i = 0; i < MatrixSize; i++)
            {
                for (int j = 0; j < MatrixSize; j++)
                {
                    matrix[j, j] = matrix[j, j] - lamda[i];
                }
                
                if(i == 0)
                {
                    a = x1 +0.329 * x3;
                    a = 0;
                    a1 = x2 + 1.306 * x3;
                    a1 = 0;
                    x1 = a -0.329 * x3;
                    x2 = a1 - 1.306 * x3;
                }
                else
                {
                    if(i == 1)
                    {
                        a1 = x1 - 4.235 * x3;
                        a1 = 0;
                        a = x2 + 3.075 * x3;
                        a = 0;
                        x1 = a + 4.235 * x3;
                        x2 = a1 - 3.075 * x3;
                    }
                    else
                    {
                        a = x1 - 0.003 * x3;
                        a1 = x2 - 0.807 * x3;
                        a = 0;
                        a1 = 0;
                        x1 = a + 0.003 * x3;
                        x2 = a1 + 0.807 * x3;
                    }
                }
                listBox2.Items.Add("-------------");
                listBox2.Items.Add(x1);
                listBox2.Items.Add(x2);
                listBox2.Items.Add(x3);
            }
        }
        

        private void btnMatrix_Click(object sender, EventArgs e)
        {
            CreateMatrix2();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            CreateMatrixTest();
        }

        private void btnLU_Click(object sender, EventArgs e)
        {
            LU();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector();
        }
    }
}
