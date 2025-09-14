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

var m6 = new Musica
{
    Titulo = "Será",
    Artista = "Legião Urbana",
    Duracao = 190
};

var m7 = new Musica
{
    Titulo = "Ainda É Cedo",
    Artista = "Legião Urbana",
    Duracao = 270
};

var m8 = new Musica
{
    Titulo = "Tempo Perdido",
    Artista = "Legião Urbana",
    Duracao = 310
};

var m9 = new Musica
{
    Titulo = "Pais e Filhos",
    Artista = "Legião Urbana",
    Duracao = 310
};

var m10 = new Musica
{
    Titulo = "Geração Coca-Cola",
    Artista = "Legião Urbana",
    Duracao = 230
};

var m11 = new Musica
{
    Titulo = "Índios",
    Artista = "Legião Urbana",
    Duracao = 290
};

var m12 = new Musica
{
    Titulo = "Eduardo e Mônica",
    Artista = "Legião Urbana",
    Duracao = 260
};

var m13 = new Musica
{
    Titulo = "Faroeste Caboclo",
    Artista = "Legião Urbana",
    Duracao = 540
};

var m14 = new Musica
{
    Titulo = "Que País É Este",
    Artista = "Legião Urbana",
    Duracao = 210
};

var m15 = new Musica
{
    Titulo = "Há Tempos",
    Artista = "Legião Urbana",
    Duracao = 260
};

var m16 = new Musica
{
    Titulo = "Meninos e Meninas",
    Artista = "Legião Urbana",
    Duracao = 240
};

var m17 = new Musica
{
    Titulo = "Monte Castelo",
    Artista = "Legião Urbana",
    Duracao = 330
};

var m18 = new Musica
{
    Titulo = "Será o Fim?",
    Artista = "Legião Urbana",
    Duracao = 200
};

var m19 = new Musica
{
    Titulo = "Vento no Litoral",
    Artista = "Legião Urbana",
    Duracao = 400
};

var m20 = new Musica
{
    Titulo = "Angra dos Reis",
    Artista = "Legião Urbana",
    Duracao = 230
};

#endregion

#region Declara as Playlists...
var rockNacional = new Playlist { Nome = "Rock Nacional" };
Playlist rockeando = new() { Nome = "Rockeando" };
Playlist legiao = new() { Nome = "As mais ouvidas de Legião Urbana" };
#endregion

#region Add musicas às playlists...
rockeando.Add(m1);
rockeando.Add(m2);
rockeando.Add(m3);
rockeando.Add(m4);
rockeando.Add(m5);
rockeando.Add(m2);
rockeando.Add(new Musica
{
    Titulo = "Pro Dia Nascer Feliz",
    Artista = "Barão Vermelho",
    Duracao = 345
});

legiao.Add(m5);
legiao.Add(m6);
legiao.Add(m7);
legiao.Add(m8);
legiao.Add(m9);
legiao.Add(m10);
legiao.Add(m11);
legiao.Add(m12);
legiao.Add(m13);
legiao.Add(m14);
legiao.Add(m15);
legiao.Add(m16);
legiao.Add(m17);
legiao.Add(m18);
legiao.Add(m19);
legiao.Add(m20);
#endregion


Player player = new();

player.AdicionarNaFila(m6);
player.AdicionarNaFila(m15);
player.AdicionarNaFila(m9);
player.AdicionarNaFila(m10);
player.AdicionarNaFila(m13);
player.AdicionarNaFila(m17);
player.AdicionarNaFila(rockeando);

player.ExibirFilaDeReproducao();

player.TocarProximaMusica();
player.ExibirFilaDeReproducao();
player.ExibirHistoricoDeReproducao();
player.TocarProximaMusica();
player.ExibirFilaDeReproducao();
player.ExibirHistoricoDeReproducao();
player.TocarMusicaAnterior();

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
    rockeando.ExcluirMusica("Eduardo e Mônica");
    rockeando.ExibirPlaylist();
}

static void SelecionarMusicaAleatoria(Playlist rockeando)
{
    var aleatoria = rockeando.SelecionarMusicaAleatoria();
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

static void ExibeRanking(Playlist rockeando, Playlist legiao)
{
    legiao.ExibirPlaylist();
    rockeando.ExibirPlaylist();
    Ranking.MaisTocadas(rockeando, legiao);
}
#endregion