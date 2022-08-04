  internal class Program
{
    
 private static void Main(string[] args)
    {
 // Zadacha4();

        void Zadacha4()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[m];
            FillArray(array);
            Console.WriteLine("Первый массив:");
            PrintArray(array);
            Console.WriteLine("Первый массив:");

            PrintArray(NewArray(array));
        }

        double[] NewArray(int[] arr)
        {

            double[] arr2 = new double[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    arr2[i] = arr[i];
                }
                if (arr[i] % 2 != 0)
                {
                    arr2[i] = i * arr[i];
                }
                else arr2[i] = arr[i] / i;
            }
            return arr2;

        }

        // Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
        //(сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

        //3
        // 0 1 2 3 4               0 1 2 3 4
        // 5 3 7 4 6               7 4 6 5 3


        //Zadacha5();
        void Zadacha5()
        {
            Console.WriteLine("Введите количество элеметов массива");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сдвиг массива");
            int K = Convert.ToInt32(Console.ReadLine());


            int[] array = new int[len];

            FillArray(array);
            PrintArray(array);


            PrintArray(ShiftElements(array, K));
        }


        int[] ShiftElements(int[] arr, int K)
        {
            int index = 0;
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {

                if (K > 0)
                {

                    if ((i + arr.Length-Math.Abs(K)) < arr.Length)
                    {
                        arr2[i] = arr[i + arr.Length-Math.Abs(K)];
                    }
                    else
                    {
                        arr2[i] = arr[index];
                        index++;
                    }
                }
                else
                {

                    if (i + Math.Abs(K) < arr.Length)
                    {
                        arr2[i] = arr[i + Math.Abs(K)];
                    }
                    else
                    {
                        arr2[i] = arr[index];
                        index++;
                    }
                }

            }
            return arr2;
        }

    

//  Даны два массива одного размера. Получить третий массив, каждый элемент которого равен:
// а) сумме элементов с тем же номером в заданных массивах;
// б) произведению элементов с тем же номером в заданных массивах;
// в) максимальному из элементов с тем же номером в заданных массивах.
//Zadacha6();
    void Zadacha6()
    {
        Console.WriteLine("Введите количество элеметов массива");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] array1 = new int[len];
        int[] array2 = new int[len];

        FillArray(array1);
        FillArray(array2);
        Console.WriteLine("Первый массив:");
        PrintArray(array1);
        Console.WriteLine("Второй массив:");
        PrintArray(array2);
        Console.WriteLine("Сумма массивов:");
        PrintArray(SumElemArray(array1, array2));
        Console.WriteLine("Максимальный из элеметов массива:");
        PrintArray(MaxElemArray(array1, array2));
        Console.WriteLine("Умножение элеметов массива:");
        PrintArray(PowElemArray(array1, array2));

    }

        int[] SumElemArray(int[] arr, int[] arr2)
        {
            int[] arr3 = new int[arr.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr[i] + arr2[i];
            }
            return arr3;
        }
         int[] PowElemArray(int[] arr, int[] arr2)
        {
            int[] arr3 = new int[arr.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = arr[i] * arr2[i];
            }
            return arr3;
        }
         int[] MaxElemArray(int[] arr, int[] arr2)
        {
            int[] arr3 = new int[arr.Length];
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr[i]> arr2[i])
                {
                   arr3[i] = arr[i]; 
                }
                else 
                {
                     arr3[i] = arr2[i]; 
                }
                
            }
            return arr3;
        }


    }


    static double[] FillArray(double[] arr)
    {
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Round((rand.NextDouble() * 20), 2);

        }
        return arr;
    }
    static double[] PrintArray(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");

        }
        Console.WriteLine();
        return arr;

    }
    static int[] FillArray(int[] arr)
    {
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 20);

        }
        return arr;
    }

    static int[] PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");

        }
        Console.WriteLine();
        return arr;

    }
}