using System.Collections;

namespace P02_Operacoes.Models;
internal partial class Playlist : ICollection<Musica>
{
    private HashSet<Musica> _setMusicas = [];
    private List<Musica> _musicas = [];

    public string Nome { get; set; }
    public int Count => _musicas.Count;
    public bool IsReadOnly => false;

    public void Add(Musica item)
    {
        if (_setMusicas.Add(item))
        {
            _musicas.Add(item);
        }
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


    public IEnumerator<Musica> GetEnumerator()
    {
        return _musicas.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
