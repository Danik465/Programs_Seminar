internal partial class Program
{
    private static void Main(string[] args)
    {
        // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные
        //  числа в промежутке от M до N.


        int n = 1;
        int m = 10;
     //   Recursion(m, n);
        void Recursion(int m, int n)
        {

            if (n > m) return;
            Console.Write(n + " ");
            n++;
            Recursion(m, n);
        }

        //        Задача 67: Напишите программу, которая будет принимать на вход число
        //  и возвращать сумму его цифр.
        // 453 -> 12
        // 45 -> 9

        
      
        Recursion1(15094);
        void Recursion1(int m , int sum = 0)
        {
           
            if (m ==0) 
            {
                 Console.Write(sum);
                return;
            }
            
             sum += m%10;
              m =  m/10;
            Recursion1(m, sum);
        }


        Random rand = new Random(); 
        int rowsFirst = rand.Next(3,7);
        int colmsFirst = rand.Next(3,7);
        int rowsSecond = colmsFirst;
        int colmsSecond = rand.Next(3,7);
        
    }
}