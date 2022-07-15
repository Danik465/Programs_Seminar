﻿internal class Program
{
    private static void Main(string[] args)
    {
        //Exemple013
        string[,] table = new string[2,5];
        //  table[0,0]  table[0,1]  table[0,2]  table[0,3]
        //  table[1,0]  table[1,1]  table[1,2]  table[1,3]
        
        table[1,2] = "слово"; 

        for (int rows = 0; rows < 2; rows++)
        {
            for (int columns = 0; columns < 5; columns++)
            {
                Console.WriteLine($"-{table[rows, columns]}-");
            }
        }

        

        void PrintImage(int[,] image)
        {
            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    // Console.Write($"{image[i, j]} ");
                    if (image[i,j] == 0) Console.Write($" ");
                    else Console.Write($"+");
                }
                Console.WriteLine();
            }
        }


        void FillArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i,j] = new Random().Next(1,10);
                }
            }
        }
        int[,] matrix = new int[3,4];


        Console.WriteLine();
        FillArray(matrix);
  


        //Exemple014

        int[,] pic = new int[,]
        {
    //   1  2  3  4  5  6  7  8   9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, },
        {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, },
        {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, },
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        };


        void FillImage (int row , int col)
        {
            if(pic[row,col] == 0)
            {
                pic[row, col] = 1;
                FillImage(row - 1, col);
                FillImage(row, col - 1);
                FillImage(row + 1, col);
                FillImage(row, col+ 1);
            }
        }
        PrintImage(pic);
        FillImage(13,13);
        PrintImage(pic);

        //Exemple015

        double Factorial (int n)
        {
            // 1! = 1
            // 0! = 1
            if (n == 1) return 1;
            else return n* Factorial(n- 1);

        }

        for (int i = 1; i < 40; i++)
        {
            Console.WriteLine($"{i}! = {Factorial(i)}");
        }
        
         //Exemple016

        //  f(1) = 1
        //  f(2) = 1
        //  f(n) = f(n-1) + f(n-2)

        double Fibonaci(int n)
        {
             if (n==1 || n== 2) return 1;
             else return Fibonaci(n-1) + Fibonaci(n-2);
        }

        for (int i = 1; i < 50; i++)
        {
            Console.WriteLine($"{i} = {Fibonaci(i)}");
        }
    }
}