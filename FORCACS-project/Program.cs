
using System;
using System.Threading;
namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MenuForca();

            bool isIniciado = Console.ReadLine().ToLower().Equals("y");
            if (isIniciado) Jogar();
            else Console.WriteLine("COMO OUSAS NAO JOGAR!!!!");
            
            //menu
            //opcoes (regras + jogar + sair)

            //jogo
            // metodos: - corpinho em relacao a vida
            //          - verificar letra
            //          - alfabeto (letras com cores responsivas = verde = acertou, cinza = n tem, branco = faltando
        }

        static void MenuForca()
        {
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine(@"███████╗ ██████╗ ██████╗  ██████╗ █████╗  
██╔════╝██╔═══██╗██╔══██╗██╔════╝██╔══██╗  
█████╗  ██║   ██║██████╔╝██║     ███████║  
██╔══╝  ██║   ██║██╔══██╗██║     ██╔══██║  
██║     ╚██████╔╝██║  ██║╚██████╗██║  ██║  
╚═╝      ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝  ");

            //opcoes
            Console.WriteLine("\n\n=====================================\n\n");
            Console.WriteLine("          Vamos comecar? (y/n)");
            Console.WriteLine("\n\n=====================================");
        }

        static void Jogar()
        {
            Console.Clear();
            bool palavraDescoberta = false;
            
            Console.Write($"\n\n Escolhendo uma palavra");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(400);

            string palavraEscolhida = Forca.SorteiaPalavra();

            while (!palavraDescoberta)
            {
                //show hangman
            }
            
        }
        

    }
}