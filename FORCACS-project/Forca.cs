using System;
using System.IO;

namespace HangmanGame;

public static class Forca   
{
    static string path = Path.Combine(AppContext.BaseDirectory,"./palavras.txt");
    public static string sorteiaPalavra()
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
    
}