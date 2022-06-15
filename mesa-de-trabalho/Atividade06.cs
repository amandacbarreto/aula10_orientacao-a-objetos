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
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
        }

        private void PegarNome()
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
        }

        private void ImprimirResultadoFinal()
        {
            Console.WriteLine($"Olá {nome}, você nasceu em {anoNascimento}");
        }
    }
}
