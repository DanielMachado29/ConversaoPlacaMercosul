using System;
using System.Collections.Generic;
using Xunit;

namespace ConversaoPlacaMercosul.Testes
{
    public class ConversaoPlacaTestes
    {
        [Fact]
        public void ConversaoPlacaCinzaParaMercosul()
        {
            var placaCinza = new PlacaCinza("AAA1111");
            string saidaEsperada = "AAA1B11";
            string saidaObtida = placaCinza.ConvertePlacaCinzaParaMercosul(placaCinza.Placa);
            Assert.Equal(saidaEsperada, saidaObtida);
        }
    }
}
