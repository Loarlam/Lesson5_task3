using System;

namespace Task3
{
    class MyMatrix
    {
        int[,] _array;
        Random randomElements = new Random();

        public int this[int index1, int index2] => _array[index1, index2];
        public int NumberOfLines { get; set; }
        public int NumberOfColumns { get; set; }

        public int[,] FillsAnarray()
        {
            _array = new int[NumberOfLines, NumberOfColumns];

            for (int i = 0; i < NumberOfLines; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    _array[i, j] = randomElements.Next(10, 99);
                }
            }
            return _array;
        }
    }
}
