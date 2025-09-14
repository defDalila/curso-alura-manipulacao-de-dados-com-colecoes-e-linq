using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Operacoes.Models;
internal class RankingComparer : IComparer<KeyValuePair<Musica, int>>
{

    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return x.Value.CompareTo(y.Value);
    }
}