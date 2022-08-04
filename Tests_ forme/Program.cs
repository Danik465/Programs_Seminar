 internal class Program
{
    
 private static void Main(string[] args)
    {
        //Составить программу:
        // а) заменяющую значение любого элемента пятой строки двумерного массива
        // числом 1949;
        // б) заменяющую значение любого элемента двумерного массива числом a

        //Zadacha1();
        void Zadacha1()
        {
            Console.WriteLine("Введите количество столбцов и строк");
            int rows = Convert.ToInt32(Console.ReadLine());
            int colms = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[rows, colms];

            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintArray(ReplacementElem(array));
        }

        int[,] ReplacementElem(int[,] arr)
        {
            Random random = new Random();
            int rows = arr.GetLength(0);
            int colms = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    if (i == 5)
                    {
                        arr[i, random.Next(0, 5)] = 1967;
                        break;
                    }
                }

            }
            Console.WriteLine();
            return arr;
        }



        //.12.23 Заполнить двумерный массив размером 7 7 так, как показано на рис. 12.1.
        Zadacha2();
        void Zadacha2()
        {
            int[,] array = new int[7, 7];
            OnesPrint(array);
            PrintArray(array);
        }

        int[,] OnesPrint(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int colms = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colms; j++)
                {
                    if (i == j || i == 3 || j == 3 || i+j == 6)
                    {
                        arr[i,j] = 1;
                    }
                    if (j>i && i+j <6 || j<i && i+j>6)
                    {
                        arr[i,j] = 1;
                    }

                }

            }
            return arr;

        }


    }

    static int[,] FillArray(int[,] arr)
    {
        Random random = new Random();
        int rows = arr.GetLength(0);
        int colms = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                arr[i, j] = random.Next(1, 20);

            }

        }
        return arr;

    }
    static int[,] PrintArray(int[,] arr)
    {

        int rows = arr.GetLength(0);
        int colms = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                Console.Write(arr[i, j] + "\t");

            }
            Console.WriteLine();
        }
        return arr;
    }
}