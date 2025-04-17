namespace SortiraneNaChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedi chisla: ");
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            for (int i = 0; i < list.Count -1; i++)
            {
                for( int k = i + 1; k < list.Count; k++)
                {
                    if (list[k] < list[i])
                    {
                        double swap = list[i];
                        list[i] = list[k];
                        list[k] = swap;
                    }
                }
            }
            Console.WriteLine(string.Join('<' , list));
        }
    }
}
