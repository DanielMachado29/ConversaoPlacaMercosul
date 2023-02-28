using System;
using System.Collections.Generic;
using Xunit;

namespace ConversaoPlacaMercosul.Testes
{
    public class PlacaCinzaValidacoesTestes
    {
        [Fact]
        public void TestePlacaVazia()
        {
            var placaCinza = new PlacaCinza(String.Empty);
            string saidaEsperada = "A placa é obrigatória.";
            string saidaObtida = placaCinza.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteTamanhoIncorreto()
        {
            var placaCinza = new PlacaCinza("ABC123");
            string saidaEsperada = "A placa deve ter 7 caracteres.";
            string saidaObtida = placaCinza.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TestePrimeirosCaracteresInvalidos()
        {
            var placaCinza = new PlacaCinza("1234567");
            string saidaEsperada = "Os três primeiros caracteres da placa devem ser letras.";
            string saidaObtida = placaCinza.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }

        [Fact]
        public void TesteUltimosCaracteresInvalidos()
        {
            var placaCinza = new PlacaCinza("ABC123A");
            string saidaEsperada = "Os quatro últimos caracteres da placa devem ser números.";
            string saidaObtida = placaCinza.ValidarPlaca();
            Assert.Equal(saidaEsperada, saidaObtida);
        }


    }
}