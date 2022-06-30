internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        
         Zadacha19(number);

        void Zadacha19(int numb)
        {
            if (numb/10000 >= 1 && numb/10000 <= 9 )
            {
                if (numb/10000 == numb%10 && numb/1000%10 == numb/10%10) {Console.WriteLine("Число - Палиндром");}
                else if (numb/10000 != numb%10 || numb/1000%10 != numb/10%10)
                    {Console.WriteLine("Число не является палиндромом");}
            }
            else  {Console.WriteLine("Число не пятизначное");}
            
        }

        Zadacha21(3,2,6,1,8,-7);

        void Zadacha21(double x1 , double x2 , double y1 , double y2, double z1 , double z2)
        {
             double c =Math.Sqrt(Math.Pow((y2-y1),2)+Math.Pow((x2-x1),2)+ Math.Pow((z2-z1),2));
             Console.WriteLine(c);
        }
        

         Console.WriteLine("Введите число");
         int num = Convert.ToInt32(Console.ReadLine());
         Zadacha23(num);

        void Zadacha23(int N)
        {
             for (int i = 1; i < N; i++)
             {
                Console.Write(i*i*i + " ");
             }
        }

 
    }
}