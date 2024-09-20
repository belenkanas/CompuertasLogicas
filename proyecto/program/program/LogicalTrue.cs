namespace program;

//La clase LogicalTrue implementa la interfaz IValorVerdad, esta clase representa un valor lógico verdadero

public class LogicalTrue: IValorVerdad
{
    public static IValorVerdad Instance { get; } = new LogicalTrue();     //Instancia de LogicalTrue

	//Método que devuelve siempre true
    public bool Output
    {
        get
        {
            return true;
        }
    }
}