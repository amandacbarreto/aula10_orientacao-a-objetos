namespace mesa_de_trabalho
{
    public class Atividade06
    {
        public string nome;
        public int idade;
        public int anoNascimento;

        //Console.Write("Digite sua idade: ");
        //var idadeDoUsuario = Console.ReadLine()!;

        //var anoAtual = DateTime.Now.Year;

        //// Utilize a mensagem a seguir como base do retorno esperado:
        //// Olá João, você nasceu em XXXX.
        //var anoDoNascimento = anoAtual - int.Parse(idadeDoUsuario);
        //Console.Write($"Olá {nomeDoUsuario}, você nasceu em {anoDoNascimento}");

        public void Inicio()
        {
            PegarNome();
        }

        public void PegarNome ( )
        {
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var atividade06 = new Atividade06();
            atividade06.Inicio();
        }
    }
}