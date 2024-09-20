using program;

namespace Library.Tests;

public class CompuertasTest
{
    [Test]
    public void TestCompuertaAND_VV_True() //Probamos la compuerta AND con dos valores verdaderos, debe retornar True
    {
        CompuertaAND andGate= new CompuertaAND("ANDTest1", LogicalTrue.Instance);
        andGate.AddInput(LogicalTrue.Instance);

        bool resulado = andGate.Output;
        
        Assert.That(resulado, Is.EqualTo(true));
    }

    [Test]
    public void TestCompuertaAND_VF_False() //Probamos la compuerta AND con el primer valor verdadero y el segundo falso, debe retornar False
    {
        CompuertaAND andGate2= new CompuertaAND("ANDTest2", LogicalTrue.Instance);
        andGate2.AddInput(LogicalFalse.Instance);

        bool resulado = andGate2.Output;
        
        Assert.That(resulado, Is.EqualTo( false));
    }
    
    [Test]
    public void TestCompuertaOR_VV_True() //Probamos la compuerta OR con dos primeros valores verdaderos, debe retornar TRUE
    {
        CompuertaOR orGate1= new CompuertaOR("ORTest1", LogicalTrue.Instance);
        orGate1.AddInput(LogicalTrue.Instance);

        bool resulado = orGate1.Output;
        
        Assert.That(resulado, Is.EqualTo( true));
    }
    
    [Test]
    public void TestCompuertaOR_FFF_False() //Probamos la compuerta OR con tres variables False, debe retornar False
    {
        CompuertaOR orGate2= new CompuertaOR("ORTest2", LogicalFalse.Instance);
        LogicalFalse false1 = new LogicalFalse();
        orGate2.AddInput(false1);
        LogicalFalse false2 = new LogicalFalse();
        orGate2.AddInput(false2);
        

        bool resulado = orGate2.Output;
        
        Assert.That(resulado, Is.EqualTo( false));
    }

    [Test]
    public void TestCompuertaNOT_True() //Probamos la compuerta NOT con una sola variable, la entrada es false, el retorno debe ser true.
    {
        LogicalFalse entradaNot = new LogicalFalse();
        CompuertaNOT notGate1 = new CompuertaNOT("NotTest1", entradaNot);
        
        Assert.That(notGate1.Output, Is.EqualTo(true));
    }
}