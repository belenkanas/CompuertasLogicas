namespace program;

public class CompuertaNOT: IValorVerdad
{
    public string Name { get; set; }
    private IValorVerdad input;

    public CompuertaNOT(string name, IValorVerdad input)
    {
        this.Name = name;
        this.input = input;
    }

    public bool Output
    {
        get
        {
            return !this.input.Output;
        }
    }
}