internal partial class Program
{
    private static void Main(string[] args)
    {

        Zadacha1(-1);

       void Zadacha1(double x)
       {
            double y = 0;
            if (x > 0)
            {
                y = Math.Pow(Math.Sin(x),2);
                Console.WriteLine(y);
            }
            else 
            {
                y = 1 - (2*Math.Sin(Math.Pow(x,2)));
                Console.WriteLine(y);
            }
       }
       
       
    }
}