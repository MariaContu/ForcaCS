using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HangmanGame;

public static class Forca   
{
    static string path = Path.Combine(AppContext.BaseDirectory,"./palavras.txt");
    public static string SorteiaPalavra()
    {
        if (File.Exists(path))
        {
            string[] palavras = File.ReadAllLines(path);
            Random random = new Random(); 
            string palavraSorteada = palavras[random.Next(palavras.Length)];
            return palavraSorteada;
        }
        Console.WriteLine("Arquivo de palavras não encontrado :(");
        return null;
    }

    public static bool verificaChute(char chute, string palavra)
    {
        //
        
        return false;
    }
    
    public static void Alphabet(List<char> letrasCertas, List<char> letrasErradas)
    {
        List<char> letras = Enumerable.Range('A', 26).Select(x => (char)x).ToList();

        foreach (char l in letras)
        {
            if (letrasCertas.Contains(l))
                Console.ForegroundColor = ConsoleColor.Green;
            else if (letrasErradas.Contains(l))
                Console.ForegroundColor = ConsoleColor.DarkGray;
            else
                Console.ResetColor();

            Console.Write($"{l} ");
        }

        Console.ResetColor();
        Console.WriteLine();
    }
    public static string StickFigure(int life)
    {
        return @$"      _______
     |/      |
{Head(life)}     
{Body1(life)}
{Body2(life)}
{Legs(life)}
     |
    _|___";
    }
    public static string Head(int life)
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

    public static string Body1(int life)
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

    public static string Body2(int life)
    {
        if (life < 5)
        {
            return "     |       |";
        }
        return "     |      ";

    }

    public static string Legs(int life)
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