using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public static class Afastamentos
    {
        public static List<Servidor> ServidoresAfastados = new List<Servidor>();

        public static void AddServidor(Servidor servidor)
        {
            ServidoresAfastados.Add(servidor);
        }
    }
}
