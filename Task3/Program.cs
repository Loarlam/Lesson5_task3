/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс MyMatrix, обеспечивающий представление матрицы произвольного размера 
с возможностью изменения числа строк и столбцов.  
Написать программу, которая выводит на экран матрицу и производные от нее матрицы разных порядков. 
*/
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array;

            Console.Write("Количество строк матрицы = ");
            int numberOfLines = Int32.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы = ");
            int numberOfColumns = Int32.Parse(Console.ReadLine());

            array = new int[numberOfLines, numberOfColumns];

            Random randomIntValue = new Random();
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    array[i, j] = randomIntValue.Next(10, 99);
                }
            }

            MyMatrix myMatrix = new MyMatrix(array);

            Console.WriteLine("Элементы матрицы:");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write($"{myMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
