using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pedra_Papel_Tesoura
{
    public class Funcionalidades: IPedraPapelTesoura
    {
        public static void Menu()
        {
            Funcionalidades funcionalidades = new Funcionalidades();

            Console.Clear();

            short opcao;

            Console.WriteLine("Escolha a opção desejada:\n");
            Console.WriteLine("1 - JOGAR");
            Console.WriteLine("2 - SAIR\n");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: funcionalidades.Jogar(); break;
                case 2: funcionalidades.Sair(); break;
                default: funcionalidades.ExibirErro(); break;
            }
        }

        public void Jogar()
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
            player2 = random.Next(1, 4);

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

        public void Sair()
        {
            Console.Clear();
            Console.WriteLine("Saindo...");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        public void ExibirErro()
        {
            Console.Clear();
            Console.WriteLine("Opção Inválida!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
