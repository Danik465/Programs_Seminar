internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 1. Написать перевод десятичного числа в двоичное, используя рекурсию.



    //   Console.Write(find(1));
        

        int find(int decimal_number)

        {
            if (decimal_number == 0) 

                return 0; 

            else

            return (decimal_number % 2 + 10 * find(decimal_number / 2));

        }


        // Задача 2. На вход подаётся поговорка “без труда не выловишь и рыбку из пруда”. Используя рекурсию,
        //  подсчитайте, сколько в поговорке гласных букв.


        string str =  "без труда не выловишь и рыбку из пруда";
        Console.WriteLine(Glass(str));
        int Glass(string str)
        {
        

        
        }

    }
}