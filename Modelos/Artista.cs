namespace ScreenSound.Modelos;

internal class Artista : IAvaliavel
{
    private readonly List<Album> albuns = new();
    private readonly List<Avaliacao> notas = new();

    public Artista(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public IEnumerable<Album> Albuns => albuns;

    public IEnumerable<int> Notas => notas.ConvertAll<int>(nota => nota.Nota);
    public int Media => (int)Notas.Average();

    public void Avaliar(Avaliacao avaliacao)
    {
        notas.Add(avaliacao);
    }

    public void AdicionarAlbum(Album album)
    {
        if (albuns.Contains(album)) return;

        albuns.Add(album);
    }
}
