internal class Program
{
    private static void Main(string[] args)
    {

        //Zadacha1();

        //  void Zadacha1()
        //  {
        //     Console.WriteLine("Введите число:");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(FindSum(number));

        //  }
        //  int FindSum(int number)
        // {   
        //     int sum = 0;
        //     for (int i = 1; i <= number; i++)
        //     {
        //         sum = sum + i; 
        //     }
        //      return sum;

        // }

        //Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

       // Zadacha2();
        
        // void Zadacha2()
        // {
        //     Console.WriteLine("Введите число:");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(FindNums(number));
        // }

        // int FindNums(int number)
        // {
        //     int count =  1;
        //     while(number/10 > 0)
        //     {
                
        //         number = number/10;
        //         count++;
        //     }
        //     return count;
        // } 
        // Zadacha3();
        
        // void Zadacha3()
        // {
        //     Console.WriteLine("Введите число:");
        //     int number = Convert.ToInt32(Console.ReadLine());
        //     Console.WriteLine(FindMult(number));
        // }

        // int FindMult(int number)
        // {
        //     int sum = 1;
        //     for (int i = 1; i <= number; i++)
        //     {
        //         sum = sum * i; 
        //     }
        //      return sum;
        // } 
            //Задача 30: Напишите программу, которая выводит массив из 8 элементов,
            // заполненный нулями и единицами в случайном порядке.
            //[1,0,1,1,0,1,0,0]
             
           
         int size = 8;
         int[] array = new int[size];     
         FindMass(array);
         Print(array);
        

        void Print(int[] array)
        {
            Console.WriteLine("Вывод массива");
           for (int index=0; index< array.Length; index++)
           {
            Console.Write(array[index]+ " ");
           }
           Console.WriteLine();
            
            
        }
        
        void FindMass(int[] array)
        {
            
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0,2); 
            }


        }
        

    }
    
}