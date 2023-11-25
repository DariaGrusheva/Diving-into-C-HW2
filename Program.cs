// Дан двумерный массив.

//732
//496
//185

//Отсортировать данные в нем по возрастанию.

//123
//456
//789

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

            PrintArray(array1);

            int[] array2 = CopyTwoInOneDimensionalArray(array1);

            int[] array3 = SortingAnArray(array2);

            int[,] array4 = CopyOneInTwoDimensionalArray(array3, array1.GetLength(0), array1.GetLength(1));

            PrintArray(array4);


            int[] CopyTwoInOneDimensionalArray(int[,] array2d)
            {
                int[] array1d = new int[array2d.GetLength(0) * array2d.GetLength(1)];

                int k = 0;
                for (int i = 0; i < array2d.GetLength(0); i++)
                {
                    for (int j = 0; j < array2d.GetLength(1); j++)
                    {

                        array1d[k] = array2d[i, j];
                        k++;
                    }
                }
                return array1d;
            }

            int[] SortingAnArray(int[] array1d)
            {
                int temp = array1d[0];

                for (int j = 0; j < array1d.Length - 1; j++)
                {
                    for (int i = 0; i < array1d.Length - 1; i++)
                    {

                        if (array1d[i + 1] < array1d[i])
                        {
                            temp = array1d[i];
                            array1d[i] = array1d[i + 1];
                            array1d[i + 1] = temp;
                        }
                    }
                }
                return array1d;
            }

            int[,] CopyOneInTwoDimensionalArray(int[] array1d, int rowArray2d, int columnArray2d)
            {
                int[,] array2d = new int[rowArray2d, columnArray2d];
                int k = 0;

                for (int i = 0; i < array2d.GetLength(0); i++)
                {
                    for (int j = 0; j < array2d.GetLength(1); j++)
                    {
                        array2d[i, j] = array1d[k];
                        k++;
                    }
                }

                return array2d;
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
    }
}

