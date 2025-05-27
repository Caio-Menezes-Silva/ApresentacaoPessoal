using System;
using System.Globalization;

namespace ApresentaçãoPessoal
{
    internal class Pessoa
    {
        private int _idade;
        int numeroDeApresentacoes;
        public string Nome { get; set; }
        public int Idade
        {
            get { return Idade = _idade; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser negativa.");
                }
                _idade = value;
            }
        }
        public double Altura { get; set; }
        public string Hobby1 { get; set; }
        public string Hobby2 { get; set; }
        public string Hobby3 { get; set; }
        public string CorFavorita { get; set; }
        public string TimeFavorito { get; set; }
        Pessoa[] pessoa;
        public void CriarApresentacao()
        {

            Console.WriteLine("Digite seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade:");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura em centímetros:");
            Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu primeiro hobby:");
            Hobby1 = Console.ReadLine();
            Console.WriteLine("Digite seu segundo hobby:");
            Hobby2 = Console.ReadLine();
            Console.WriteLine("Digite seu terceiro hobby:");
            Hobby3 = Console.ReadLine();
            Console.WriteLine("Digite sua cor favorita:");
            CorFavorita = Console.ReadLine();
            Console.WriteLine("Digite seu time do coração:");
            TimeFavorito = Console.ReadLine();
            Console.WriteLine("====================================================");
        }


        public void Apresentar()
        {
            string mensagem = ToString();
            Console.WriteLine(mensagem);
        }

        public override string ToString()
        {
            return $"Olá! eu me chamo {Nome}, tenho {Idade} anos, minha altura é {Altura.ToString(CultureInfo.InvariantCulture)} centímetros. " +
                   $"Meus hobbies são: {Hobby1}, {Hobby2} e {Hobby3}. Minha cor favorita é {CorFavorita} e meu time do coração é o {TimeFavorito}. É um prazer te conhecer!";
        }


    }
}
