using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class Remanejamento
    {
        public int? Distintivo;
        public int? Rf;
        public string De;
        public string Para;
        public DateTime Horário;

        public Remanejamento(int? distintivo, int? rf, string de, string para, DateTime horário)
        {
            if(distintivo == null && rf == null)
            {
                throw new ArgumentNullException("É necessário informar o Distintivo ou o RF do remanejado.");
            }
            Distintivo = distintivo;
            Rf = rf;
            De = de;
            Para = para;
            Horário = horário;
        }
    }
}
