using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" --- Exibindo seu nome em ASCIIArt --- \n");
            Console.Write("Digite seu nome: ");

            string nomeUsuario = Console.ReadLine();
            string exibir = FiggleFonts.Standard.Render(nomeUsuario);

            Console.WriteLine("Seu nome ficou assim: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{exibir}");
            Console.ResetColor();

        }
    }
}
