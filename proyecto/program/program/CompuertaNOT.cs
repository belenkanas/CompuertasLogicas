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
                if (input.Output == 1)
                    return 0;
                else if (input.Output == 0)
                    return 1;
                else
                {
                    var salida = input.Calcular();
                    if (salida == 0)
                        return 1;
                    else
                        return 0;
                }
            }
}
}
