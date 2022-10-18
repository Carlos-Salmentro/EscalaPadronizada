using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class Plantao
    {
        public int Codigo;
        public List<Servidor> Armeiros = new List<Servidor>();

        public Plantao(int codigo)
        {
            Codigo = codigo;
        }
    }
}
