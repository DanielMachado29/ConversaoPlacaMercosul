using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConversaoPlacaMercosul.Testes
{
    public class PlacaMercosulValidacoesTestes
    {
        [Fact]
        public void TestePlacaVazia()
        {
            var placaMercosul = new PlacaMercosul(String.Empty);
            string saidaEsperada = "A placa é obrigatória.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteTamanhoIncorreto()
        {
            var placaMercosul = new PlacaMercosul("ABC123");
            string saidaEsperada = "A placa deve ter 7 caracteres.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TestePrimeirosCaracteresInvalidos()
        {
            var placaMercosul = new PlacaMercosul("1234567");
            string saidaEsperada = "Os três primeiros caracteres da placa devem ser letras.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteQuartoCaracterInvalido()
        {
            var placaMercosul = new PlacaMercosul("ABCA234");
            string saidaEsperada = "O quarto caracter da placa deve ser um número.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteQuintoCaracterInvalido()
        {
            var placaMercosul = new PlacaMercosul("ABC1234");
            string saidaEsperada = "O quinto caracter da placa deve ser uma letra.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteUltimosCaracteresInvalidos()
        {
            var placaMercosul = new PlacaMercosul("AAA1AA1");
            string saidaEsperada = "O sexto e sétimo caracteres da placa devem ser números.";
            string saidaObtida = placaMercosul.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }
    }
}
