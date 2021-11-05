using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB_HW_4 {
    static class Matrix {

        /// <summary>
        /// Метод для работы с матрицей, создает матрицу заданного размера.
        /// Заполняет матрицу случайными числами.
        /// </summary>
        public static void WorkWithMatrix() {
            
            Console.WriteLine("Введите количсетво строк матрицы:");
            int sizeX = Program.IntegerInput();
            
            Console.WriteLine("Введите количсетво столбцов матрицы:");
            int sizeY = Program.IntegerInput();

            int[,] matrix = new int[sizeX, sizeY];
            int seed = DateTime.Now.Millisecond;
            Random rnd = new Random(seed);
            
            for (int i = 0; i < sizeX; i++)
                for (int j = 0; j < sizeY; j++)
                    matrix[i, j] = rnd.Next(0, 100);

            MatrixPrint(matrix);
            Console.WriteLine("Сумма элементов матрицы: " + MatrixSum(matrix));
        }

        /// <summary>
        /// Вывод на экран матрицы.
        /// </summary>
        /// <param name="matrix">Матрица для вывода</param>
        static void MatrixPrint(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.Write("\n");
            }

        }
        /// <summary>
        /// Считает сумму всех элементов матрицы.
        /// </summary>
        /// <param name="matrix">Матрица для подсчета</param>
        /// <returns>Сумма элементов матрицы</returns>
        static int MatrixSum(int[,] matrix) {
            int sum = 0;
            
            foreach (var i in matrix) {
                sum += i;
            }
            return sum;
        }
    }
}
