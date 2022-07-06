internal partial class Program
{
    private static void Main(string[] args)
    {

        //Задача 1. На вход подаётся натуральное десятичное число. Проверьте,
// является ли оно палиндромом в двоичной записи.
    string DoubleForm(string numb)
     {
       int n = 0;
       string binary = "";
       n = Convert.ToInt32(numb);
       while(0< n)
       {
         binary = binary + Convert.ToString(n%2);
         n = n/2;
       }
       return binary;
     }
   
    string DoubleFormReverse(string numb)
    {
        string binary2 = "";

        
        for (int i = numb.Length-1; i >= 0; i--)
        {
            binary2  = binary2 + numb[i];
        }
        return binary2;
    }
    
    EnterNumb();
    void EnterNumb()
    {
      Console.WriteLine("Введите число");
      string number = Console.ReadLine();
      string bin = DoubleForm(number);
      Console.WriteLine($"Число {number} в двоичной системе - {DoubleFormReverse(bin)}");
      Palindrome(bin);
    }
    
  void Palindrome(string numb)
  {
    int i = 0;
    int len = numb.Length-1;
    int len1 = len; 
    while(len/2> i)
        {
            if(numb[i] == numb[len1])
            {
                i++;
                len1= len1 - 1;
            }
            else 
            {
                Console.WriteLine("Не палиндром");
                break;
            }
        }
       if (len/2 <= i) {Console.WriteLine("Палиндром");}            
    
  }





         // Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99. Определите самый часто встречающийся элемент в массиве. 
         //Если таких элементов несколько, вывести их все.
    Random rand = new Random();
    // int[] array1 = new int[100];
    // CreateArray(array1);
    // int[] massiv = MaxCount(array1);
    // PrintMass(massiv);
    
    // CreateArray(array1);
    // int number = Count(array1, 72);
    // Console.WriteLine(number);
    // PrintMass(array1);

     void PrintMass(int[] arr)
        {
        for (int index = 0; index< arr.Length; index++)
        {
            Console.Write(arr[index]+ " ");
        }
        }

    

    
    int Count(int[] arr, int numb)
        {
        int count1 = 0;
        for (int ind =0; ind <arr.Length; ind++ )
            {
            if (numb ==arr[ind])
            {
                count1++;
            }
            }
        return count1;
        }

    int[] MaxCount(int[] arr)
        {
            int[] arr1 = new int[100]; 
            int count1 = 0;
            for (int ind = 0; ind <= arr.Length-1; ind++ )
                for (int ind1 = 0 ; ind1 < arr.Length; ind++)
                {
                {
                    if (arr[ind1] == arr[ind])
                    {
                    
                    arr1[ind] = count1;
                    count1++;
                    }
                
                }
                count1= 0;
                }
            return arr1;
        }
    // //Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
    // // Размер массива должен совпадать с квадратом количества единиц в нём.
  
       int[] massiv = new int[10];
       int[] CreateArray(int[] arr)
        {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0,2);
        }
        return arr;
        }

       int MassOnes(int[] arr)
       {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
             if(arr[i] == 1)
                {
                    count++; 
                }   
            }
            
            return count;
       }
       
       int LengthMass(int[] arr)
       {
            int arrLength = MassOnes(arr)*MassOnes(arr);
            return arrLength;
       }
       
       CreateArray(massiv);
       PrintMass(massiv);
       int sum = MassOnes(massiv);
       Console.WriteLine();
       Console.WriteLine(sum);
       Console.WriteLine(LengthMass(massiv));
      



    }

    
}