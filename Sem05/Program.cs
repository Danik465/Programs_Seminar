internal class Program
{
    private static void Main(string[] args)
    {

//         Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна 
// -20.

        // Random rand = new Random();
        // int[] array = new int[12];
        // // CreateMassiv(array);
        // // PrintMass(array);
        // // Console.WriteLine();
        // // MaxMinSum(array);

      
        //  int[] CreateMassiv(int[] arr)
        // {
        //     Random rand = new Random();
        //     for (int i = 0; i< arr.Length; i++)
        //         {
        //             arr[i] = rand.Next(-9,9);
        //         }
        //     return arr;
        // }

        //  void PrintMass(int[] arr)
        //     {
        //         for (int index = 0; index< arr.Length; index++)
        //             {
        //                 Console.Write(arr[index]+ " ");
        //             }
        //     }

        //  void MaxMinSum(int[] arr)
        // {
        //     int sumNegative = 0;
        //     int sumPositive = 0;
        //     for (int i = 0; i < arr.Length; i++)
        //     {
        //         if (arr[i]> 0 ) sumPositive += array[i];
        //         else sumNegative += array[i];
                
        //     }
        //     Console.WriteLine($"Сумма положительны {sumPositive}");
        //     Console.WriteLine($"Сумма положительны {sumNegative}");
        // }



//     Задача 32: Напишите программу замены элементов массива: положительные элементы
//  замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


        //  int[] CreateMassiv(int[] arr)
        // {
        //     Random rand = new Random();
        //     for (int i = 0; i< arr.Length; i++)
        //         {
        //             arr[i] = rand.Next(-9,9);
        //         }
        //     return arr;
        // }

        //  void PrintMass(int[] arr)
        //     {
        //         for (int index = 0; index< arr.Length; index++)
        //             {
        //                 Console.Write(arr[index]+ " ");
        //             }
        //     }


        // int[] Reverse(int[] arr)
        // {
        //     for (int i = 0; i< arr.Length; i++)
        //             {
        //                 arr[i] = arr[i]* (-1);  
        //             }
        //             return arr;
        // }

        // CreateMassiv(array);
        // PrintMass(array);
        // Console.WriteLine();
        
        // Reverse(array);
        // PrintMass(array);


        // //Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

        // Random rand = new Random();
        // int[] array = new int[12];

        // int[] CreateMassiv(int[] arr)
        // {
        //     Random rand = new Random();
        //     for (int i = 0; i< arr.Length; i++)
        //         {
        //             arr[i] = rand.Next(-9,9);
        //         }
        //     return arr;
        // }

        //  void PrintMass(int[] arr)
        //     {
        //         for (int index = 0; index< arr.Length; index++)
        //             {
        //                 Console.Write(arr[index]+ " ");
        //             }
        //     }

        // void Zadacha33(int[] arr, int numb)
        // {
        //    int i = 0;
        //      for (; i< arr.Length; i++)
        //         {
        //             if (arr[i] == numb)
        //             {
        //                 Console.WriteLine("В массиве нет числа");
        //                 break;
        //             }
                    
        //         }
        //         if(i == arr.Length) { Console.WriteLine("В массиве есть число");}

        // }

        // CreateMassiv(array);
        // PrintMass(array);
        // Console.WriteLine();
        // Zadacha33(array, 6);
        
        

//         Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//  значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5


//         Random rand = new Random();
//         int[] array = new int[123];

//         int[] CreateMassiv(int[] arr)
//         {
//             Random rand = new Random();
//             for (int i = 0; i< arr.Length; i++)
//                 {
//                     arr[i] = rand.Next(1,123);
//                 }
//             return arr;
//         }

//          void PrintMass(int[] arr)
//             {
//                 for (int index = 0; index< arr.Length; index++)
//                     {
//                         Console.Write(arr[index]+ " ");
//                     }
//             }

//         int Zadacha33(int[] arr, int a, int b)
//         {
//             int count = 0;
//             for (int i = 0; i < arr.Length; i++)
//             {
//                 if (arr[i] >= a && arr[i] <= b)
//                     {
//                         count++;
//                     }
//             }
//             return count;

//         }
//         CreateMassiv(array);
//         PrintMass(array);
//         Console.WriteLine();
//         Console.WriteLine();
//         int n = Zadacha33(array, 10, 99);
//         Console.WriteLine($"Количество чисел в диапазоне от 10 до 99  - {n}");
       

//        Задача 37: Найдите произведение пар чисел в одномерном массиве.
//         Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

        Random rand = new Random();
        int[] array = new int[11];

        int[] CreateMassiv(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i< arr.Length; i++)
                {
                    arr[i] = rand.Next(1,123);
                }
            return arr;
        }

         void PrintMass(int[] arr)
            {
                for (int index = 0; index< arr.Length; index++)
                    {
                        Console.Write(arr[index]+ " ");
                    }
            }

        int[] Zadacha37(int[] arr)
        {
            int[] mas = {};
            int i = 0;
            int j = 0;
            int array = arr.Length-1;
            while(arr.Length/2 > 0)
            {
                mas[j] = arr[i] + arr[array];
                j++;
                i++;
                array--;

            }
            return mas;
        }
        CreateMassiv(array);
        PrintMass(array);
        Console.WriteLine();
        Console.WriteLine();
        int[] n = Zadacha37(array);
        PrintMass(n);
        

    }
}