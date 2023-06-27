using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = 
            await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        musicas = musicas.OrderBy(musica => musica.Nome).ToList();

        foreach (var musica in musicas)
        { 
            Console.WriteLine(musica);
            Console.WriteLine();
        }
    } catch (Exception ex)
    {
        Console.WriteLine($"Deu pau: {ex.Message}");
    }
}
