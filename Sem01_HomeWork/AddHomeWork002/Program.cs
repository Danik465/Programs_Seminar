internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 1. Написать программу, которая определяет, 
        //является ли треугольник со сторонами a, b, c равнобедренным.
       

        Zadasha1(3, 2, 3);

        void Zadasha1(int arg1, int arg2 , int arg3)
        {
            if (arg1 > 0 && arg2 > 0 && arg3 > 0)
            {
                if(arg1 == arg2 || arg1 == arg3 || arg2 == arg3 ) {Console.WriteLine("Треугольник является равнобедренным");}

                else {Console.WriteLine("Треугольник не является равнобедренным");}
                
            }
            else {Console.WriteLine("Строна не может быть меньше 0");}
        }

        //Задача 2. На вход подаются год, номер месяца и день 
        //рождения человека, Определить возраст человека на момент 1 июля 2022 года
         
       
       Console.WriteLine("Введите год рождения:");
       int Year = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите месяц рождения:");
       int Month = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Введите день рождения:");
       int Day = Convert.ToInt32(Console.ReadLine());
       
        Zadasha2(Year, Month,Day);
        
        
        void Zadasha2(int year, int month, int day)
        {
            int TodayYear = 2022;
            int TodayMonth = 7;
            int TodayDay = 1;

            int Years = (TodayYear - year)*365 + (TodayMonth - month)*30 + (TodayDay - day);


            Console.WriteLine(Years/365);   


        }


        //Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
        //Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы.
        // Определить размер депозита через n месяцев.

        double deposit = 10000;
        double percent = 20;
        int n = 15;
        
        Zadasha3(deposit, percent, n);


        void Zadasha3(double dep, double perc, int n)
        {
            double depaz = dep;
            for (int i = 0; i < n ; i++)
            {
                dep = dep + depaz* (perc/100);
                
            }
        Console.WriteLine(dep);
        }

        //Задача 4. Дано натуральное число, в котором все цифры различны. Определить, 
       // какая цифра расположена в нем левее: максимальная или минимальная.


        string numb = "123492931";

        Zadasha4(numb);

        void Zadasha4(string n)
        {
            for (int i = 0; i < n.Length-1 ;i++)
                {
                if (n[i] > n[i+1])
                    {
                        Console.WriteLine("Число справа меньше");
                    }
                else if (n[i] < n[i+1])
                    {
                        Console.WriteLine("Число справа больше");
                    }
                }
        }

        
    }
}