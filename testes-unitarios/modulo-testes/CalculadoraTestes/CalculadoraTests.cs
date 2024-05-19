using Calculadora;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private readonly CalculadoraImp _calculadoraImp;
    public CalculadoraTests()
    {
        _calculadoraImp = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        //Arrange
        var num = 5;
        var num2 = 10;
        //Act
        var resultado = _calculadoraImp.Somar(num, num2);
        //Assert
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10eRetornar20()
    {
        //Arrange
        var num = 10;
        var num2 = 10;
        //Act
        var resultado = _calculadoraImp.Somar(num, num2);
        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        var num = 4;
        //Act
        var resultado = _calculadoraImp.EhPar(num);
        //Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new[] {2, 4, 6, 8, 10} )]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act
        //Assert
        Assert.All(numeros, num => Assert.True(_calculadoraImp.EhPar(num)));
    }
}