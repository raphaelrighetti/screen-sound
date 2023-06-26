using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    [JsonConstructor]
    public Musica(string? artist, string? song, int duration_ms, string? genre)
    {
        Artist = artist;
        Song = song;
        Duration_Ms = duration_ms;
        Genre = genre;

        Init();
    }

    public string? Artista { get; set; }
    public string? Nome { get; set; }
    public int Duracao { get; set; }
    public string[]? Generos { get; set; }

    public string? Artist { get; set; }
    public string? Song { get; set; }
    public int Duration_Ms { get; set; }
    public string? Genre { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Informações da música:\n");

        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artirsta: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine("Gêneros:\n");
        foreach (string genero in Generos!)
        {
            Console.WriteLine($"    - {genero}");
        }

        Console.WriteLine();
    }

    void Init()
    {
        Nome = Song;
        Artista = Artist;
        Duracao = Duration_Ms;
        Generos = ConverteGeneros(Genre!);
    }

    string[] ConverteGeneros(string generos)
    {
        return generos.Split(",", StringSplitOptions.TrimEntries);
    }
}
