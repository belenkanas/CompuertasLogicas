namespace program;

// La clase CompuertaNOT implementa la interfaz IValorVerdad

public class CompuertaNOT: IValorVerdad
{
    public string Name { get; set; }
    private IValorVerdad input;            		//Entrada de tipo IValorVerdad 

    public CompuertaNOT(string name, IValorVerdad input)
    {
        this.Name = name;
        this.input = input;
    }

	//Método que devuelve el resultado de la operación NOT
    public bool Output
    {
        get
        {
            return !this.input.Output;      	//Devuelve el valor opuesto a la entrada
        }
    }
}