internal class Program
{
    private static void Main(string[] args)
    {
        //Вид1

        // void Method1()
        // {

        //     Console.WriteLine("Автор..");
        // }
        // Method1();


        // //Вид2
        // void Method2(string msg)
        // {
        //     Console.WriteLine(msg);
        // }
        // Method2("Текст сообщение");

        // void Method21(string msg, int count)
        // {
        //     int i = 0;

        //     while (i<count)
        //     {
        //         Console.WriteLine(msg);
                
        //         i++;
        //     }
            
        // }
        // Method21(count: 4, msg: "Текст");

        //Вид3

        // int Method3()
        // {
        //     return DateTime.Now.Year;
        // }
        // int year = Method3();
        // Console.WriteLine(year);

        //Вид4

        // string Method4(int count, string text)
        // {
        //     int i = 0 ;
        //     string result = "";

        //     while (i<count)
        //     {
        //         result = result + text;
        //         i++;
        //     }
        //     return result;
        // }

        // string res = Method4(10, "asdf");
        // Console.WriteLine(res);

        // string Method4(int count, string text)
        // {
     
        //     string result = "";
        //     for(int i = 0; i < count ; i++)
        //     {
        //         result = result + text;
        //     }
        //     return result;
        // }

        // string res = Method4(10, "asdf");
        // Console.WriteLine(res);\

        // for (int i = 2; i <= 10; i++)
        // {
        //     for (int j = 2; j <= 10; j++)
        //     {
        //         Console.WriteLine($"{i} * {j} = {i*j}");
        //     }
        //     Console.WriteLine();
        // }
        
        // string text = "-Я думаю, - сказал князь, улыбаясь, - что," + 
        //               "Ежели бы вас послали вместо нашего милого Винценгероде," +
        //               "Вы бы взяли приступом согласие прусского короля."+
        //               "Вы так красноречивы. Вы дадите мне чаю?";
        // //string s = "qwerty"
        //             //012

        // string Replace(string text, char oldValue, char newValue)
        // {
        //     string result = String.Empty;

        //     int length = text.Length;

        //     for (int i = 0; i < length; i++)
        //     {
        //      if(text[i] == oldValue) result = result + $"{newValue}";
        //      else result = result + $"{text[i]}";   
        //     }
        //     return result;
        // }

        // string newText = Replace(text, ' ','|' );
        // Console.WriteLine(newText);
        // Console.WriteLine();

        // newText = Replace(newText, 'с', 'С');
        // Console.WriteLine(newText);

        // string newText2 = Replace(newText, 'к', 'К');
        // Console.WriteLine(newText2);

        int[] arr = {1,5,6,4,2,6,3,2};

        void PrintArray(int[] array)
        {
            int count = array.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        void SelectionSort(int[] array)
        {
            
            for (int i = 0; i < array.Length-1 ; i++)
            {
                int minPosition = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] <array[minPosition]) minPosition = j;
                }

                int temp = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temp;
            }
        }
        PrintArray(arr);
        SelectionSort(arr);

        PrintArray(arr);

    }               
}