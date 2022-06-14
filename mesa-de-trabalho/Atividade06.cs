using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesa_de_trabalho
{
    public class Atividade06
    {
        public string nome;
        public int idade;
        public int anoNascimento;

        public void Inicio()
        {
            PegarNome();
            PegarIdade();
            CalcularAnoNascimento();
            ImprimirResultadoFinal();
        }

        private void CalcularAnoNascimento()
        {
            anoNascimento = DateTime.Now.Year - idade;
        }

        private void PegarIdade()
        {
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
        }

        public void PegarNome()
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
        }

        public void ImprimirResultadoFinal()
        {
            Console.Write($"Olá {nome}, você nasceu em {anoNascimento}");
        }
    }
}
