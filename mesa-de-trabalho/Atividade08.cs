namespace mesa_de_trabalho
{
    internal class Atividade08
    {
    }
}


// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };
// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    //string filmes = "";
    //for (int i = 0; i < listaDeFilmes.Length; i++)
    //{
    //    filmes = $"{filmes} {listaDeFilmes[i]}; " ;
    //}
    //return filmes;
    return string.Join("; ", listaDeFilmes);
}
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
// 1.2. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    //return 6;
    return listaDeFilmes.Length;
}
Console.WriteLine(quantidadeTotalDeFilmes());
// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    return listaDeFilmes[indiceDoFilme];
}
Console.WriteLine(buscarNomeDoFilmePeloIndice(1));
// 1.4. Adiciona um novo filme a lista pelo seu nome.
String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    {
        //return listaDeFilmes.Append(nomeDoFilme).ToArray();
        //int[] myArray = new int[] { 1, 2, 3, 4 };
        //var tempList = myArray.ToList();
        //tempList.Add(5);
        //myArray = tempList.ToArray();   //equiv: myArray.Push(5);
        var tempList = listaDeFilmes.ToList();
        tempList.Add(nomeDoFilme);
        listaDeFilmes = tempList.ToArray();
    }
    return listaDeFilmes;
}
//Console.WriteLine("Adicione um novo filme: ");
//string novoFilme = Console.ReadLine();
//adicionaUmNovoFilmePeloSeuNome(novoFilme);
adicionaUmNovoFilmePeloSeuNome("Harry Potter");
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
// 1.5. Atualiza um filme a partir do seu índice na lista.
String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme)
{
    Console.WriteLine("Digite o nome do filme: ");
    string novoFilme = Console.ReadLine();
    listaDeFilmes[indiceDoFilme] = novoFilme;
    return listaDeFilmes;
}
atualizarUmFilmePeloSeuIndice(1);
Console.WriteLine(apresentaTodosOsFilmesSeparadosPorPontoVirgula());
// 1.6. Listar todos os filmes com seu índice/posição na lista.
String[] listarTodosOsFilmesComSeuIndiceNaLista()
{
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        Console.WriteLine($"{i} - {listaDeFilmes[i]}");
    }
    return listaDeFilmes;
    //using.SystemText
    //var sb = bew StringBuilder(); → 
    //sb.AppendLine(index + " - "
    //return sb.ToString();
}
listarTodosOsFilmesComSeuIndiceNaLista();