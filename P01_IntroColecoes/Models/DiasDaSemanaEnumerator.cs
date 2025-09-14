using System.Collections;

namespace P01_IntroColecoes.Models;
internal class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int _posicao = -1;
    private string[] _dias =
    {
        "Domingo", "Segunda", "Terça", "Quarta",
        "Quinta","Sexta", "Sábado"
    };

    //==========================================
    public string Current => _dias[_posicao];
    object IEnumerator.Current => Current;

    //===========================================
    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        _posicao++;

        return _posicao < _dias.Length;
    }

    public void Reset()
    {
        _posicao = -1;
    }
}
