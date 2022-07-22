internal class Program
{
    private static void Main(string[] args)
    {

        // Задача 1. Дан двумерный массив. Заменить в нём элементы первой строки элементами
        //  главной диагонали. А элементы последней строки, элементами побочной диагонали.

        //  1   2   3   4                1   6  11 15
        //  5   6   7   8     =>         5   6   7  8 
        // 9  10 11 12                   9  10 11 12
        // 12 13 14 15                   12 10  7  4 
        Zadacha1();
        void Zadacha1()
        {
            Console.WriteLine("Введите кол-во строчек");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов");
            int colmuns = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, colmuns];
            Console.WriteLine("Введите начальный диапазон значений");
            int startnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конечный диапазон значений");
            int Finishnumber = Convert.ToInt32(Console.ReadLine());

            FillMatrix(array, startnumber, Finishnumber);
            PrintMatrix(array);


        }

        int[,] FillMatrix(int[,] arr, int startnumber, int finishNumber)
        {
            Random rand = new Random();
            int rows = arr.GetLength(0);
            int colmuns = arr.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colmuns; j++)
                {
                    arr[i, j] = rand.Next(startnumber, finishNumber);
                }
            }
            return arr;

        }

        void PrintMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int colmuns = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colmuns; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

    }
}