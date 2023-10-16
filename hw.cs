class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int[] flat_arr = arr.Cast<int>().ToArray();       
        Array.Sort(flat_arr);
                
        int[,] sorted_arr = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < flat_arr.Length; i++)
        {
            int row = i / arr.GetLength(1);
            int col = i % arr.GetLength(1);
            sorted_arr[row, col] = flat_arr[i];
        }
        
        for (int i = 0; i < sorted_arr.GetLength(0); i++)
        {
            for (int j = 0; j < sorted_arr.GetLength(1); j++)
            {
                Console.Write(sorted_arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
