using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class Sentinela
    {
        public int Codigo;
        public List<Servidor> Sentinelas = new List<Servidor>();

        public Sentinela(int codigo)
        {
            Codigo = codigo;
        }
    }
}
