namespace Statistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko hora iskash: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> People = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ime na choveka: ");
                string name = Console.ReadLine();
                Console.WriteLine("vuzrast na choveka: ");
                int age = int.Parse(Console.ReadLine());
                Person hora = new Person();
                hora.name = name;
                hora.age = age;
                People.Add(hora);
            }
            Console.WriteLine("Hora po golemi ot 30: ");
            for (int i = 0; i < People.Count; i++)
            {
                People[i].Print();
            }
        }
    }
    public class Person
    {
        public string name;
        public int age;
        public void Print()
        {
            if (this.age > 30)
            {
                Console.WriteLine($"{this.name} - {this.age}");
            }
        }

    }
}
