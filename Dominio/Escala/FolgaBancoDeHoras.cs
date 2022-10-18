using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class FolgaBancoDeHoras
    {
        public List<Servidor> FolgaBH { get; set; } = new List<Servidor>();

        public void AddServidor(Servidor servidor)
        {
            FolgaBH.Add(servidor);
        }
    }
    
}
