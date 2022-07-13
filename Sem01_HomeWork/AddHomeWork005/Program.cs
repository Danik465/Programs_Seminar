internal partial class Program
{
    private static void Main(string[] args)
    {
        // Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подаётся трёхзначное натуральное число. Напишите программу, которая определяет,
        //  есть в массиве последовательность из трёх элементов, совпадающая с введённым числом.

// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет


         Zadacha1();
        void Zadacha1()
        {
        int[] mass = new int[15];
        CreateMass(mass);
        PrintMass(mass);
        Console.WriteLine();
        Equality(mass, 322);
        }

        int[] CreateMass(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1,4);
            }
            return arr;
        }
        int[] PrintMass(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            return arr;
        }

        void Equality(int[] arr, int number)
        {
            bool flag = false;
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                {
                    if (arr[i] == number/100 && arr[i+1] == number/10%10 && arr[i+2] == number%10)
                    {
                        flag = !flag;
                        break;
                    }
                }    
            }
            if (flag == false)
            {
                Console.WriteLine("Нет");
            }
            else  Console.WriteLine("Да");
            
        }

        Zadacha2();
        void Zadacha2()
        {
            Console.WriteLine("Введите два числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[QuantityDigit(a)*QuantityDigit(b)];
            PrintArray1(Mult(array, a, b));
        }
        
        int QuantityDigit(int number)
        {
            int count = 1;
            while (number/10 > 0)
            {
                count++;
                number/=10;
            }
            return count;
        }

        void PrintArray1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        int[] Mult(int[] arr ,int number1, int number2)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
               arr[i] = number1%10* number2%10;
               number1/=10;
               number2/=10;
            }
            return arr;
        }


         Zadacha3();
        void Zadacha3()
        {
            Console.WriteLine("Массив из чисел он 1 до 100000");
            int[] array = new int[1000000];
            CreateArray(array);
            
            Console.WriteLine();
            Console.WriteLine($"количество чисел, в которых сумма цифр меньше произведения в 3 раза - {SumMult(array)}");
           

        }
        
        int[] CreateArray(int[] arr)
        {
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = count;
                count++;
            }
            return arr;
        }

        int SumMult(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                int mult = 1;
                while (arr[i] > 0)
                {
                    sum = sum + (arr[i]%10);
                    mult = mult * (arr[i]%10);
                    arr[i]/=10;
                }

                if (mult == sum*3)
                {
                    count++;
                }
            }
            return count;
        }
    }
}