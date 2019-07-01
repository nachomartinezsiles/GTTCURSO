// Nacho Martinez 
// 01/07/2019    
/*


*/

using System;

namespace _1_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Escribimos nombre en consola*/
            /*Console.WriteLine("Nacho Martinez");*/

            /*Creamos una variable de tipo String*/ 
            /*string cadena="Nacho Martinez";
            Console.WriteLine(cadena);*/

            /*Creamos dotnet run con un parametro (array) y le pasamos el valor desde la terminal */
            /*Console.WriteLine(args[0]);*/

            /*Declaramos una constante*/
            /*const double Pi = 3.14;*/
            /*Imprimimos el valor de esa constante*/
            /*Console.WriteLine("Valor de pi ->"+ " " + Pi);*/
            
            /*Multiplicamos dos valores que le pasemos en la terminal*/

            /*Console.WriteLine("El valor de la multiplicacion es: " + int.Parse(args[0]) * Convert.ToInt32(args[1]));*/
            
            /*
            Int16 numero1 = Convert.ToInt16(args[0]);
            Int16 numero2 = Convert.ToInt16(args[1]);
            Int32 resultado = numero1 * numero2;
            Console.WriteLine ("El valor de la multiplicacion es: " + "\"\n" + resultado);
            */

            /*Para meter una doble comilla dentro de una doble comilla utilizaremos \ */
            
            
            /*Pasar un double a int */
            /*
            double x = 1234.7;
            Int32 a = (Int32)x;
            Console.WriteLine (a);
            */


            /*SubString (Comienzo, Longitud)*/
            /*
            string nombre= "Cadena de texto";
            Console.WriteLine (nombre.Substring(0,6));
            */

            /*IndexOf ("Cadena", desde donde busca) */
            
            string nombre= "Cadena de texto";
            Console.WriteLine (nombre.IndexOf("Cadena"));
            Console.WriteLine (nombre.IndexOf("ena", 3));

            
            Console.WriteLine (nombre.IndexOf(args[0]));

            Console.WriteLine (nombre.Substring(IndexOf(args[0],3)));

            



        }
    }
}
