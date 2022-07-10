internal class Program
{
    private static void Main(string[] args)
    {
         //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

    Zadacha1();
    void Zadacha1()
    {
      Console.WriteLine("Введите числа");
      int A = Convert.ToInt32(Console.ReadLine());
      int B = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine($"{A} в степени {B} = {Exp(A,B)}");
    }

    int Exp(int a, int b)
    {  
       
      int exp = 1;

      while (b>0)
        {
            exp = exp * a;
            b--;
        }
        return exp;
    }

      //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

      Zadacha2();
      void Zadacha2()
    {
      Console.WriteLine("Введите число");
      int A = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine($"сумма цифр {A} = {SumDigitNum(A)}");
    }
    
    int SumDigitNum(int a)
        {
        int sum =0;
                while (a > 0)
                {
                    sum = sum + a % 10;
                    a = a /10 ;
                }
            return sum;
        }
    
    //Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и 
    // выводит отсортированный по модулю массив.


        int[] array = new int[8];
        int[] mass = CreateMassiv(array);
        SortMassChoice(mass);
        PrintMass(mass);
        Console.WriteLine();
        SortMassBouble(mass);
        PrintMass(mass);


    int[] CreateMassiv(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i< arr.Length; i++)
                {
                    arr[i] = rand.Next(-10,10);
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

    int[] SortMassChoice(int[] arr)
        {
        int temp = 0;
        for (int pos = 0; pos< arr.Length-1; pos++)
            {
                int minPos = pos;
                for (int pos1 = pos+1; pos1< arr.Length;pos1++)
                {
                    if (Math.Abs(arr[pos1]) < Math.Abs(arr[minPos]))
                        {
                            minPos = pos1;
                        }
                }
                temp = arr[minPos];
                arr[minPos] = arr[pos];
                arr[pos] = temp;
            }
            return arr;
        }


    int[] SortMassBouble(int[] arr)
        {
            int temp = 0;
        for (int pos = 0; pos< arr.Length; pos++)
            {
                for (int pos1 = pos+1; pos1< arr.Length;pos1++)
                {
                    if (Math.Abs(arr[pos1]) < Math.Abs(arr[pos]))
                    {
                        temp = arr[pos];
                        arr[pos] = arr[pos1];
                        arr[pos1] = temp;
                    }

                }
                
            }
            return arr;
        }
    }
}