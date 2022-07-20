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
        // Zadacha54();
        void Zadacha54()
        {
            Random rand = new Random();
            // int rows = rand.Next(4, 6);
            // int columns = rand.Next(5, 8);
            int rows = Convert.ToInt32(Console.ReadLine());
            int columns = Convert.ToInt32(Console.ReadLine());
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
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns - 1; j++)
                {
                    // int min = arr[j, 0];
                    for (int k = 0; k < columns - 1; k++)
                    {

                        if (arr[j, k] > arr[j, k + 1])
                        {
                            (arr[j, k], arr[j, k + 1]) = (arr[j, k + 1], arr[j, k]);
                        }

                    }
                    // temp = 0;
                }

            }
            return arr;
        }

        //         Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
        //  которая будет находить строку с наименьшей суммой элементов.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 5 2 6 7
        // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей
        //  суммой элементов: 1 строка
        // Zadacha56();
        void Zadacha56()
        {
            Random random = new Random();
            int rows = random.Next(3, 5);
            int columns = random.Next(5, 7);
            int[,] massive = new int[rows, columns];
            Console.WriteLine("Введите начальный диапазон чисел в массиве:");
            int startNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечный диапазон чисел в массиве:");
            int finishNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Двумерный массив:");
            FillMatrix(massive, startNumber, finishNumber);
            PrintMatrix(massive);
            FillMinSum(massive);
            Console.WriteLine("Массив из сумм строк:");
            PrintMatrixOnes(FillMinSum(massive));
            Console.WriteLine();
            Console.WriteLine("Минимальная сумма строки:");
            int min = MinSum(FillMinSum(massive));
            Console.WriteLine(min);
        }
        int[] PrintMatrixOnes(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            return arr;
        }

        int[] FillMinSum(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            int[] array = new int[rows];
            int index = 0;
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum = 0;
                for (int j = 0; j < columns; j++)
                {
                    sum += arr[i, j];

                }
                array[index] = sum;
                index++;
            }
            return array;
        }

        int MinSum(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }




        //         Задача 58. Заполните спирально массив 4 на 4.
        // Например, на выходе получается вот такой массив:
        // 1  2  3  4
        // 12 13 14 5
        // 11 16 15 6
        // 10  9  8  7


        Zadacha58();
        void Zadacha58()
        {
            Random random = new Random();

            int[,] massive = new int[4, 4];

            Console.WriteLine("Двумерный массив:");
            FillMassivSpiral(massive, 1, 16);
            PrintMatrix(massive);

        }
        int[,] FillMassivSpiral(int[,] arr, int startNumber, int finishNumber)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                int index1 = 1;
                for (int j = 0; j < columns; j++)
                {
                    if (i == 0) arr[i, j] = index1;

                    index1++;
                }

            }
            for (int i = rows; i >= 0; i--)
            {
                int index2 = 6;
                for (int j = columns; j >= 0; j--)
                {
                    if (j <= columns - 1 && i == rows - 1) arr[i, j] = index2;

                    index2++;
                }

            }
            for (int i = rows - 1; i >= 0; i--)
            {
                int index4 = 10;
                for (int j = columns - 1; j >= 0; j--)
                {
                    if (j != 0 && i == rows - 4 && j != columns - 1) arr[j, i] = index4;

                    index4++;
                }

            }

            for (int i = 0; i < rows; i++)
            {
                int index3 = 4;
                for (int j = 0; j < columns; j++)
                {
                    if (i == rows - 1 && j <= columns - 1) arr[j, i] = index3;

                    index3++;
                }

            }
            for (int i = 0; i < rows; i++)
            {
                int index5 = 12;
                for (int j = 0; j < columns; j++)
                {
                    if (i == 1 && j != 0 && j != columns - 1) arr[i, j] = index5;

                    index5++;
                }

            }
            for (int i = rows; i >= 0; i--)
            {
                int index6 = 13;
                for (int j = columns; j >= 0; j--)
                {
                    
                    if (j!= 0&&j <= columns - 2 && i == rows - 2) arr[i, j] = index6;

                    index6++;
                }

            }
            return arr;
        }



    }
}