internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
        // по убыванию элементы каждой строки двумерного массива.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // В итоге получается вот такой массив:
        // 1 2 4 7
        // 2 3 5 9
        // 2 4 4 8
        Zadacha54();
        void Zadacha54()
        {
            Random rand = new Random();
            int rows = rand.Next(4, 6);
            int columns = rand.Next(5, 8);
            Console.WriteLine("Введите начальный диапазон чисел в массиве:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечный диапазон чисел в массиве:");
            int finishNumber = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Задан массив:");
            FillMatrix(matrix, startNumber, finishNumber);
            PrintMatrix(matrix);
            Console.WriteLine("Отсортированный массив");
            SortedMatrix(matrix);
            PrintMatrix(matrix);


        }

        int[,] FillMatrix(int[,] arr, int startNumber, int FinishNumber)
        {
            Random random = new Random();
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = random.Next(startNumber, FinishNumber);
                }
            }
            return arr;
        }


        int[,] PrintMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            return arr;
        }

        int[,] SortedMatrix(int[,] arr)
        {
            // int temp = 0;

            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows-1; i++)
            {

                for (int j = 0; j < columns-1; j++)
                {
                    // int min = arr[j, 0];
                    for (int k = 0; k < columns-1; k++)
                    {

                        if (arr[j, k] > arr[j,k+1] )
                        {
                           (arr[j,k], arr[j,k+1]) = (arr[j,k+1],arr[j,k]);
                        }

                    }
                    // temp = 0;
                }

            }
            return arr;
        }




    }
}