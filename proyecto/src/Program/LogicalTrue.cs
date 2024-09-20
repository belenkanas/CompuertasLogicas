namespace program;

public class LogicalTrue: IValorVerdad
{
    public static IValorVerdad Instance { get; } = new LogicalTrue();
    public bool Output
    {
        get
        {
            return true;
        }
    }

   
}