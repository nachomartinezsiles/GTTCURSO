using System;
/*Escriba un metodo que imprima la representacion de un parametro entero en numeros romanos. 
Por ejemplo, si el parametro es 1998, la salida deberia ser MCMXCVII*/
namespace _5romanos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano = Convert.ToInt32(args[0]);

            String []Unidad={"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            String []Decena={"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            String []Centena={"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC"};

            int N = Convert.ToInt32(args[0]);
            


        }
    }
}
