namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private readonly List<Musica> musicas = new();
    private readonly List<Avaliacao> notas = new();

    public Album(string nome, Artista artista)
    {
        Nome = nome;
        Artista = artista;

        artista.AdicionarAlbum(this);
    }

    public string Nome { get; set; }
    public Artista Artista { get; }
    public int Duracao => musicas.Sum(musica => musica.Duracao);
    public IEnumerable<Musica> Musicas => musicas;

    public IEnumerable<int> Notas => notas.ConvertAll<int>(nota => nota.Nota);
    public int Media => (int)Notas.Average();

    public void Avaliar(Avaliacao avaliacao)
    {
        notas.Add(avaliacao);
    }

    public void AdicionarMusica(Musica musica)
    {
        if (musicas.Contains(musica)) return;

        musicas.Add(musica);
    }

    public override string ToString()
    {
        string output = @$"
- Álbum: {Nome}
- Artista: {Artista.Nome}
- Duração (segundos): {Duracao}
- Músicas:";

        foreach (Musica musica in Musicas)
        {
            string textoMusica = $"\n    - {musica.Nome}";

            output += textoMusica;
        }

        return output;
    }
}