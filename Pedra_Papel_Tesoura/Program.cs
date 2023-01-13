using System;
using System.Threading;

namespace Pedra_Papel_Tesoura
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        public static void Menu()
        {
            Console.Clear();

            short opcao;

            Console.WriteLine("Escolha a opção desejada:\n");
            Console.WriteLine("1 - JOGAR");
            Console.WriteLine("2 - SAIR\n");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Jogar(); break;
                case 2: Sair(); break;
                default: ExibirErro(); break;
            }
        }

        public static void Jogar()
        {
            Console.Clear();

            int player1, player2;

            Random random = new Random();

            Console.WriteLine("Pedra, Papel, Tesoura\n");

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - PEDRA");
            Console.WriteLine("2 - PAPEL");
            Console.WriteLine("3 - TESSOURA\n");

            Console.WriteLine("Player 1");
            player1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlayer 2");
            player2 = random.Next(1, 3);

            Console.WriteLine(player2);

            if (player1 == 1 && player2 == 2 || player1 == 2 && player2 == 3 || player1 == 3 && player2 == 1)
            {
                Console.WriteLine("\nPlayer 2 WIN!");
            }
            else if (player1 == 1 && player2 == 3 || player1 == 2 && player2 == 1 || player1 == 3 && player2 == 2)
            {
                Console.WriteLine("\nPlayer 1 WIN!");
            }
            else
            {
                Console.WriteLine("\nEmpate!");
            }

            Thread.Sleep(3000);
            Console.Clear();
            Menu();
        }

        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Saindo...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        public static void ExibirErro()
        {
            Console.Clear();
            Console.WriteLine("Opção Inválida!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
