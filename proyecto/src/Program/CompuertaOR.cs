namespace program;

public class CompuertaOR : IValorVerdad
{
    public string Name { get; set; }
    private List<IValorVerdad> inputs = new List<IValorVerdad>();

    public CompuertaOR(string name, IValorVerdad firstInput)
    {
        this.Name = name;
        this.inputs.Add(firstInput);
    }

    public bool Output
    {
        get
        {
            bool result = this.inputs[0].Output;
            for (int i = 1; i < this.inputs.Count; i++)
            {
                result = result || this.inputs[i].Output;
            }

            return result;
        }
    }
    
    public void AddInput(IValorVerdad input)
    {
        this.inputs.Add(input);
    }
}