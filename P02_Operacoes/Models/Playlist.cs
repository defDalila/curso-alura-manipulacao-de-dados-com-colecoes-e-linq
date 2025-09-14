using System.Collections;

namespace P02_Operacoes.Models;
internal class Playlist : ICollection<Musica>
{
    private List<Musica> _musicas = [];

    public string Nome { get; set; }
    public int Count => _musicas.Count;
    public bool IsReadOnly => false;

    public void Add(Musica item)
    {
        _musicas.Add(item);
    }

    public void Clear()
    {
        _musicas.Clear();
    }

    public bool Contains(Musica item)
    {
        return _musicas.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        _musicas.CopyTo(array, arrayIndex);
    }

    public bool Remove(Musica item)
    {
        return (_musicas.Remove(item));
    }

    public Musica? FindMusic(string nome)
    {
        foreach (Musica musica in _musicas)
        {
            if (musica.Titulo.ToUpper() == nome.ToUpper()) return musica;
        }
        return null;
    }

    public Musica? GetRandomMusic()
    {
        if (_musicas.Count == 0) return null;

        Random random = new();
        var index = random.Next(0, _musicas.Count);

        return _musicas[index];
    }

    public void DeleteMusic(string nome)
    {
        var result = FindMusic(nome);
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
            Console.WriteLine($"Título: {musica.Titulo}\n" +
                $"Artista: {musica.Artista}\n" +
                $"Duração: {musica.Duracao}s");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

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


    public IEnumerator<Musica> GetEnumerator()
    {
        return _musicas.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Antes de Implementar ICollection
    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

}
