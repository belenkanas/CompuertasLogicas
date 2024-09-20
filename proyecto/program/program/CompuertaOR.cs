namespace program;

// La clase CompuertaOR implementa la interfaz IValorVerdad

public class CompuertaOR : IValorVerdad
{
    public string Name { get; set; }
    private List<IValorVerdad> inputs = new List<IValorVerdad>();    	//Lista de entradas de tipo IValorVerdad

    public CompuertaOR(string name, IValorVerdad firstInput)
    {
        this.Name = name;
        this.inputs.Add(firstInput);									//Agrega la primera entrada a la lista
    }

	//Método que devuelve el resultado de la operación OR
    public bool Output
    {
        get
        {
            bool result = this.inputs[0].Output;						//Resultado de la salida de la primer entrada
            for (int i = 1; i < this.inputs.Count; i++)					//Recorre todas las demas entradas y aplica la operación OR
            {
                result = result || this.inputs[i].Output;				//Verifica si el resultado anterior o la nueva entrada son verdaderos
            }

            return result;
        }
    }
    
	//Método que agrega nuevas entradas a la compuerta
    public void AddInput(IValorVerdad input)
    {
        this.inputs.Add(input);											//Agrega nuevas entradas a la lista
    }
}