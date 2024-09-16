namespace Program;

public class CompuertaAND : IValorVerdad
{
    public string Name { get; set; }
    private List<int> Entradas = new ArrayList;

    public CompuertaAND(string name, List<int> entradas)
    {
        this.Name = name;
        this.Entradas = entradas;
    }
    public void agregarValor(IValorVerdad);

    public IValorVerdad evaluar();
}