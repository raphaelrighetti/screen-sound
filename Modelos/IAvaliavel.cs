namespace ScreenSound.Modelos;

internal interface IAvaliavel
{
    public IEnumerable<int> Notas { get; }
    public int Media { get; }

    public void Avaliar(Avaliacao avaliacao);
}
