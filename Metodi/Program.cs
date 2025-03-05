using System.Runtime.InteropServices;

namespace Metodi
{
    internal class Program
    {
         static List<string> Reverse (List<string> arr )
        {
            List<string> result = new List<string>();
            for (int i = arr.Count- 1; i >= 0; i--)
            {
                result.Add(arr[i]);
            }
            return result;
        }
        
        static void Repleace(List<string> arr , int index , string NewValue)
        {
            if ( index < 0 || index > arr.Count -1)
            {
                Console.WriteLine("incorrect index");
                return;
            }
            arr[index] = NewValue;
        
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            List<string> output = new List<string>(input);
            //Broi komandi
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split(' ').ToArray();
                switch (comand[0])
                {
                    case "Reverse": output = Reverse(output);break;
                    case "Repleace":
                        {
                            int index = int.Parse(comand[1]);
                            string element = comand[2];
                            Repleace(output, index, element);
                            break;
                        }
                    case "Insert":
                        {
                            int index = int.Parse(comand[1]);
                            string element = comand[2];
                            
                        }
                        
                }
            }


        }
    }
}
