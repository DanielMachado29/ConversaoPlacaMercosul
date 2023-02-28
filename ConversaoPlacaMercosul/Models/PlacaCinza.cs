using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoPlacaMercosul
{
    public class PlacaCinza
    {
        public string Placa { get; set; }

        public PlacaCinza(string placa)
        {
            Placa = placa;
        }

        public string ValidarPlaca()
        {
            string error = String.Empty;
            if (string.IsNullOrEmpty(Placa))
            {
                error = "A placa é obrigatória.";
                return error;
            }

            if (Placa.Length != 7)
            {
                error = "A placa deve ter 7 caracteres.";
                return error;
            }

            if (!char.IsLetter(Placa[0]) || !char.IsLetter(Placa[1]) || !char.IsLetter(Placa[2]))
            {
                error = "Os três primeiros caracteres da placa devem ser letras.";
                return error;
            }

            if (!char.IsDigit(Placa[3]) || !char.IsDigit(Placa[4]) || !char.IsDigit(Placa[5]) || !char.IsDigit(Placa[6]))
            {
                error = "Os quatro últimos caracteres da placa devem ser números.";
                return error;
            }

            return error;
        }

        public  string ConvertePlacaCinzaParaMercosul(string placaEntrada)
        {
            if (string.IsNullOrEmpty(placaEntrada)) throw new ArgumentNullException("placaEntrada", "A string não pode ser nula ou vazia.");

            Dictionary<char, char> dicionarioDeConversao = new Dictionary<char, char> {
                {'0', 'A'}, {'1', 'B'}, {'2', 'C'}, {'3', 'D'}, {'4', 'E'}, {'5', 'F'}, {'6', 'G'}, {'7', 'H'}, {'8', 'I'}, {'9', 'J'}
            };
            string placaSaida = String.Empty;
            char quintoCaracter = placaEntrada[4];

            if (dicionarioDeConversao.ContainsKey(quintoCaracter))
            {
                placaSaida = placaEntrada.Remove(4, 1).Insert(4, dicionarioDeConversao[quintoCaracter].ToString());
            }
            return placaSaida;
        }
    }
}
