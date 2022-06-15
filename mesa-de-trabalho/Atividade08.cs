namespace mesa_de_trabalho
{
    public class Atividade08
    {
        public String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

        public void Inicio()
        {
            ApresentaTodosOsFilmesSeparadosPorPontoVirgula();
            QuantidadeTotalDeFilmes();
            BuscarNomeDoFilmePeloIndice(1);
            AdicionaUmNovoFilmePeloSeuNome("Encanto");
            AtualizarUmFilmePeloSeuIndice(3);
            ListarTodosOsFilmesComSeuIndiceNaLista();
        }

        public void ApresentaTodosOsFilmesSeparadosPorPontoVirgula()
        {
            Console.WriteLine(string.Join("; ", listaDeFilmes));
        }

        public void QuantidadeTotalDeFilmes()
        {
            Console.WriteLine(listaDeFilmes.Length);
        }

        public void BuscarNomeDoFilmePeloIndice(int indiceDoFilme)
        {
            Console.WriteLine(listaDeFilmes[indiceDoFilme]);
        }

        public void AdicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
        {
            var tempList = listaDeFilmes.ToList();
            tempList.Add(nomeDoFilme);
            listaDeFilmes = tempList.ToArray();
            ApresentaTodosOsFilmesSeparadosPorPontoVirgula();
        }

        public void AtualizarUmFilmePeloSeuIndice(int indiceDoFilme)
        {
            Console.WriteLine("Digite o nome do filme: ");
            string novoFilme = Console.ReadLine();
            listaDeFilmes[indiceDoFilme] = novoFilme;
            ApresentaTodosOsFilmesSeparadosPorPontoVirgula();
        }

        public void ListarTodosOsFilmesComSeuIndiceNaLista()
        {
            for (int i = 0; i < listaDeFilmes.Length; i++)
            {
                Console.WriteLine($"{i} - {listaDeFilmes[i]}");
            }
        }

    }
}
