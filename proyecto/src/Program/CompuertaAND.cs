using System.Collections;

namespace program;

/*
 * Clase que implementa los cálculos necesarios según el Algebra de Boole para la operación AND cuando se tienen entradas de caracter true o false.
 */
public class CompuertaAND : IValorVerdad
{
    public string Name { get; set; }
    private List<IValorVerdad> inputs = new List<IValorVerdad>(); //Para poder calcular el resultado, se crea una lista con todas las entradas que recibe la clase en cada parte del programa.

    public CompuertaAND(string name, IValorVerdad firstInput) //Al crear el objeto, se pide el nombre del mismo y una primer entrada, la cual puede ser de valor verdadero o falso (LogicalTrue o LogicalFalse)
    {
        this.Name = name;
        this.inputs.Add(firstInput);
    }

    public bool Output
    {
        get
        {
            bool result = this.inputs[0].Output;
            for (int i = 1; i < this.inputs.Count; i++) // Si tiene más de una entrada, va a realizar una interación en cada elemento de la lista en la que implementa el uso de && para retornar un resultado booleano.
            {
                result = result && this.inputs[i].Output;
            }

            return result;
        }
    }

    public void AddInput(IValorVerdad input) //Como lo dice su nombre, mediante este método, se le agrega otra entrada a la lista para dsp calcular su resultado.
    {
        this.inputs.Add(input);
    }
    
}

