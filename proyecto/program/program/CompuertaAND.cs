using System.Collections;

namespace program;

public class CompuertaAND : IValorVerdad
{
    public string Name { get; set; }
    List<IValorVerdad> Entradas = new List<IValorVerdad>();

    public CompuertaAND(string name, List<IValorVerdad> entradas)
    {
        this.Name = name;
        this.Entradas = entradas;
    }

    public void agregarValor(IValorVerdad vv)
    {
        this.Entradas.Add(vv);
    }

    public IValorVerdad evaluar()
    {
        int prod = 1;
        foreach (IValorVerdad Entradas)
        {
            if (Entradas[elemento]== 0 || Entradas[elemento] == 1)
        }
    }
}

