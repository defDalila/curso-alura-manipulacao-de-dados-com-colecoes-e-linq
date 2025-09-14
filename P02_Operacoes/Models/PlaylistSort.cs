namespace P02_Operacoes.Models;
internal partial class Playlist : ICollection<Musica>
{
    public void SortByDuration()
    {
        _musicas.Sort();
    }

    public void SortByArtist()
    {
        _musicas.Sort(new ArtistaComparer());
    }

    public void SortBySong()
    {
        _musicas.Sort(new TituloComparer());
    }
}
