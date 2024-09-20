namespace program;

public class LogicalTrue: IValorVerdad //Clase que hereda características de IValorVerdad, la cual es el método de retornar un valor dsp de cierta operación.
{
    public static IValorVerdad Instance { get; } = new LogicalTrue(); 
    public LogicalTrue()
    {
        
    }
    public bool Output //Siempre su retorno será el valor booleano de true, esta clase es una representación de esto mismo.
    {
        get
        {
            return true;
        }
    }

   
}