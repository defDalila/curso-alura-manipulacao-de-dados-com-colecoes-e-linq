namespace P02_Operacoes.Models;

public class Musica : IComparable
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public int CompareTo(object? obj)
    {
        if (obj is null) return -1;
        // como é inteiro, já implementa o IComparable por Definicao
        if (obj is Musica other) return this.Duracao.CompareTo(other.Duracao);
        return -1;
    }
}
