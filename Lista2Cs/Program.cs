using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// EXERCICIO 06
            double numero;
            double resultado;

            Console.WriteLine("\tMe diga um número para eu poder verificar se é PRIMO ou NÃO");
            numero = double.Parse(Console.ReadLine());

            resultado = primo(numero);

            Console.ReadKey();
        }

        static public double primo(double result)
        {
            double x;
            double y;
            x = result;
            y = 1;

            while (x > 2)
            {
                x = x - 1;
                y = result % x;

                if (y == 0)
                {
                    x = 1;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("Este não é um número primo");
            }
            if (y == 1)
            {
                Console.WriteLine("Este é um número primo");
            }
            return result;
        }*/

            //EXERCICIO 05
            char vogal;
            char consoante;
            

            Console.WriteLine("\tMe diga uma letra para eu poder verificar se é VOGAL ou CONSOANTE");
            Console.ReadLine();
           
        }

        static public char primo(char letra)
        {
            vogal x;
            double y;
            x = result;
            y = 1;

            while (x > 2)
            {
                x = x - 1;
                y = result % x;

                if (y == 0)
                {
                    x = 1;
                }
            }
            if (y == 0)
            {
                Console.WriteLine("Este não é um número primo");
            }
            if (y == 1)
            {
                Console.WriteLine("Este é um número primo");
            }
            return result;

        }
    }
}
