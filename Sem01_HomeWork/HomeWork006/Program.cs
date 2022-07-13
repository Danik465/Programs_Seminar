internal class Program
{
    private static void Main(string[] args)
    {

        Zadacha41();
        void Zadacha41()
        {
            Console.WriteLine("Введите количество чисел");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа");
            int num;
            int count = 0;
            string num1 = "";
            while (M>0)
            { 
             num = Convert.ToInt32(Console.ReadLine());
             num1 = num1 + num + " ";
                if (num > 0)
                {
                    count++;
                }
                M--; 
            }
            Console.WriteLine($"Выведенные числа  {num1}");
            Console.WriteLine($"Сколько больше нуля  {count}");   
        }


       // Zadacha43();
         void Zadacha43()
         {
            Console.WriteLine("Введите b1:");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k1:");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b2:");
            double b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k2:");
            double k2 = Convert.ToInt32(Console.ReadLine());

            CrossPoint(b1,k1,b2,k2);

       
         }

         void CrossPoint(double b1,double k1,double b2,double k2)
         {
            double y;
            double x;

            x = (b2 - b1)/(k1 - k2);
            y = (k1*x) + b1;

            Console.WriteLine($"Точка y = {y}");
            Console.WriteLine($"Точка x = {x}");

         }

    



        
    }
}