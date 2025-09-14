using System.Collections;

namespace P02_Operacoes.Models;
internal partial class Player
{
    private Queue<Musica> _filaDeReproducao = [];
    private Stack<Musica> _historicoDeReproducao = [];


    private Musica? ProximaMusica()
    {
        if (_filaDeReproducao.Count == 0)
            return null;

        var musica =  _filaDeReproducao.Dequeue();
        _historicoDeReproducao.Push(musica);

        return musica;
    }

    private Musica? MusicaAnterior( )
    {
        if (_historicoDeReproducao.Count == 0) return null;

        return _historicoDeReproducao.Pop();
    }

    private IEnumerable<Musica> FilaDeReproducao()
    {
        foreach (var musica in _filaDeReproducao)
        {
            yield return musica;
        }
    }

    private IEnumerable<Musica> HistoricoDeReproducao()
    {
        foreach (Musica musica in _historicoDeReproducao)
            yield return musica;
    }

}
