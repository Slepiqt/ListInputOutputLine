using System.Reflection;
using System;
using System.Runtime.InteropServices;

namespace DefKlasChovek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public |
            BindingFlags.Instance);
            

            Person person1 = new Person();
            person1.name = "Pesho";
            person1.age = 20;

            Person person2 = new Person();
            person2.name = "Gosho";
            person2.age = 18;

            Person person3 = new Person();
            person3.name = "Stamat";
            person3.age = 43;

            person1.Print();
            person2.Print();
            person3.Print();
            
        }
    }
    class Person
    {
        public string name;
        public int age;
         
        public void Print()
        {
            Console.WriteLine($"{this.name}--{this.age}");
        }
    }
}
