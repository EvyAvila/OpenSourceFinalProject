//By Evy Avila

using NumberLibrary;
using System.Security.Cryptography;

namespace HelloWorldProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int rand = RandomNumberGenerator.GetInt32(200);
            
            var input = rand;
            
            if (input.GetType() != typeof(int))
            {
                input = (int)Math.Round((decimal)input);
            }

            Console.WriteLine($"Is {input} an even number? " + Number.IsNumberEven((int)input));
           
            Console.ReadKey();

        }
    }
}