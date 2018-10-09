using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace ProvaCs
{
    class Program
    {
        static void Main(string[] args)
        {
           //Usando filtro e ordenação para descobrir a posição da carta
            int[] cartas;
            cartas = new int[5];

            cartas[0] = 2;
            cartas[1] = 4;
            cartas[2] = 6;
            cartas[3] = 8;
            cartas[4] = 10;

            int posicaoCarta = -1;
            for(int i=0; i<cartas.Length && posicaoCarta == -1; i++)
            {
                int proximaCarta = cartas[i];
                if(proximaCarta == 6)
                {
                    posicaoCarta = i;
                }
            }
            if (posicaoCarta != -1)
                Console.WriteLine("Posição da carta: " + posicaoCarta);
            else
                Console.WriteLine("Não encontrado.");

            Console.ReadKey();
            }
            // Aqui é o calculo area*perimetro para passar as medidas do triangulo retangulo
        static void Main()
        {
            Retangulo meuRet;
            meuRet = new Retangulo(20, 60);

            Console.WriteLine(meuRet.calcularArea());
            Console.WriteLine(meuRet.calcularPerimetro());

            Console.WriteLine((new Retangulo(8, 9)).calcularArea());

            Console.ReadKey();
        }

        class Retangulo
        {
            double baseRet;
            double alturaRet;

            public Retangulo(double argBase, double argAltura)
            {
                this.baseRet = argBase;
                this.alturaRet = argAltura;
            }

            public double calcularArea()
            {
                return this.baseRet * this.alturaRet;
            }

            public double calcularPerimetro()
            {
                return (this.baseRet + this.alturaRet) * 2;
            }   
        }*/
        /*  //Leia um caractere e informe se ele é vogal ou consoante.
          char caracter;
          bool vogal = false;

          string[] vogais = new string[] {"a", "e", "i", "o", "u"};

          Console.Write("Informe uma letra: ");
          char.TryParse(Console.ReadLine(), out caracter);

          for (int i = 0; i < vogais.Length; i++)
          {
              if (vogais[i] == caracter.ToString())
              {
                  vogal = true;
              }
          }
          Console.ForegroundColor = ConsoleColor.Magenta;
          if (vogal)
          {
              Console.WriteLine("Esta letra é VOGAL.");
          }
          else
          {
              Console.WriteLine("Esta letra é CONSOANTE.");
          }
          Console.ReadKey();
        }*/

    /* // Este verifica se um número é primo ou não
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
    }
  }
}*/