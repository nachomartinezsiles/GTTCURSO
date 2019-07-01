using System;

namespace _4piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);
            for (int filas = 1; filas <= n; filas++)
            {
                Console.Write("\n");
                for (int columnas = 0; columnas < filas; columnas++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
