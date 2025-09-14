namespace P02_Operacoes.Models;
internal static class Ranking 
{
    public static void MaisTocadas(Playlist playlist1, Playlist playlist2)
    {
        Dictionary<Musica, int> ranking = [];

        foreach(var m in playlist1)
        {
            ranking.Add(m, 1);
        }

        foreach(var m in playlist2)
        {
            if (ranking.TryGetValue(m, out int total))
            {
                total++;
                ranking[m] = total;
            }
            else
            {
                ranking[m] = 1;
            }
        }

        List<KeyValuePair<Musica, int>> maisTocadas = [.. ranking];
        maisTocadas.Sort(new RankingComparer());

        Console.WriteLine("Top 3 músicas mais tocadas");

        int count = 1;
        foreach (var m in maisTocadas)
        {
            Console.WriteLine($"- {m.Key.Titulo}");
            count++;
            if (count > 3) break;
        }
    }


}
