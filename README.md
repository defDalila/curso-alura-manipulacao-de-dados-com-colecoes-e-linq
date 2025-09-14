<h1 align="center">
 Curso Alura | C#
</h1>

<h3 align="center" >
<i> <a href="https://cursos.alura.com.br/course/csharp-manipulacao-dados">Manipulação de dados com coleções e LINQ</a></i>.
</h3>
<br/>

<p align="center">        
  <a href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=cs,visualstudio,vscode,git,github" />
  </a><br>
  <i>Ferramentas utilizadas</i>
</p>

<br/>

## :dart: Objetivos de Aprendizagem

-   [x] Utilizar coleções para manipulação eficiente de dados em C#.
-   [x] Escolher entre tipos primitivos e customizados para representar informações.
-   [x] Compreender problemas e soluções para redimensionamento de arrays.
-   [x] Aplicar loops tradicionais (for e while) para percorrer coleções.
-   [x] Usar o foreach para iteração simplificada e mais legível.
-   [x] Comparar desempenho e legibilidade entre foreach e loops tradicionais.
-   [x] Implementar dicionários (Dictionary) para associação de chave-valor.
-   [x] Trabalhar com conjuntos (HashSet) e listas ordenadas (List).
-   [x] Aplicar filtros e ordenações com LINQ para consultas expressivas.
-   [x] Criar e manipular coleções imutáveis.
-   [x] Utilizar métodos de extensão para melhorar o trabalho com coleções.
-   [x] Aplicar interfaces como IEnumerable para padronizar coleções iteráveis.
-   [x] Utilizar IEnumerator para controlar a iteração de forma personalizada.
-   [x] Implementar iteração sob demanda com o operador yield.
-   [x] Otimizar o uso de memória e desempenho ao trabalhar com grandes coleções.

## 💼 Projetos

### :computer: [**Introdução às Coleções**](P01_IntroColecoes) 
   
   Projeto introdutório contendo códigos que abordam os seguintes tópicos:

-   Exemplificar a diferença entre `Array`, `ArrayList` e `List` e suas capacidades de redimensionamento;
-   O uso de Generics para garantir a segurança de tipo em coleções;
-   O uso do `yield` para criar iteradores de forma concisa e eficiente;
-   Implementação de classes iteráveis personalizadas com as interfaces `IEnumerable<T>` e `IEnumerator<T>`.
-   A importância de métodos como `MoveNext`, `Reset` e `Current` para gerenciar iterações.
-   O impacto positivo do `yield` na performance e otimização de memória ao lidar com coleções grandes.


### :computer: [Operações em Coleções](P02_Operacoes)

Foi realizado com base no seguinte cenário: 

> Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha controle total sobre a sequência de reprodução das músicas, permitindo reordená-las livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial quanto aleatório.
>

E para trabalhar as operações em operações, foi implementado as seguintes funcionalidades:

- [x] Criar as classes para musicas e playlist
- [x] Listar musicas da playlist
- [x] Adicionar musica à playlist
- [x] Obter uma musica especifica da playlist
- [x] Remover musica da playlist
- [x] Tocar uma musica aleatoria da playlist
- [x] Reordenar musicas segundo alguma logica especifica (ex. duracao)
- [x] Uma playlist nao pode ter musicas repetidas
- [x] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
- [x] Player de musica com:
- Fila de reproducao (para musicas avulsas e/ou playlists)
- Historico de reproducao