internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
        // какое число большее, а какое меньшее.
        Console.WriteLine("Задача №2");

        Console.WriteLine("Введем два числа для сравнения");
        
        TwoNumbers(Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()));

        void TwoNumbers(int numberA, int numberB)
        {
            if (numberA > numberB){Console.WriteLine($"Число {numberA} больше числа {numberB}");}
            else if (numberA < numberB){Console.WriteLine($"Число {numberA} меньше числа {numberB}");}

        }

        

        //Задача 4: Напишите программу, которая принимает на вход три 
        //числа и выдаёт максимальное из этих чисел.
        Console.WriteLine("-----------");
        Console.WriteLine("Задача №4");

        Console.WriteLine("Введем три числа для нахождения максимального");
        
        MaxNumber(55,65,8);

         void MaxNumber(int numberG, int numberN, int numberC)
         {
           int max = numberG;
            if(max < numberN)
            {
                max = numberN;
               
            }
            if (max < numberC)
            {
                max = numberC;
                
            }
           Console.WriteLine($"Максимальное число: {max}");
            
         }
         //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
         //является ли число чётным (делится ли оно на два без остатка).


        Console.WriteLine("-----------");
        Console.WriteLine("Задача №6");

        Console.WriteLine("Введите число");

        void EvenNumb(int number)
        {
            if(number%2 == 0)
            {
                Console.WriteLine($"{number} число чётное ");

            }
            else
            {
                Console.WriteLine($"{number} число нечётное ");
            }


        }

        EvenNumb(Convert.ToInt32(Console.ReadLine()));


        //Напишите программу, которая на вход принимает число (N), 
        //а на выходе показывает все чётные числа от 1 до N.

        Console.WriteLine("-----------");
        Console.WriteLine("Задача №8");

        void EvenNumbers( int N)
        {
            int count = 1;
           while (count <= N)
           {
            if(count%2 == 0)
            { 
                Console.Write(count + " ");
            }   
            count++;
           }

        }

        EvenNumbers(10);
    }
}