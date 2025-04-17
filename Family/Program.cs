using System.Security.Cryptography.X509Certificates;

namespace Family
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko shte e golqmo semeistvoto: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> Semeistvo = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Dai imeto na person {i}: ");
                string name = Console.ReadLine();
                Console.Write($"Dai godinite na person {i}: ");
                int age = int.Parse(Console.ReadLine());
                Person chovek = new Person();
                chovek.name = name;
                chovek.age = age;
                Semeistvo.Add(chovek);
            }
            Console.WriteLine("Semeistvo: ");
            for (int i = 0; i < Semeistvo.Count; i++)
            {
                Semeistvo[i].Print();
            }

        }


    }
    public class Person
    {
        public string name;
        public int age;

        

        public void Print()
        {
            Console.WriteLine($"{name} {age}");
        }
    }
    
    
    

}
