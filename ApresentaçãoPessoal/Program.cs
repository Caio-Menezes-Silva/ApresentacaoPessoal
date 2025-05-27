using ApresentaçãoPessoal;
using System;
using System.Diagnostics;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Olá, seja bem-vindo(a) à minha apresentação pessoal!");
            Console.WriteLine("====================================================");
            Console.WriteLine("Crie a apresentacao da pessoa 1");
            Console.WriteLine("");

            p1.CriarApresentacao();
            p1.Apresentar();
            Console.WriteLine("====================================================");
            Console.WriteLine("");
            Console.WriteLine("Crie a apresentação da pessoa 2");
            p2.CriarApresentacao();
            p2.Apresentar();
            Console.WriteLine("");
            Console.WriteLine("====================================================");
            Console.ReadKey();

        }
    }
}