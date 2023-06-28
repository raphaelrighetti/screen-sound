using System.Text.Json;

namespace ScreenSound.Modelos;

internal class MusicasFavoritas
{
    public MusicasFavoritas(string nome)
    {
        Nome = nome;
        ListaFavoritas = new List<Musica>();
    }

    public string Nome { get; set; }
    public List<Musica> ListaFavoritas { get; }

    public void AdicionarMusicaFavorita(Musica musica)
    {
        ListaFavoritas.Add(musica);
    }

    public void ListarMusicasFavoritas()
    {
        Console.WriteLine($"Musicas favoritas -> {Nome}");

        foreach (var musica in ListaFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }

        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        var obj = new
        {
            nome = Nome,
            musicas = ListaFavoritas
        };

        string json = JsonSerializer.Serialize(obj);
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        try
        {
            File.WriteAllText(nomeDoArquivo, json);

            Console.WriteLine($"Arquivo criado com sucesso em \"{Path.GetFullPath(nomeDoArquivo)}\"");
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
