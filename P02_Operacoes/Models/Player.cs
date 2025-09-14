using System.Collections;

namespace P02_Operacoes.Models;
internal class Player
{
    private Queue<Musica> _filaDeReproducao = [];

    public void AdicionarNaFila(Musica musica)
    {
        _filaDeReproducao.Enqueue(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach (var m in playlist)
            AdicionarNaFila(m);
    }

    private Musica? ProximaMusica()
    {
        if (_filaDeReproducao.Count == 0)
            return null;
        return _filaDeReproducao.Dequeue();
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

    public void TocarProximaMusica()
    {
        var next = ProximaMusica();
        if(next is not null)
        {
            Console.WriteLine("Avançando para a próxima musica...");
            Console.WriteLine($" Tocando Agora: {next.Titulo}");
        }
        else Console.WriteLine("Fila de Reprodução vazia!");

        Console.WriteLine();
    }
}
