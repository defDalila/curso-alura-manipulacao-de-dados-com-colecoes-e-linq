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

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Musica other) return this.Titulo.Equals(other.Titulo) &&
                this.Artista.Equals(other.Artista);

        return false;
    }

    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}
