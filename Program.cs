using System;

namespace Decisoes
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double nota1 , nota2 , nota3 , nota4 , media;
             


            Console.WriteLine("Simulador de notas ");

            Console.Write("Digite a Primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Segunda nota: ");
           nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Terceira nota: ");
           nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a Quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10 || nota3 < 0 || nota3 > 10  || nota4 < 0 || nota4 > 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite somente notas entre 0 e 10");
                Console.ResetColor();
                Environment.Exit(-1);
            } 

             else if (media < 5 )
            {   
                 Console.ForegroundColor = ConsoleColor.Red;
                 Console.WriteLine($"\nVocê ficou com média {media:N1}. Resultado: reprovado");
                 Console.ResetColor();
            }

            else if (media >= 5 && media <= 6)
            {
                   Console.ForegroundColor = ConsoleColor.Green;
                   Console.WriteLine($"\nVocê ficou com média {media:N1}. Resultado: recuperação");
                   Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                 Console.WriteLine($"\nVocê ficou com média {media:N1}. Resultado: Aprovado");
                 Console.ResetColor();
            }
        }
    }
}