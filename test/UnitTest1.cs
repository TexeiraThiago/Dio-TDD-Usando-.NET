using src;

namespace test;

public class UnitTest1
{   private Calculadora _calc = new();

    [Theory]
    [InlineData(1, 2, 3)]
    public void TestSomar(int val1, int val2, int valorEsperado)
    {   
    
        //Action
        var resultado = _calc.Somar(val1, val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int valorEsperado)
    {   
    
        //Action
        var resultado = _calc.Multiplicar(val1, val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(6, 6, 0)]
    public void TestSubtrair(int val1, int val2, int valorEsperado)
    {   
    
        //Action
        var resultado = _calc.Subtrair(val1, val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void TestDividir(int val1, int val2, int valorEsperado)
    {   
    
        //Action
        var resultado = _calc.Dividir(val1, val2);
        //Assert
        Assert.Equal(valorEsperado, resultado);
    }

    [Fact]
    public void TestarDivisaoPorZero() 
    {
        Assert.Throws<DivideByZeroException>( () => 
            _calc.Dividir(3,0)
        );
    }

    [Fact]
    public void TestarHistorico() 
    {   
        _calc.Somar(1,2);
        _calc.Somar(1,2);
        _calc.Somar(1,2);
        _calc.Somar(1,2);

        var lista = _calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}