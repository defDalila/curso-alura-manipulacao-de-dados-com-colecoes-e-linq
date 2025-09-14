using P02_Operacoes.Models;

Console.Clear();

#region Declaração e Instanciação das músicas...
Musica m1 = new() { Titulo = "Que Pais é Esse?", Artista = "Legião Urbana", Duracao = 350 };
Musica m2 = new() { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var m3 = new Musica
{
    Titulo = "Pro Dia Nascer Feliz",
    Artista = "Barão Vermelho",
    Duracao = 345
};
var m4 = new Musica
{
    Titulo = "Eduardo e Mônica",
    Artista = "Legião Urbana",
    Duracao = 530
};
var m5 = new Musica
{
    Titulo = "Geração Coca-Cola",
    Artista = "Legião Urbana",
    Duracao = 380
};
#endregion

var rockNacional = new Playlist { Nome = "Rock Nacional" };
Playlist rockeando = new() { Nome = "Rockeando" };

rockeando.Add(m1);
rockeando.Add(m2);
rockeando.Add(m3);
rockeando.Add(m4);
rockeando.Add(m5);

rockeando.ExibirPlaylist();

Ordenacoes(rockeando);


//--------------------------------------------------------
#region Etapas...
static void AntesDeUtilizarICollection(Musica m1, Musica m2, Musica m3, Musica m4, Musica m5, Playlist rockNacional)
{
    rockNacional.AdicionarMusica(m1);
    rockNacional.AdicionarMusica(m2);
    rockNacional.AdicionarMusica(m3);
    rockNacional.AdicionarMusica(m4);
    rockNacional.AdicionarMusica(m5);

    rockNacional.ExibirPlaylist();
    Console.WriteLine();
}

static void RemoverMusicaDaPlaylist(Playlist rockeando)
{
    rockeando.DeleteMusic("Eduardo e Mônica");
    rockeando.ExibirPlaylist();
}

static void SelecionarMusicaAleatoria(Playlist rockeando)
{
    var aleatoria = rockeando.GetRandomMusic();
    if (aleatoria is not null)
    {

        Console.WriteLine($"Música Aleatória: {aleatoria.Titulo}");
    }
    else
    {
        Console.WriteLine("Playlist vazia!");
    }
}

static void Ordenacoes(Playlist rockeando)
{
    rockeando.SortByDuration();
    rockeando.ExibirPlaylist();

    rockeando.SortByArtist();
    rockeando.ExibirPlaylist();

    rockeando.SortBySong();
    rockeando.ExibirPlaylist();
}
#endregion