internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Задача 1");
        Console.WriteLine();
        Zadacha1(-1);

       void Zadacha1(double x)
       {
            double y = 0;
            if (x > 0) { y = Math.Pow(Math.Sin(x),2);}
            else  {y = 1 - (2*Math.Sin(Math.Pow(x,2)));}
            Console.WriteLine(y);
       }
        Console.WriteLine("--------");
        Console.WriteLine("Задача 2");
        Console.WriteLine();
       Zadacha2(111);

       void Zadacha2(int numb)
       {
            if (numb/100 >=1 && numb/100 <10)
            {
               int sum = numb/100 + numb%100/10 + numb%100%10; 
                if(sum%3 ==0)
                {
                    Console.WriteLine("Сумма цифр кратна трем");
                }
                else Console.WriteLine("Сумма цифр не кратна трем");
                
            }
            else Console.WriteLine("Число не входит в диапозон");
            
       }

        Console.WriteLine("--------");
        Console.WriteLine("Задача 3");
        Console.WriteLine();
        Zadacha3(111);

       void Zadacha3(int numb)
       {
            if (numb/100 >=1 && numb/100 <10)
            {
                int a = numb/100;
                int b = numb/10%10;
                int c = numb%10;
                if ((a == 4 || b == 4 || c == 4)|| (a == 7 || b == 7 || c == 7)) Console.WriteLine("Среди цифр числа есть 4 или 7");
                else Console.WriteLine("Среди цифр числа нет ни 4 ни 7");
            }
            else Console.WriteLine("Число не трехзначное");
            
       }
        
        
        
        Console.WriteLine("--------");
        Console.WriteLine("Задача 4");
        Console.WriteLine();
        
        int[] array = new int[10];
        Zadacha4(array);

        void Zadacha4(int[] arr)
        {
            int numb = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = numb++;
                Console.Write(arr[i] + " ");
                
            }
            Console.WriteLine();
        }

        Console.WriteLine("--------");
        Console.WriteLine("Задача 5");
        Console.WriteLine();
        
         Zadacha5(2);
        void Zadacha5(int numb)
        {
                int x1 = 0;
                int x2 = 0;
                int y1 = 0;
                int y2 = 0;
                int z1 = 0;
                int z2 = 0;
                

            if(numb == 1)
            { 
                 x1 = new Random().Next(1,10);
                 x2 = new Random().Next(1,10);
                 y1 = new Random().Next(1,10);
                 y2 = new Random().Next(1,10);
                 z1 = new Random().Next(1,10);
                 z2 = new Random().Next(1,10);
                
            }
             else if(numb == 2)
            { 
                 x1 = new Random().Next(-10,-1);
                 x2 = new Random().Next(1,10);
                 y1 = new Random().Next(-10,-1);
                 y2 = new Random().Next(1,10);
                 z1 = new Random().Next(-10,-1);
                 z2 = new Random().Next(1,10);
                
            }
              else if(numb == 3)
            { 
                 x1 = new Random().Next(-10,-1);
                 x2 = new Random().Next(-10,-1);
                 y1 = new Random().Next(-10,-1);
                 y2 = new Random().Next(-10,-1);
                 z1 = new Random().Next(-10,-1);
                 z2 = new Random().Next(-10,-1);
                
            }
              else if(numb == 4)
            { 
                x1 = new Random().Next(1,10);
                x2 = new Random().Next(-10,-1);
                y1 = new Random().Next(1,10);
                y2 = new Random().Next(-10,-1);
                z1 = new Random().Next(1,10);
                z2 = new Random().Next(-10,-1);
            }
            
            Console.WriteLine($"{x1},{x2},{y1},{y2},{z1},{z2}");
            double X = Math.Pow((Math.Pow(x1,2)+Math.Pow(x2,2)),0.5);
            double Y = Math.Pow((Math.Pow(y1,2)+Math.Pow(y2,2)),0.5);
            double Z = Math.Pow((Math.Pow(z1,2)+Math.Pow(z2,2)),0.5);

            
            Console.WriteLine($"{X},{Y},{Z}");

            double[] array = {X,Y,Z};

            double min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                
                if (array[i]< min) min = array[i] ;
                              
            }
            
            Console.WriteLine(min);

        }

        Console.WriteLine("--------");
        Console.WriteLine("Задача 6");
        Console.WriteLine();
      
            double[] a = {1,2};
            double[] b = {5,5};
            double[] c = {5,1};
            double[] d = {2,1};
            Zadacha6(a, b, c, d);
        void Zadacha6(double[] A, double[] B, double[] C ,double[] D)
        {
            // Чтобы правильно вычислить угловой коэффициет, должны выполняться сделедующие условия:
            if (A[0]>=B[0]) {double[] temp = A; A = B; B = temp;}   
            
            if (C[0]>=C[0]) {double[] temp = C; C = D; D = temp;}

            double k1 = 0;
            double k2 = 0;
            // Проверяем ровны ли между собой A[1] и B[1], С[1] и В[1]
            
            if (A[1] == B[1]) {k1 = 0;}
            else {k1 = (A[1]-B[1])/(A[0]-B[0]);}

            if (C[1] == D[1]) {k2 = 0;}
            else {k2 = (C[1]-D[1])/(C[0]-D[0]);}
            Console.WriteLine($"{k1},{k2}");
            // Если коэффициетны ровны, то отрезки параллельны и пересекаться не будут

            if (k1 != k2)
            {
                // определяем свободные члены в уравнении прямой
                double b1 = 0;
                double b2 = 0;
                b1 = A[1] - (k1* A[0]);
                b2 = C[1] - (k2 * C[0]);
                
                //Решаем систему уравнений
                double y = 0;
                double x = 0;

                y = k1 * x + b1; 
                y = k2 * x + b2;
                x = (b2-b1)/(k1-k2);
                y = k1 * x + b1; 
                
                //Учтем , что точка пересечения может лежать в не отрезков
                if((A[0]<=D[0] && D[0]<=B[0]) || (A[0]<=C[0] && C[0]<=B[0]))
                {
                    Console.WriteLine("Отрезки имеют точку пересечения");
                    Console.WriteLine($"{x}, {y}");
                }
                else {Console.WriteLine("перечесения нет");}

            }
            else
             {
                Console.WriteLine("Отрезки парралельны. Пересечения нет");
                
             }

        }

        Console.WriteLine("--------");
        Console.WriteLine("Задача 7");
        Console.WriteLine();

        Zadacha7(1,5);
        void Zadacha7(double x, double y)
        {
            double gep = Math.Sqrt((Math.Pow(x,2))+(Math.Pow(y,2)));

            double sinA = (Math.Sin(Math.Abs(y)/gep)*180)/Math.PI;
            double sinB = sinB = (90-sinA);
            
             double min = 0;
             if(sinA < sinB) {min = sinA;}
             else min = sinB;
        
            Console.WriteLine($"Наименьший угол наклона отрезка АО к оси Х: {min}");
        }

        Console.WriteLine("--------");
        Console.WriteLine("Задача 8");
        Console.WriteLine();
        
       
    }
}