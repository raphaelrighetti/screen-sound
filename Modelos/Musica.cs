using System.Text.Json.Serialization;

namespace ScreenSound.Modelos;

internal class Musica
{
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("song")]
    public string? Nome { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string? TextoGenero { get; set; }

    public override string ToString()
    {
        return $"Artista: {Artista}, Nome: {Nome}, Duração: {Duracao}, Gênero: {TextoGenero}";
    }
}
