
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly KalkulatorDelty _program;
        public UnitTest1()
        {
            _program = new KalkulatorDelty();
        }
        [Fact]
        public void TesObliczDelte_Zwraca_2_pierwiastki()
        {
            // arrange
            double delta = 25;
            double a = 2;
            double b = 3;
            // act
            var lol = KalkulatorDelty.ObliczPierwiastki(delta,a,b);
            // assert
            Assert.NotNull(lol);
            Assert.Equal("Pierwiastki równania kwadratowego to: x1 = 0,5, x2 = -2", lol);
        }
        [Fact]
        public void ObliczDelte_Zwraca_1_pierwiastek()
        {
            double delta = 0;
                double a = 1;
                double b = -4;
            var lol2 = KalkulatorDelty.ObliczPierwiastki(delta, a, b);
            Assert.NotNull(lol2);
            Assert.Equal("Równanie kwadratowe ma jeden pierwiastek: x = -2", lol2);
        }
        [Fact]
        public void ObliczDelte_Brak_Pierwiastow()
        {
            double delta = -139;
            double a = -1;
            double b = -1;
            var lol3 = KalkulatorDelty.ObliczPierwiastki(delta, a, b);
            Assert.NotNull(lol3);
            Assert.Equal("Równanie nie ma pierwiastków rzeczywistych.", lol3);
        }
        [Theory]
        [InlineData(0,1,4)]
        public void Zwraca_2(double delta, double a, double b)
        {
            var lol4 = KalkulatorDelty.ObliczPierwiastki(delta, a, b);
            Assert.NotNull(lol4);
            Assert.Equal("Równanie kwadratowe ma jeden pierwiastek: x = -2", lol4);

        }
    }
}