namespace ChislaKvadrati
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chisla: ");
            List<double> num = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            if (√num == (int)num)
        }
    }
}
