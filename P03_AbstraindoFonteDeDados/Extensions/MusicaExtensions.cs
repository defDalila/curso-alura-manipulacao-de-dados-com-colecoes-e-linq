using P03_AbstraindoFonteDeDados.Models;

namespace P03_AbstraindoFonteDeDados.Extensions;

internal static class MusicaExtensions
{
    // Esse this antes do primeiro parâmetro transforma o método em um método de extensão
    public static IEnumerable<Musica> Filtrar(this IEnumerable<Musica> musicas, Func<Musica, bool> filtro)
    {
        foreach ( var musica in musicas )
        {
            if ( filtro(musica) )
                yield return musica;
        }
    }



    public static void ExibirMusicas(this IEnumerable<Musica> musicas)
    {
        int i = 1;
        foreach ( var musica in musicas )
        {
            Console.WriteLine($"\t - {musica.Titulo} | {musica.Artista} | ({musica.Duracao} s)");
            i++;

            if ( i > 10 )
                break;
        }
    }
}
