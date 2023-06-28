using ScreenSound.Filtros;
using ScreenSound.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta = 
            await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqUtils.ListarTodosOsGeneros(musicas);
        //LinqUtils.ListarTodosArtistas(musicas);
        //LinqUtils.ListarArtistasPorGenero(musicas, "hip hop");
        //LinqUtils.ListarMusicasDoArtista(musicas, "Michael Jackson");
        //LinqUtils.ListarMusicasPorAno(musicas, 2010);

        MusicasFavoritas favoritasDoRapha = new("Raphael");

        favoritasDoRapha.AdicionarMusicaFavorita(musicas[0]);
        favoritasDoRapha.AdicionarMusicaFavorita(musicas[1]);
        favoritasDoRapha.AdicionarMusicaFavorita(musicas[2]);
        favoritasDoRapha.AdicionarMusicaFavorita(musicas[3]);
        favoritasDoRapha.AdicionarMusicaFavorita(musicas[4]);

        favoritasDoRapha.ListarMusicasFavoritas();
        favoritasDoRapha.GerarArquivoJson();
    } catch (Exception ex)
    {
        Console.WriteLine($"Deu pau: {ex.Message}");
    }
}
