namespace program
{
	//IvalorVerdad es una interfaz que representa compuertas lógicas
	//Las clases CompuertaAND, CompuertaOR, CompuertaNOT, LogicalTrue y LogicalFalse la utilizan

    public interface IValorVerdad
    {
        public bool Output { get; }			//Propiedad que devuelve true o false
        
    }
}