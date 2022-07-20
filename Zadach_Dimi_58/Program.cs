internal class Program
{
    private static void Main(string[] args)
    {
        
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];
            int count = 0;
            int i = -1;
            int j = -1;
            int num = -1;
            int perimeter = 0;
            int numSize = -1;

        PrintMatrix(array);
        int[,] PrintMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);
            for (int i = 0; i < rows-1; i++)
            {
                for (int j = 0; j < columns-1; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            return arr;
        }
     
        

            while (count <= size * size)
            {
                if (count == perimeter)
                {
                    num += 2;
                    perimeter += (size - num) * 4;
                    i++;
                    j++;
                    numSize++;
                }
                if (i == numSize)
                {
                    count++;
                    array[i, j] = count;
                    j++;
                    if (j == size - 1 - numSize) i++;
                }
                else if (j == size - 1 - numSize)
                {
                    count++;
                    array[i, j] = count;
                    i++;
                    if (i == size - 1 - numSize) j--;
                }
                else if (i == size - 1 - numSize)
                {
                    count++;
                    array[i, j] = count;
                    j--;
                    if (j == numSize) i--;
                }
                else if (j == numSize)
                {
                    count++;
                    array[i, j] = count;
                    i--;
                }
               
          
        }
    }
}