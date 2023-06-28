using ScreenSound.Modelos;

namespace ScreenSound.Filtros;

internal class LinqUtils
{
    public static void ListarTodosOsGeneros(List<Musica> musicas)
    {
        var generos = string
            .Join(", ", musicas
            .Select(musica => musica.TextoGenero)
            .Distinct())
            .Split(", ", StringSplitOptions.TrimEntries)
            .Distinct()
            .ToList();

        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void ListarTodosArtistas(List<Musica> musicas)
    {
        var artistas = musicas
            .OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void ListarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistas = musicas
            .Where(musica => musica.TextoGenero!.Contains(genero))
            .Select(musica => musica.Artista)
            .Distinct()
            .ToList();

        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void ListarMusicasDoArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas
            .Where(musica => musica.Artista!.Equals(artista))
            .ToList();

        Console.WriteLine($"{artista}:\n");

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void ListarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasDoAno = musicas
            .Where(musica => musica.Ano == ano)
            .ToList();

        Console.WriteLine($"Músicas de {ano}\n");

        foreach (var musica in musicasDoAno)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista}");
        }
    }

    public static void ListarMusicasPorTonaldade(List<Musica> musicas, string tonalidade)
    {
        var musicasDaTonalidade = musicas
            .Where(musica => musica.Tonalidade.Equals(tonalidade))
            .ToList();

        Console.WriteLine($"Musicas da tonalidade: {tonalidade}\n");

        foreach (var musica in musicasDaTonalidade)
        {
            Console.WriteLine($"- {musica.Nome} - {musica.Artista}");
        }
    }
}
