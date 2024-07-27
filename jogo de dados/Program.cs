using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_de_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int DicePlayer;
            int AI;
            int p1 = 0; 
            int p2 = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Pressione uma tecla para girar os dados");

                Console.ReadKey();

                DicePlayer = random.Next(1, 7);
                AI = random.Next(1, 7);

                Console.WriteLine("Voce girou um " + DicePlayer);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("A IA girou um " + AI);
                if (AI > DicePlayer)
                {
                    p2++;
                }
                else
                {
                    p1++;
                }
                Console.WriteLine("pontuacao AI = " + p2 + " voce " + p1);



            }
            Console.ReadKey();
        }
    }
}
