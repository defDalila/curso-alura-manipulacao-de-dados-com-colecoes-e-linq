using P01_IntroColecoes.Models;
using System.Collections;

Console.Clear();

var pares = NumerosParesComBreak();

int contador = 0;
foreach (var item in pares)
{
    contador++;
    Console.WriteLine(item);

    if (contador > 5) break;
}

static IEnumerable<int> NumerosParesComBreak()
{
    int i = 0;
    while (true)
    {
        Console.WriteLine($"Processando Elemento {i}...");
        yield return i * 2;
        if (i > 100)
        {
            yield break;
        }
        i++;
    }
}

#region Declaração collections ...
//  coleção string
var diasDaSemana1 = new string[] { "Domingo", "Segunda", "Terça", "Quarta", "Quinta",
                                    "Sexta", "Sábado"};

// usando a coleção List<T>
var carrinho = new List<Produto>()
{
    new Produto(){Nome = "Leite", Preco = 6.59},
    new Produto(){Nome = "Manteiga", Preco = 4.99}
};

#endregion

#region Métodos com os exemplos ...

static void UsandoArrayList()
{
    // ArrayList: Não restringe o tipo do Elemento
    var diasDaSemana1 = new ArrayList { "Domingo", "Segunda", "Terça", "Quarta", "Quinta",
                                    "Sexta", "Sábado" };

    var carrinho1 = new ArrayList()
    {
        new Produto(){Nome = "Leite", Preco = 6.59},
        new Produto(){Nome = "Manteiga", Preco = 4.99},
        "Domingo" // aceita diferentes tipos de elementos
    };
}

static void PercorrendoComFor(List<Produto> carrinho)
{
    for (int i = 0; i < carrinho.Count; i++)
    {
        var produto = carrinho[i];
        Console.WriteLine($"Produto {i + 1}: {produto.Nome}");
    }
    Console.WriteLine();
}

static void PercorrendoComForEach(List<Produto> carrinho)
{
    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
    Console.WriteLine();
}

static void UsarEnumeratorParaPercorrerUmaClasse()
{
    DiasDaSemana diasDaSemmana = new();

    foreach (var dia in diasDaSemmana)
    {
        Console.WriteLine(dia);
    }

    // foreach por debaixo dos panos!!!
    var enumerator = diasDaSemmana.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }
}

static void PercorrerIEnuberableSemYield()
{
    var pares = GerarNumerosPares(1000);

    //Console.WriteLine(string.Join(' ', pares));

    int contador = 0;
    foreach (var item in pares)
    {
        contador++;
        Console.Write(item);
        Console.Write(" ");

        if (contador > 5) break;
    }

    // trabalhar com tamanho que não é fixo
    static IEnumerable<int> GerarNumerosPares(int totalDeNumeros)
    {
        var lista = new List<int>();

        for (int i = 0; i < totalDeNumeros; i++)
        {
            Console.WriteLine($"Processando o elemento {i}");
            lista.Add(i * 2);
        }
        return lista;
    }
}

static void PercorrerIEnumerableComYield()
{
    var pares = CriarNumerosPares(1000);


    int contador = 0;
    foreach (var item in pares)
    {
        contador++;
        Console.WriteLine(item);
        Console.Write(" ");

        if (contador > 5) break;
    }

    static IEnumerable<int> CriarNumerosPares(int totalDeNumeros)
    {
        for (var i = 0; i < totalDeNumeros; i++)
        {
            Console.WriteLine($"Processando o elemento {i}");
            yield return i * 2;
        }
    }
}



#endregion