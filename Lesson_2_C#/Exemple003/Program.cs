internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = {1,2,33,4,18,16,17,18};

        int n = array.Length;
        int find = 18;

        int index = 0;

        while (index < n)
        {

            if(array[index] == find)
            {
                Console.WriteLine(index);
                break;
            }
            index++;
        }
    }
}