namespace SpisukOtKrainosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislata: ");
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> min = new List<int>();
            int min1 = Int32.MaxValue;
            List<int> max = new List<int>();
            int max1 = Int32.MinValue;
            for (int i = 0; i < chisla.Count;i++)
            {
                if (chisla[i] < min1)
                {
                    
                    min1 = chisla[i];
                    
                }
                
            }
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] > max1)
                {
                    
                    max1 = chisla[i];
                    
                }
            }
            for (int i = 0;i < chisla.Count; i++)
            {
                if (chisla[i] == min1)
                {
                    min.Add(chisla[i]);
                }
            }
            for (int i = 0; i < chisla.Count; i++)
            {
                if (chisla[i] == max1)
                {
                    max.Add(chisla[i]);
                }
            }
            for (int i = 0; i< min.Count; i++)
            {
                Console.Write($"{min[i]}, ");
            }
            for (int i = 0; i < max.Count; i++)
            {
                Console.Write($"{max[i]}, ");
            }

        }
    }
}
