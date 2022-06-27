internal class Program
{
    private static void Main(string[] args)
    {
     
        // Random rand = new Random();
        // int number = rand.Next(10,100);
        // Zadach9(number); 

        // void Zadach9(int currentNumber)
        // {
        //     Console.WriteLine(currentNumber);

        //     int digitFirst = currentNumber/10;
        //     int digitSecond = currentNumber%10;
        //     if (digitFirst > digitSecond)
        //     {
        //         Console.WriteLine(digitSecond);
        //     }
        //     else if (digitFirst < digitSecond)
        //     {
        //         Console.WriteLine(digitSecond);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Цифры чисел равны");
        //     }


             //Напишите программу, которая выводит случайное
             // трёхзначное число и удаляет вторую цифру этого числа.

        // Random rand = new Random();
        // int number = rand.Next(100,500);

        //     Console.WriteLine(number);
        //     TripleNumber(number);
        //     void TripleNumber(int number)
        //     {
        //         int numb1 = number/100;
        //         int numb3 = number %10;
        //         if (number/100 >=1)
        //         {
        //             Console.WriteLine(numb1*10+numb3);
        //         }
        //     }

        // Zadash12(17, 5);
        // void Zadash12(int numb1 , int numb2)
        // {
        //         if(numb1 % numb2 != 0)
        //         {
        //            Console.WriteLine($"остаоток {numb1%numb2}");  
        //         }
        //         else 
        //         {
        //             Console.WriteLine("является кратным");
        //         }

        // }

        Zadash16(25, 5);
        void Zadash16(int numb1, int numb2)
        {
            if (numb1 == Math.Pow(numb2, 2))
            {
            Console.WriteLine($"Число {numb1}, является квадратом {numb2}");

            }
            else if (numb2 == Math.Pow(numb1, 2))
            {
              Console.WriteLine($"Число {numb2},  является квадратом {numb1}");  
            }
            else
            {
              Console.WriteLine($"не является квадратом");    
            }
        }


    }
}
