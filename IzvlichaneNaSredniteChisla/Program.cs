namespace IzvlichaneNaSredniteChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dai broi chisla: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedi chisla: ");
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sredni = new List<int>();
            int sredno = 0;
            int sredno2 = 0;
            int sredno3 = 0;
            if (chisla.Count == 1)
            {
                Console.WriteLine(chisla.Count);

                if (n % 2 == 0)
                {
                    sredno = n / 2 - 1;
                    sredno2 = n / 2;
                    sredni.Add(sredno);
                    sredni.Add(sredno2);
                    
                }
                else if (n % 2 != 0)
                {
                    sredno = n / 2 - 1;
                    sredno2 = n / 2;
                    sredno3 = n / 2 + 1;
                    sredni.Add(sredno);
                    sredni.Add(sredno2);
                    sredni.Add(sredno3);

                }
            }
            Console.WriteLine(string.Join(", ",sredni));
            

            
        }
    }
}
