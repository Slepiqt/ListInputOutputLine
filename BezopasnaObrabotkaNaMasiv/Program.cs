
using System.Windows.Input;

namespace BezopasnaObrabotkaNaMasiv
{
    internal class Program
    {
        static List<string> Reverse(List<string> arr)
        {
            //poluchavam masiv i vrushtam list ot oburnatiq masiv
            List<string> result = new List<string>();
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                result.Add(arr[i]);
            }
            return result;
        }
        static List<string> Distinct(List<string> arr)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr.Contains(arr[i]) == false) ;
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }
        static void Replace(List<string> List, int index, string element)
        {
            if (index < 0 || index > List.Count - 1)
            {
                Console.WriteLine("nevaliden indek");
                return;
            }
            List[index] = element;
        }
        static void Insert(List<string> List, int index, string element)
        {
            if (index < 0 || index > List.Count)
            {
                Console.WriteLine("nevaliden indek");
                return;
            }
            List.Insert(index, element);
        }
        static void RemoveAt(List<string> List, int index)
        {
            if (index < 0 || index > List.Count)
            {
                Console.WriteLine("Nevaliden index");
                return;
            }
            List.RemoveAt(index);
        }
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();
            List<string> output = new List<string>(input); //suzdava se output

            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Reverse": output = Reverse(output); break;
                    case "Distinct": output = Distinct(output); break;
                    case "Replace":
                    {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            Replace(output, index, element);
                            break;
                    }
                    case "Insert":
                    {
                            int index = int.Parse(command[1]);
                            string element = command[2];
                            Insert(output, index, element);
                            break;
                    }
                    case "RemoveAt":
                    {
                            int index = int.Parse(command[1]);
                            RemoveAt(output, index);
                            break;
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();

            }


            Console.WriteLine(string.Join(", ", output));
        }
    }

}

