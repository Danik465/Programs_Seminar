internal partial class Program
{
    private static void Main(string[] args)
    {
        // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        // Напишите программу, которая покажет количество чётных чисел в массиве.
        // [345, 897, 568, 234] -> 2

            Program();
            void Program()
            {
                Console.WriteLine("Какой длины будет массив?");
                int length = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[length];
                CreateArray(array, 100, 999);
                PrintArray(array);
                Console.WriteLine();
                int count = Even(array);
                Console.WriteLine($"Четных чисел в массиве - {count}");
            }

            int[] CreateArray(int[] arr, int startNumber, int finishNumber)
            {
                Random rand = new Random();
                for(int i = 0 ; i < arr.Length; i++)
                    {
                         arr[i] = rand.Next(startNumber,finishNumber);
                    }
            return arr;
            }

            int[] PrintArray(int[] arr)
            {
            for(int i = 0 ; i < arr.Length; i++)
                {
                     Console.Write(arr[i] + " ");
                }
            return arr;
            }

            int Even(int[] arr)
            {
                int count = 0;
                for(int i = 0 ; i < arr.Length; i++)
                {
                    if(arr[i] % 2 == 0)
                    {
                         count++;
                    }
                }
                return count;
            }

            // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
            // стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
            // [-4, -6, 89, 6] -> 0

            Program2();
            void Program2()
            {
                Console.WriteLine("Какой длины будет массив?");
                int length = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[length];
                Console.WriteLine("Укажите диапазон разброса чисел");
                int start = Convert.ToInt32(Console.ReadLine());
                int finish = Convert.ToInt32(Console.ReadLine());
                CreateArray1(array, start, finish);
                PrintArray1(array);
                Console.WriteLine();
                int sum = SumIndexEven(array);
                Console.WriteLine($"Сумма элементов стоящих на нечетных позициях - {sum}");
            }

            int[] CreateArray1(int[] arr, int startNumber, int finishNumber)
            {
            Random rand = new Random();
            for(int i = 0 ; i < arr.Length; i++)
                {
                     arr[i] = rand.Next(startNumber,finishNumber);
                }
            return arr;
            }

            int[] PrintArray1(int[] arr)
            {
                for(int i = 0 ; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
            return arr;
            }

            int SumIndexEven(int[] arr)
            {
                int sum = 0;
                for(int i = 0 ; i < arr.Length; i++)
                    {
                        if(i % 2 != 0)
                        {
                          sum+=arr[i];
                        }
                    }
                return sum;
            }

            // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
            // и минимальным элементов массива.

            // [3 7 22 2 78] -> 76

            Program3();
            void Program3()
            {
                Console.WriteLine("Какой длины будет массив?");
                int length = Convert.ToInt32(Console.ReadLine());
                double[] array = new double[length];
                Console.WriteLine("Укажите до какого числа будет разброс");
                double finish = Convert.ToInt32(Console.ReadLine());
                CreateArray2(array, finish);
                PrintArray2(array);
                Console.WriteLine();
                double max = MaxElement(array);
                double min = MinElement(array);
                Console.WriteLine("{0,1:N2}", max);
                Console.WriteLine("{0,1:N2}", min);
                Console.WriteLine("Разница между минимальным и максимальным элементом - "+ "{0,1:N2}", max - min);
            }

            double[] CreateArray2(double[] arr, double finishNumber)
            {
                Random rand = new Random();
                for(int i = 0 ; i < arr.Length; i++)
                {
                    arr[i] = rand.NextDouble()*finishNumber;
                }
                return arr;
            }

            double[] PrintArray2(double[] arr)
            {
                for(int i = 0 ; i < arr.Length; i++)
                {
                  Console.Write("{0,8:N2}", arr[i]);
                }
                return arr;
            }

            double MaxElement(double[] arr)
            {
                double max = arr[0];
                for(int i = 0 ; i < arr.Length; i++)
                {
                    if(arr[i] >max)
                    {
                      max = arr[i];
                    }
                }
                return max;
            }
            double MinElement(double[] arr)
            {
                double min = arr[0];
                for(int i = 0 ; i < arr.Length; i++)
                {
                    if(arr[i] <min)
                    {
                        min = arr[i];
                    }

                }
                return min;
            }
    }
}