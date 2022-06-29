internal partial class Program
{
    private static void Main(string[] args)
    {
        // Задача 13: Напишите программу, которая выводит 
        //третью цифру заданного числа или сообщает, что третьей цифры нет.

        

        Zadach13("3107");
      
        void Zadach13(string currentNumber)
        {
       
            if (currentNumber.Length < 3)
            {
                Console.WriteLine("Третьей цифры нет");
            }
            else if (currentNumber[2] != 0)
            {
                Console.WriteLine(currentNumber[2]);
            }

        }
        //Задача 15: Напишите программу, которая принимает на вход цифру, 
        //обозначающую день недели, и проверяет, является ли этот день выходным.

        Console.WriteLine("Введите число:");
        int day = Convert.ToInt32(Console.ReadLine());
       
        Zadach15(day);
      
        void Zadach15(int currentNumber)
        {
            if (currentNumber == 1) Console.WriteLine("Сегодня понедельник и не выходной");

            else if (currentNumber == 2)Console.WriteLine("Сегодня вторник и не выходной");

            else if (currentNumber == 3)Console.WriteLine("Сегодня среда и не выходной");

            else if (currentNumber == 4)Console.WriteLine("Сегодня четверг и не выходной");

            else if (currentNumber == 5) Console.WriteLine("Сегодня пятница и не выходной");

            else if (currentNumber == 6) Console.WriteLine("Сегодня суббота и выходной");

            else  if (currentNumber == 7) Console.WriteLine("Сегодня воскресение и выходной");

            else Console.WriteLine("Слишком большое число");
            
        }
        
    }
}