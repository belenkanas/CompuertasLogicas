namespace program;

//La clase LogicalFalse implementa la interfaz IValorVerdad, esta clase representa un valor lógico falso

public class LogicalFalse: IValorVerdad
{
	//Constructor privado para que no se creen instancias fuera de la clase
    private LogicalFalse()
    {
        
    }

    public static IValorVerdad Instance { get; } = new LogicalFalse();   //Instancia de LogicalFalse

	//Método que devuelve false
    public bool Output
    {
        get { return false; }
    }
}