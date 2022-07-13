internal class Program
{
    private static void Main(string[] args)
    {

        // Задача 39: Напишите программу, которая перевернёт одномерный массив 
        // (последний элемент будет на первом месте, а первый - на последнем и т.д.)
        //Zadacha39();
    //     void Zadacha39()
    //     {
    //         int[]array = new int[8];
    //         int[] secondArray = new int[array.Length];
    //         CreateArray(array, 0,10);
    //         PrintArray(array);
    //         Console.WriteLine();
    //         int[] arr2 = SecondArray(array,secondArray);
    //         PrintArray(arr2);
            
    //     }
        

    //     int[] SecondArray(int[] arr, int[] arr2)
    //     {
    //         int maxIndex = arr.Length-1;
    //         for (int i = 0; i < arr.Length; i++)
    //         {
    //             arr2[maxIndex - i] = arr[i];
    //         }
    //         return arr2;
    //     }
        
    //         int[] CreateArray(int[] arr, int startNumber, int finishNumber)
    //         {
    //             Random rand = new Random();
    //             for(int i = 0 ; i < arr.Length; i++)
    //                 {
    //                      arr[i] = rand.Next(startNumber,finishNumber);
    //                 }
    //         return arr;
    //         }

    //         int[] PrintArray(int[] arr)
    //         {
    //         for(int i = 0 ; i < arr.Length; i++)
    //             {
    //                  Console.Write(arr[i] + " ");
    //             }
    //         return arr;
    //         }
   

    //      //Zadacha40();
    //    // void Zadacha40()
    //     {
    //         Console.WriteLine("Введите три числа");
    //         int A = Convert.ToInt32(Console.ReadLine());
    //         int B = Convert.ToInt32(Console.ReadLine());
    //         int C = Convert.ToInt32(Console.ReadLine());
    //         IsTriangle(A,B,C);
    //     }

    //     void IsTriangle(int a , int b , int c)
    //     {
    //         if (a+b == c || b+c == a || c+a == b)
    //         {
    //             Console.WriteLine("Треугольник существует");
    //         }
    //         else Console.WriteLine("Треугольник не существует");        
    //     }
    //    //  Zadacha42();
    //     void Zadacha42()
    //     {
    //         Console.WriteLine("Введите  число");
    //         string A = Console.ReadLine();
    //         string B = DoubleForm(A);
    //         Console.WriteLine(Massive(B));
            
    //     }

    //     string DoubleForm(string numb)
    //     {
    //     int n = 0;
    //     string binary = "";
    //     n = Convert.ToInt32(numb);
    //     while(0< n)
    //     {
    //         binary = binary + Convert.ToString(n%2);
    //         n = n/2;
    //     }
    //     return binary;
    //     }

    //     string Massive(string N)
    //     {
    //         string number = "";
    //         for (int i = N.Length-1; i >= 0; i--)
    //         {
    //             number = number + N[i];
    //         }
    //         return number;
    //     }


    //     //Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
    //     // Первые два числа Фибоначчи: 0 и 1.
    // //    // Zadacha44();
    // //     void Zadacha44()
    //     {
    //        int first = 0;
    //        int second = 1;
    //         int[] array = Fibonnaci(0, 1);

    //         PrintArray(array);
    //     }

    //     int[] Fibonnaci(int[] array)
    //     {
    //        array[0] = 0;
    //        array[1] = 1;
    //         int secondNumb = firstNumb + secondNumb;
    //         for (int i = 2; i < number.Length-1; i++)
    //         {
    //             number[i] = temp;
    //             number[i+1] = secondNumb;
    //         }
    //         return number;
    //     }
    // // Задача 45: Напишите программу, которая будет создавать копию
    // // заданного массива с помощью поэлементного копирования.
    //     Zadacha45();
    //     void Zadacha45()
    //     {
    //         int[] array = new int[10];
    //         int[]secondArray = new int[array.Length];
    //         CreateArray(array, 14 ,30);
    //         PrintArray(array);
            
    //         SeconArr(array,secondArray);
    //         PrintArray(secondArray);
    //     }

    //     int[] SeconArr(int[] arr, int[] arr2)
    //     {

    //         for (int i = 0; i < arr.Length; i++)
    //         {
    //             arr2[i] = arr[i];
    //         }
    //         return arr2;
    //     }

     }
}