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
            int[,] baseArray;

            Console.Write("Количество строк матрицы = ");
            myMatrix.NumberOfLines = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы = ");
            myMatrix.NumberOfColumns = int.Parse(Console.ReadLine());

            baseArray = myMatrix.FillsAnarray();

            OutputElementOfArray(myMatrix.NumberOfLines, myMatrix.NumberOfColumns, myMatrix);

            Console.Write("\nКоличество строк производной матрицы = ");
            myDerivedMatrix.NumberOfLines = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов производной матрицы = ");
            myDerivedMatrix.NumberOfColumns = int.Parse(Console.ReadLine());

            myDerivedMatrix.FillsAnarray();
            myDerivedMatrix.ComparesLinesAndColumnsWithAnotherMatrices(myMatrix, myDerivedMatrix, baseArray);

            OutputElementOfArray(myDerivedMatrix.NumberOfLines, myDerivedMatrix.NumberOfColumns, myDerivedMatrix);

            //Метод OutputElementsOfArray, в данном теле, нужен лишь затем, чтобы отобразить работу индексатора
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
