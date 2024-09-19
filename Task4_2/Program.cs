namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов матрицы:");
            int m = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            int[,] c = new int[n, m];
            //int sum = 0;
            Console.WriteLine("Матрица а:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(10);
                    b[i, j] = random.Next(10);
                    //sum += a[i, j];
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Матрица b:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //a[i, j] = random.Next(10);
                    //b[i, j] = random.Next(10);
                    //sum += a[i, j];
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма матриц a + b:");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //a[i, j] = random.Next(10);
                    //b[i, j] = random.Next(10);
                    //sum += a[i, j];
                    c[i,j] = a[i, j] + b[i,j];
                    Console.Write($"{c[i, j]} ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine($"Сумма всех элементов матрицы = {sum}");
        }
    }
}
