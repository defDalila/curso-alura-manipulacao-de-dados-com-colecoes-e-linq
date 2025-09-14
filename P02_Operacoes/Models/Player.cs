namespace P02_Operacoes.Models;
internal class Player
{
    private List<Musica> _filaDeReproducao = [];

    public void AdicionarNaFila(Musica musica)
    {
        _filaDeReproducao.Add(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach (var m in playlist)
            AdicionarNaFila(m);
    }

    private IEnumerable<Musica> FilaDeReproducao()
    {
        foreach (var musica in _filaDeReproducao)
        {
            yield return musica;
        }
    }

    public void ExibirFilaDeReproducao()
    {
        Console.WriteLine($"Exibindo a fila de reprodução: \n");
        foreach (var musica in FilaDeReproducao())
        {
            Console.WriteLine($"\t- {musica.Titulo}");
        }
        Console.WriteLine();
    }

    private Musica? ProximaMusica()
    {
        if (_filaDeReproducao.Count == 0)
            return null;

        var musica = _filaDeReproducao[0];
        _filaDeReproducao.Remove(musica);
        return musica;
    }

    public void TocarProximaMusica()
    {
        var next = ProximaMusica();
        if(next is not null)
        {
            Console.WriteLine($"Tocando a música {next.Titulo}");
        }
        else Console.WriteLine("Fila de Reprodução vazia!");

        Console.WriteLine();
    }
}
