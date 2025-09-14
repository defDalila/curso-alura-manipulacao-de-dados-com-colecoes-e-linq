using System.Collections;

namespace P02_Operacoes.Models;
internal partial class Player
{

    public void AdicionarNaFila(Musica musica)
    {
        _filaDeReproducao.Enqueue(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach (var musica in playlist)
            AdicionarNaFila(musica);
    }

    public void ExibirFilaDeReproducao()
    {
        Console.WriteLine($"Exibindo a fila de reprodução:");
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

    public void TocarMusicaAnterior( )
    {
        var previous = MusicaAnterior();

        if (previous is not null )
        {
            Console.WriteLine("Voltando para a música anterior...");
            Console.WriteLine($"Reproduzindo agora: {previous.Titulo}");
        }
        else
        {
            Console.WriteLine("Nenhuma musica foi tocada anteriormente.");
        }
        Console.WriteLine();
    }

    public void ExibirHistoricoDeReproducao()
    {
        Console.WriteLine("Exibindo as últimas músicas tocadas:");
        foreach (var musica in HistoricoDeReproducao())
            Console.WriteLine($"\t- {musica.Titulo}");

        Console.WriteLine();
    }
}
