using P03_AbstraindoFonteDeDados.Extensions;
using P03_AbstraindoFonteDeDados.Models;


Console.Clear();

using FileStream file = new FileStream("musicas.csv", FileMode.Open, FileAccess.Read);
using StreamReader reader = new StreamReader(file);

var musicas = ExtrairMusicas(reader)
              .Filtrar(m => m.Titulo.StartsWith('B'))
              .Filtrar(a => a.Artista.Equals("Coldplay"));

musicas.ExibirMusicas();



static IEnumerable<Musica> ExtrairMusicas(StreamReader reader)
{
    var linha = reader.ReadLine();
    while ( linha is not null )
    {
        var conteudoLinha = linha.Split(';');
        var musica = new Musica
        {
            Titulo = conteudoLinha[0],
            Artista = conteudoLinha[1],
            Duracao = Convert.ToInt32(conteudoLinha[2]),
        };

        yield return musica;
        linha = reader.ReadLine();
    }
}

static void MetodosParaPassarComoFiltro( )
{
    bool MusicasColdplay(Musica musica) => musica.Artista.Equals("Coldplay");
    bool TituloComecaComA(Musica musica) => musica.Titulo.StartsWith('A');
    bool DuracaoAcimaDeCincoMinutos(Musica musica) => musica.Duracao >= 300;
}