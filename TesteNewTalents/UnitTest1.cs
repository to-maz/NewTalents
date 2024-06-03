using NewTalents;
using Xunit;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        public Calculadora construirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();
            int resultadoCalculadora = calculadora.somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(5, 5, 0)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();
            int resultadoCalculadora = calculadora.subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();
            int resultadoCalculadora = calculadora.multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calculadora = construirClasse();
            int resultadoCalculadora = calculadora.dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }
        [Fact]
        public void TEstarDivuisaoPorZero()
        {
            Calculadora calc = construirClasse();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3,0)
                );
        }
        [Fact]
        public void Testarhistorico()
        {
            Calculadora calc = construirClasse();
            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
        
    }
}