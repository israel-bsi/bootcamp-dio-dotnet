using Calculadora;

namespace CalculadoraTestes;
public class ValidacoesStringsTests
{
    private readonly ValidacoesStrings _validacoesStrings;

    public ValidacoesStringsTests()
    {
        _validacoesStrings = new ValidacoesStrings();
    }
    [Fact]
    public void DeveContar3CaracteresEmOlaERetornar3()
    {
        //Arrange
        var texto = "Ola";
        //Act
        var resultado = _validacoesStrings.ContarCaracteres(texto);
        //Assert
        Assert.Equal(3, resultado);
    }
}