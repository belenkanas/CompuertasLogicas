using program;

class Program
{
    static void Main(string[] args)
    {
        //Compuerta And con sus entradas
        CompuertaAND and1 = new CompuertaAND("AND-1", LogicalTrue.Instance);
        and1.AddInput(LogicalTrue.Instance);
        Console.WriteLine($"Resultado intermedio de compuerta {and1.Name} : {and1.Output}");
        
        //Compuerta Or con sus entradas
        CompuertaOR or2 = new CompuertaOR("OR-2", LogicalFalse.Instance);
        or2.AddInput(and1);
        Console.WriteLine($"Resultado intermedio de compuertas {or2.Name}: {or2.Output}");
        
        //Compuerta not
        CompuertaNOT not3 = new CompuertaNOT("NOT-3", or2);
        Console.WriteLine($"Resultado intermedio de compuertas {not3.Name}: {not3.Output}");
    }
}

