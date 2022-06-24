internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 1");
        //Задача 1. Пользователь вводит число N (N > 0). Программа должна вывести N единиц на экран.
        int N = -10;
        int count = 0;
        int g = 0;

        if (N > 0)
            {
                while (count< N)
                {
                g = N/N;
                count++;
                Console.Write(g + " ");
                }
            }
        else {Console.WriteLine("Неверное число");}
        
        Console.WriteLine("---------------");
        //Задача 2. Даны два числа a, b, такие что a < b. 
        //Вывести на экран сколько раз число a поместиться в числе b.
        Console.WriteLine("Задача 2");
        int a = 5;
        int b = 12;

        if(a<b)
        {
            int c = 0;
            c = b/a;
            Console.WriteLine($"Число {a} войдет в число {b} - {c} раз");
        
        }


        Console.WriteLine("Задача 3");
        //Задача 3. На ввод подаётся рост трёх спортсменов.
        // Расположить их от большего к меньшему.
    //int[] array = {9, 6, 15};
       
        
      //  int index = 0;
    // int secInd = 0;
       // int temp = 0;
       
        //while (index < array.Length)
        //{
          //  while (secInd < array.Length-1)
            //{
              //  if (array[index] < array[secInd])
                //{
                  //  temp = array[index] ;
                    //array[index] = array[secInd];
                    //array[secInd] = temp;
                    
               //}
            //secInd++;
             
           // }
        //index++;
        
      //  }
       // Console.Write(array[index] + " ");

        //Задача 4. Дано N секунд. Вывести время в формате часы:минуты:секунды.
        //N = 72334 -> 20:5:34 
        Console.WriteLine("Задача 4");

        int Time = 119;
        int Hours = Time/3600;
        int Minutes = (Time % 1000)/60;
        int seconds =  Time%100;

        if (seconds>59)
        {
            Minutes++;
            seconds = seconds - 60; 

        }
        Console.WriteLine($"{Hours}: {Minutes}: {seconds}");

    }
}
    