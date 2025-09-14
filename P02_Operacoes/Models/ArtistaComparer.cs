namespace P02_Operacoes.Models;
internal class ArtistaComparer : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}
