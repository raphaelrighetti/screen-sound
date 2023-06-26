using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resultado = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resultado)!;

        //foreach (var musica in musicas)
        //{
        //    musica.ExibirDetalhes();
        //}

        foreach (var musica in musicas)
        {
            musica.ExibirDetalhes();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Deu pau: {ex.Message}");
    }
}
