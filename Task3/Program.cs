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
            MyMatrix myMatrix, myDerivedMatrix;
            Random randomIntValue = new Random();
            int[,] baseArray, derivedArray;
            int numberOfLines, numberOfColumns, numberOfLinesDerivedMatrix, numberOfColumnsDerivedMatrix;

            Console.Write("Количество строк матрицы = ");
            numberOfLines = Int32.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы = ");
            numberOfColumns = Int32.Parse(Console.ReadLine());

            baseArray = new int[numberOfLines, numberOfColumns];

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    baseArray[i, j] = randomIntValue.Next(10, 99);
                }
            }

            myMatrix = new MyMatrix(baseArray);

            Console.WriteLine("Элементы матрицы:");
            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.Write($"{myMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.Write("\nКоличество строк производной матрицы = ");
            numberOfLinesDerivedMatrix = Int32.Parse(Console.ReadLine());
            Console.Write("Количество столбцов производной матрицы = ");
            numberOfColumnsDerivedMatrix = Int32.Parse(Console.ReadLine());

            derivedArray = new int[numberOfLinesDerivedMatrix, numberOfColumnsDerivedMatrix];

            for (int i = 0; i < numberOfLines; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    derivedArray[i, j] = baseArray[i,j];
                }
            }

            myDerivedMatrix = new MyMatrix(derivedArray);

            if (numberOfLines < numberOfLinesDerivedMatrix && numberOfColumns < numberOfColumnsDerivedMatrix)
            {               
                Console.WriteLine("Элементы матрицы:");
                for (int i = 0; i < numberOfLinesDerivedMatrix; i++)
                {
                    for (int j = 0; j < numberOfColumnsDerivedMatrix; j++)
                    {
                        Console.Write($"{myDerivedMatrix[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
