using System;
using System.IO.Pipelines;

namespace AULA_03___Variáveis
{
    class Program 
    {
        static void Main (string [] args) 
        {
            Console.Write("Qual o resultado desta equação: 7 * 32 - 77?\n");
            
            int answer01 = Convert.ToInt32 ( Console.ReadLine ());

            if (answer01 == 147) { 
                Console.Write ("\nParabéns, você acertou!");
            } else {
                Console.Write ("\nVocê errou!");
            }

            Console.Write("\nQual o resultado desta equação: 48 + 61 / 7?\n");
            
            int answer02 = Convert.ToInt32(Console.ReadLine());

            if (answer02 == 57) {
                Console.Write ("\nParabéns, você acertou!");
            } else {
                Console.Write ("\nVocê errou!");
            }

            // Pra esperar alguma tecla do usuário.
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}