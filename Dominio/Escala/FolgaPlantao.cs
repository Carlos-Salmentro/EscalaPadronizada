using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class FolgaPlantao
    {
        public List<Servidor> FolgaPlant { get; set; } = new List<Servidor>();

        public void AddServidor(Servidor servidor)
        {
            FolgaPlant.Add(servidor);
        }
    }
}
