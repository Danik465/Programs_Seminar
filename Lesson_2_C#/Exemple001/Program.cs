internal class Program
{
    private static void Main(string[] args)
    {
         int Max(int arg1, int arg2, int arg3)
        {
            int result = arg1;
            if  (arg2 > result)result = arg2;
            if  (arg3 > result)result = arg3;
            return result;
        }

       int a1= 2;
       int b1 =232;
       int c1 = 112;

       int a2 = 14;
       int b2 =13;
       int c2 = 23;

       int a3 = 13;
       int b3 =23;
       int c3 = 15;

       int max = a1;


        int max1 = Max(a1, b1, c1);
        int max2 = Max(a2, b2 ,c2);
        int max3 = Max(a3, b3, c3);
        int result = Max(max1, max2,max3);
       Console.Write(result);
       
    }
}