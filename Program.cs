using System;
using System.IO.Pipelines;

namespace AULA_03___Variáveis
{
    class Program 
    {
        static void Main (string [] args) 
        {
            Console.WriteLine("Qual o resultado desta equação: 7 * 32 - 77?");
            
            int answer01 = Convert.ToInt32 ( Console.ReadLine ());

            if (answer01 == 147) { 
                Console.WriteLine ("Parabéns, você acertou!");
            } else {
                Console.WriteLine ("Você errou!");
            }

            Console.WriteLine("Qual o resultado arrendodado desta equação: 48 + 61 / 7?");
            
            int answer02 = Convert.ToInt32(Console.ReadLine());

            if (answer02 == 57) {
                Console.WriteLine ("Parabéns, você acertou!");
            } else {
                Console.WriteLine ("Você errou!");
            }

            // Pra esperar alguma tecla do usuário.
            Console.WriteLine ("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
