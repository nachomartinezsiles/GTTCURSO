using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 item = Convert.ToInt32(args[0]);
            Int32 total = 0;

            foreach (string input in args)
            {
                Int32 number = Int32.Parse(input);
                total += number;
            }
            float resultado = total / args.Length;
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
