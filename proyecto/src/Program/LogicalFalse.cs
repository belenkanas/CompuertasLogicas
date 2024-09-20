namespace program;

public class LogicalFalse: IValorVerdad
{
    private LogicalFalse()
    {
        
    }

    public static IValorVerdad Instance { get; } = new LogicalFalse();

    public bool Output
    {
        get { return false; }
    }
}