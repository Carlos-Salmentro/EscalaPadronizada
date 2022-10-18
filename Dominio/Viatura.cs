using System;
using System.Collections.Generic;

namespace GeradorDeEscalaGCM.Dominio
{
    public class Viatura
    {
        public string? Prefixo { get; set; }
        public string Placa { get; set; }
        public string Turno { get; set; }
        public Servidor Motorista { get; set; }
        public Servidor Encarregado { get; set; }
        public List<Servidor>? Aux { get; set; } = new List<Servidor>();

        public Viatura(string? prefixo, string placa)
        {
            Prefixo = prefixo;
            Placa = placa;
        }
                
    }
    
}
