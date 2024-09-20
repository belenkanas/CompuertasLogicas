namespace program;

public class LogicalFalse: IValorVerdad
{
    public LogicalFalse()
    {
        
    }

    public static IValorVerdad Instance { get; } = new LogicalFalse();

    public bool Output
    {
        get { return false; }
    }
}