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
            MyMatrix myMatrix = new MyMatrix(), myDerivedMatrix = new MyMatrix();
            int[,] baseArray, derivedArray;

            Console.Write("Количество строк матрицы = ");
            myMatrix.NumberOfLines = Int32.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы = ");
            myMatrix.NumberOfColumns = Int32.Parse(Console.ReadLine());

            baseArray = myMatrix.FillsAnarray();

            OutputElementOfArray(myMatrix.NumberOfLines, myMatrix.NumberOfColumns, myMatrix);

            Console.Write("\nКоличество строк производной матрицы = ");
            myDerivedMatrix.NumberOfLines = Int32.Parse(Console.ReadLine());
            Console.Write("Количество столбцов производной матрицы = ");
            myDerivedMatrix.NumberOfColumns = Int32.Parse(Console.ReadLine());

            derivedArray = myDerivedMatrix.FillsAnarray();

            for (int i = 0; i < myMatrix.NumberOfLines; i++)
            {
                for (int j = 0; j < myMatrix.NumberOfColumns; j++)
                {
                    derivedArray[i, j] = baseArray[i, j];
                }
            }

            OutputElementOfArray(myDerivedMatrix.NumberOfLines, myDerivedMatrix.NumberOfColumns, myDerivedMatrix);

            void OutputElementOfArray(int numberOfLine, int numberOfColumns, MyMatrix myClassReference)
            {
                Console.WriteLine("Элементы матрицы:");
                for (int i = 0; i < numberOfLine; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        Console.Write($"{myClassReference[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
