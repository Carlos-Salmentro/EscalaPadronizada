using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class Averiguante
    {
        public static Servidor? ServidorAveriguante { get; set; }

        public Averiguante(Servidor averiguante)
        {
            ServidorAveriguante = averiguante;
        }
        public static void MobiliarAveriguante()
        {
            foreach(Servidor servidor in Efetivo.EfetivoBase)
            {
                if(servidor.Funcao == "AVERIGUANTE")
                {
                    ServidorAveriguante = servidor;
                }
            }
        }

        public static void ImprimirAveriguante()
        {

            Console.WriteLine(ServidorAveriguante.Dist + " " + ServidorAveriguante.NomeGuerra + " " + ServidorAveriguante.Inicio + " " + ServidorAveriguante.Termino);
            Console.WriteLine();

        }
    }
}
