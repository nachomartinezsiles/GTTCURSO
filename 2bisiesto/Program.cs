using System;

namespace _2bisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(Si el resto entre 4 es 0 y el resto entre 100 no es 0) o si el resto entre 400 es 0 */
            Int32 anobisiesto = Convert.ToInt32(args[0]);
            if ((anobisiesto % 4 == 0 && anobisiesto % 100 != 0) || anobisiesto % 400 == 0)
            {
                Console.WriteLine(anobisiesto + " es un año bisiesto");
            }
            else{
                Console.WriteLine(anobisiesto + " no es un año bisiesto");
            }


            if (Program.isbisiesto)
            {
                Console.WriteLine(Program.isbisiesto(Convert.ToInt32(2000)));
            }     
        }
        static bool isbisiesto(string[] args)
        {
            /*(Si el resto entre 4 es 0 y el resto entre 100 no es 0) o si el resto entre 400 es 0 */
            Int32 anobisiesto = Convert.ToInt32(args[0]);
            if ((anobisiesto % 4 == 0 && anobisiesto % 100 != 0) || anobisiesto % 400 == 0)
            {
                return true;
            }
            else{
                return false;
            }
        }

        
    }
}
