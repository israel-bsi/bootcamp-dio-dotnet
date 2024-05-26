using System;
using CalculadoraDio;
using Xunit;

namespace CalculadoraDioTest
{
    public class CalculadoraTest
    {
        public Calculadora Calculadora()
        {
            var data = DateTime.Now.ToShortDateString();
            var calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            var calc = Calculadora();
            var resultadoCalculadora = calc.Somar(val1, val2);
            
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TesteSubtracao(int val1, int val2, int resultado)
        {
            var calc = Calculadora();
            var resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            var calc = Calculadora();
            var resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            var calc = Calculadora();
            var resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TesteDivisaoPorZero()
        {
            var calc = Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0));
        }

        [Fact]
        public void TesteHistorico()
        {
            var calc = Calculadora();
            calc.Somar(1, 2);
            calc.Somar(2, 3);
            calc.Somar(5, 2);
            calc.Somar(6, 1);
            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}