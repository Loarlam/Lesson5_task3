using System;

namespace Task3
{
    class MyMatrix
    {
        int[,] _baseArray;
        readonly Random randomElements = new Random();

        public int this[int index1, int index2] => _baseArray[index1, index2];
        public int NumberOfLines { get; set; }
        public int NumberOfColumns { get; set; }

        public int[,] FillsAnarray()
        {
            _baseArray = new int[NumberOfLines, NumberOfColumns];

            for (int i = 0; i < NumberOfLines; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    _baseArray[i, j] = randomElements.Next(10, 99);
                }
            }
            return _baseArray;
        }

        public int[,] ComparesLinesAndColumnsWithAnotherMatrices(MyMatrix myMatrixClass, MyMatrix myDerivedClass, int[,] anotherArray)
        {
            //Если [3,3] < [4,4], то дополняем производную матрицу элементами базовой матрицы
            if (myMatrixClass.NumberOfLines < myDerivedClass.NumberOfLines && myMatrixClass.NumberOfColumns < myDerivedClass.NumberOfColumns)
            {
                for (int i = 0; i < myMatrixClass.NumberOfLines; i++)
                {
                    for (int j = 0; j < myMatrixClass.NumberOfColumns; j++)
                    {
                        _baseArray[i, j] = anotherArray[i, j];
                    }
                }
            }
            //Если [3,3] > [4,4], то сжимаем производную матрицу и заполняем элементами базовой матрицы
            else if (myMatrixClass.NumberOfLines > myDerivedClass.NumberOfLines && myMatrixClass.NumberOfColumns > myDerivedClass.NumberOfColumns)
            {
                for (int i = 0; i < myDerivedClass.NumberOfLines; i++)
                {
                    for (int j = 0; j < myDerivedClass.NumberOfColumns; j++)
                    {
                        _baseArray[i, j] = anotherArray[i, j];
                    }
                }
            }
            //Если [3,3] и [4,2], то по строке - дополняем производную матрицу, а по столбцу - сжимаем производную матрицу, 
            //- и заполняем элементами базовой матрицы
            else if (myMatrixClass.NumberOfLines < myDerivedClass.NumberOfLines && myMatrixClass.NumberOfColumns > myDerivedClass.NumberOfColumns)
            {
                for (int i = 0; i < myMatrixClass.NumberOfLines; i++)
                {
                    for (int j = 0; j < myDerivedClass.NumberOfColumns; j++)
                    {
                        _baseArray[i, j] = anotherArray[i, j];
                    }
                }
            }
            //Если [3,3] и [2,4], то по строке - сжимаем производную матрицу, а по столбцу - дополняем производную матрицу, 
            //- и заполняем элементами базовой матрицы
            else
            {
                for (int i = 0; i < myDerivedClass.NumberOfLines; i++)
                {
                    for (int j = 0; j < myMatrixClass.NumberOfColumns; j++)
                    {
                        _baseArray[i, j] = anotherArray[i, j];
                    }
                }
            }
            return _baseArray;
        }
    }
}
