using System;

namespace Task3
{
    class MyMatrix
    {
        int[,] _array;

        public MyMatrix(int[,] filledArray)
        {
            _array = filledArray;
        }

        public int this[int index1, int index2] => _array[index1, index2];
    }
}
