namespace SumNaOburnatiChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи числата = ");
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> oburnati = new List<int>();
            int duljina = 0;
            int sum = 0;
            for (int i = 0; i < chisla.Count; i++)
            {
                int oburnat = 0;
                int temp = chisla[i];
                while (temp > 0)
                {
                    oburnat = oburnat * 10 + temp % 10;
                    temp = temp / 10;
                }
                oburnati.Add(oburnat);
            }
            for (int i = 0; i < oburnati.Count; i++)
            {
                sum = sum + oburnati[i];
            }
            Console.WriteLine($"Сумата е = {sum}");

        }
    }
}
