using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SilinEV.Sprint5.Task2.V3.Lib
{
    public class DataService : ISprint5Task2V3
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string a = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 1) a += 0;
                    else a += matrix[i, j];

                    if (j != matrix.GetLength(1) - 1) a += "; ";
                    else a += Environment.NewLine;
                }
            }

            return a;
        }
    }
}
