namespace P02_Operacoes.Models;
internal partial class Playlist : ICollection<Musica>
{
    public Musica? BuscarMusica(string nome)
    {
        foreach (Musica musica in _musicas)
        {
            if (musica.Titulo.ToUpper() == nome.ToUpper()) return musica;
        }
        return null;
    }

    public Musica? SelecionarMusicaAleatoria()
    {
        if (_musicas.Count == 0) return null;

        Random random = new();

        var index = random.Next(0, _musicas.Count);
        return _musicas[index];
    }

    public void ExcluirMusica(string nome)
    {
        var result = BuscarMusica(nome);
        if (result is not null)
        {
            _musicas.Remove(result);
            Console.WriteLine($"Música '{nome}' excluída com sucesso!");
        }
        else
        {
            Console.WriteLine($"Música '{nome}' não encontrada");
        }
        Console.WriteLine();
    }

    public void ExibirPlaylist()
    {
        Console.WriteLine($"Exibindo as Músicas da Playlist - {Nome}");
        foreach (var musica in _musicas)
        {
            Console.WriteLine($"- Título: {musica.Titulo}\t" +
                $"Artista: {musica.Artista}\t" +
                $"Duração: {musica.Duracao}s");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    // Antes de Implementar ICollection
    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }
}
