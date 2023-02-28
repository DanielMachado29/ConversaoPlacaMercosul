using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoPlacaMercosul
{
    public class PlacaMercosul
    {
        public string Placa { get; set; }

        public PlacaMercosul(string placa)
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

            if (!char.IsDigit(Placa[3]))
            {
                error = "O quarto caracter da placa deve ser um número.";
                return error;
            }

            if (!char.IsLetter(Placa[4]))
            {
                error = "O quinto caracter da placa deve ser uma letra.";
                return error;
            }

            if (!char.IsDigit(Placa[5]) || !char.IsDigit(Placa[6]))
            {
                error = "O sexto e sétimo caracteres da placa devem ser números.";
                return error;
            }

            return error;
        }
    }
}