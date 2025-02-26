namespace SpisukOtChetniChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislata: ");
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> chetni = new List<int>();
            for (int i = 0; i < chisla.Count;i++)
            {
                if (chisla[i] % 2 == 0)
                {
                    chetni.Add(chisla[i]);
                }
            }
            Console.WriteLine(string.Join(" ",chetni));
        }
    }
}
