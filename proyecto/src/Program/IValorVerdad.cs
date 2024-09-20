namespace program
{
    /*
     * Tipo IValorVerdad de la cual heredan las clases CompuertaAND, CompuertaNOT, CompuertaOR, LogicalTrue y LogicalFalse.
     * Estas clases comparten un método en común, que es realizar un resultado (true o false) segun las entradas que recibe cada función booleana.
     */
    public interface IValorVerdad
    {
        public bool Output { get; }
        
    }
}