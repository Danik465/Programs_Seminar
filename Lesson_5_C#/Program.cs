internal partial class Program
{
    private static void Main(string[] args)
    {
        // string Zadacha1 (int a , int b)
        // {
        //     string result = String.Empty;
        //     for (int i = a; i >= b ; i--)
        //     {
        //         result += $"{i} ";
        //     }
        //     return result;
        // }

        // string Zadacha1Rec (int a , int b)
        // {

        //     if (a<= b) return Zadacha1Rec(a+1,b)+$"{a} " ;

        //     else return String.Empty;
        // }

        //Console.WriteLine(Zadacha1(10,1));
        //Console.WriteLine(Zadacha1Rec(1,10));
        Console.WriteLine(Zadacha2(10));
        Console.WriteLine(Zadacha2Rec(10));
        int Zadacha2(int n);
        {
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
        int Zadacha2Rec(int n)
        {
            if (n == 0) return 0;
            else return n + Zadacha2Rec(n - 1);
        }



        

    }
}