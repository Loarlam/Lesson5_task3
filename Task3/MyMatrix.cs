using System;

namespace Task3
{
    class MyMatrix
    {
        int[,] _array;
        //Random randomElements = new Random();

        public MyMatrix(int[,] filledArray)
        {
            _array = filledArray;
        }

        public int this[int index1, int index2]
        {
            get
            {
                return _array[index1, index2];
            }
        }

        //public int[,] Method()
        //{
        //    for (int i = 0; i < numberOfLines; i++)
        //    {
        //        for (int j = 0; j < numberOfColumns; j++)
        //        {
        //            baseArray[i, j] = randomElements.Next(10, 99);
        //        }
        //    }
        //    return _array;
        //}
    }
}
