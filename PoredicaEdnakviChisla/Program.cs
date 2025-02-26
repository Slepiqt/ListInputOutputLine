namespace PoredicaEdnakviChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi chislata: ");
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            int Naidulga = 1;
            int nachalo = chisla[0];
            int duljina = 1;
            int BestStart = 0;
            int NaiDoburStart = 0;
            for (int i = 1; i < chisla.Count; i++)
            {
                if (chisla[i] == chisla[i - 1])
                {
                    duljina++;
                }
                else
                {
                    if (duljina > Naidulga)
                    {
                        Naidulga = duljina;
                        BestStart = NaiDoburStart;
                    }
                    duljina = 1;
                    NaiDoburStart = i;
                }                
            }
            if (duljina > Naidulga)
            {
                Naidulga = duljina;
                BestStart = NaiDoburStart;
            }
            for (int i = BestStart; i < BestStart + Naidulga; i++)
            {
                Console.Write($"{chisla[i]}, ");
            }




        }
    }
}
