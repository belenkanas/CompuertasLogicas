using System.Collections;

namespace program;

// La clase CompuertaAND implementa la interfaz IValorVerdad

public class CompuertaAND : IValorVerdad
{
	//Estado
    public string Name { get; set; }
    private List<IValorVerdad> inputs = new List<IValorVerdad>();

    public CompuertaAND(string name, IValorVerdad firstInput)
    {
        this.Name = name;
        this.inputs.Add(firstInput);
    }
	
	//Método que calcula y devuelve el resultado de la operación AND de las entradas dadas
    public bool Output
    {
        get
        {
            bool result = this.inputs[0].Output;             //Resultado de la salida de la primera entrada
            for (int i = 1; i < this.inputs.Count; i++)      //Recorre todas las demas entradas y aplica la operación AND
            {
                result = result && this.inputs[i].Output;    //Comprueba si el resultado anterior sigue siendo verdadero con la nueva entrada
            }

            return result; 
        }
    }
	
	//Método para agregar nuevas entradas a la compuerta AND
    public void AddInput(IValorVerdad input)
    {
        this.inputs.Add(input);                             //Agrega la nueva entrada a la lista
    }
    
}

