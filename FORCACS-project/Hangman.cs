
using System;
using System.Threading;
namespace HangmanGame
{
    class Hangman
    {
        static void Main(string[] args)
        {
            int maxLife = 5;
            int life = maxLife;
            for (int i = 0; i <= maxLife; i++)
            {
                Console.Clear();
                Console.WriteLine(stickFigure(life));
                Thread.Sleep(1000);
                life--;
            }
        }

        static string stickFigure(int life)
        {
            return @$"      _______
     |/      |
{head(life)}     
{body1(life)}
{body2(life)}
{legs(life)}
     |
    _|___";
        }
        static string head(int life)
        {
            if (life < 6)
            {
                return "     |      (_)";
            }
            else
            {
                return "     |";
            }
        }

        static string body1(int life)
        {
            switch (life)
            {
                case 6:
                case 5:
                    return "     |";
                case 4:
                    return "     |       |";
                case 3:
                    return @"     |      \|";
                default:
                    return @"     |      \|/";
            }
        }

        static string body2(int life)
        {
            if (life < 5)
            {
                return "     |       |";
            }
            return "     |      ";

        }

        static string legs(int life)
        {
            switch (life)
            {
                case 1:
                    return @"     |      / ";
                case 0:
                    return @"     |      / \";
                default:
                    return "     |";
            }
        }
    }
}