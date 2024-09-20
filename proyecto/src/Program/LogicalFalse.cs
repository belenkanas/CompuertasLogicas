namespace program;

public class LogicalFalse: IValorVerdad //Clase que hereda características del tipo IValorVerdad
{
    public static IValorVerdad Instance { get; } = new LogicalFalse(); //Esto es para que las otras clases, e incluso el programa, puedan realizar una instancia para sus operaciones con este valor.
    public LogicalFalse()
    {
        //Al instanciarla no se necesita ningún parámetro
    }
    
    public bool Output
    {
        get { return false; } //Su valor de retorno siempre será false.
    }
}