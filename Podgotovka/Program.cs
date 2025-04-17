namespace Podgotovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            double sum = 0;
            for (int i = 0; i < masiv.Length; i++)
            {
                sum = sum + masiv[i];
            }
            double avg = sum / masiv.Length;
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i] < min)
                {
                    min = masiv[i];
                }
                if (masiv[i] > max)
                {
                    max = masiv[i];
                }
            }
            Console.WriteLine(avg);
            Console.WriteLine(max);
            Console.WriteLine(min);

        }
    }
}
