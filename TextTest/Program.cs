using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputfile = new System.IO.StreamWriter("text.txt");
            Console.WriteLine("Please enter five names: ");
            for(int i = 0; i < 5; i++)
            {
                string line = Console.ReadLine();
                outputfile.WriteLine(line);
            }
            outputfile.Close();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Contents of text.txt: ");
            string text = System.IO.File.ReadAllText(@"D:\K8920\Demo06\TextTest\bin\Debug\text.txt");
            Console.WriteLine(text);
            Console.WriteLine("---------------------------------------------");

        }
    }
}
