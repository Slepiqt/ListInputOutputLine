namespace MnojestvoNaSumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] seq = new int[n];
            seq[0] = 1;
            
            for (int i = 1; i < n; i++)
            {
                int Sum = 0;
                for (int j = i - k; j < i ; j++)
                {
                    if (j >= 0)
                    {
                        Sum += seq[j];
                    }
                }
                seq[i] = Sum;
            }
            
            Console.Write(string.Join(", ", seq));
        }
    }
}
 