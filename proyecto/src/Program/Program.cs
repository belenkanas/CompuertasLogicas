using program;

class Program
{
    static void Main(string[] args)
    {
       //Ejemplo de prueba:
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
        Console.WriteLine($"Resultado intermedio de compuertas {not3.Name}: {not3.Output} \n");
        
        
        
        //Ejemplo de GarageGate:
        Console.WriteLine($"GarageGate:");
        //Primer compuerta (ab)
        CompuertaAND ab = new CompuertaAND("AB", LogicalTrue.Instance); //primero comienza con la entrada a
        ab.AddInput(LogicalTrue.Instance); // le agrega la entrada b.
        Console.WriteLine($"Resultado primer compuerta (ab): {ab.Output}");
        
        //Segunda compuerta (/ab)
        CompuertaNOT aNegado = new CompuertaNOT("/A", LogicalTrue.Instance);
        CompuertaNOT bNegado = new CompuertaNOT("/B", LogicalTrue.Instance);
        CompuertaAND abNegado = new CompuertaAND("/AB", aNegado);
        abNegado.AddInput(bNegado);
        Console.WriteLine($"Resultado de segunda compuerta (/ab): {abNegado.Output}");
        
        //Suma de compuertas (ab + /ab)
        CompuertaOR abORab = new CompuertaOR("AB+/AB", ab);
        abORab.AddInput(abNegado);
        Console.WriteLine($"Suma de compuertas: {abORab.Output}");
        
        //Ultima compuerta (ab + /ab)c
        CompuertaAND abORc = new CompuertaAND("ABC", LogicalTrue.Instance);
        abORc.AddInput(abORab);
        Console.WriteLine($"Resultado total de la función de las compuertas : (ab + /ab)c: {abORc.Output}");
    }
}

