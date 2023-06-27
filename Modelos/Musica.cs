namespace ScreenSound.Modelos;

internal class Musica : IAvaliavel
{
    private readonly List<Avaliacao> notas = new();

    public Musica(string nome, string genero, int duracao, Artista artista, Album album)
    {
        Nome = nome;
        Genero = genero;
        Duracao = duracao;
        Artista = artista;
        Album = album;

        Album.AdicionarMusica(this);
        Artista.AdicionarAlbum(Album);
    }

    public string Nome { get; set; }
    public string Genero { get; set; }
    public int Duracao { get; }
    public Artista Artista { get; }
    public Album Album { get; }

    public IEnumerable<int> Notas => notas.ConvertAll<int>(nota => nota.Nota);
    public int Media => (int)Notas.Average();

    public void Avaliar(Avaliacao avaliacao)
    {
        notas.Add(avaliacao);
    }
}
