using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public static class Armaria
    {
        public static List<Servidor> Armeiros = new List<Servidor>();

        public static void AddArmeiro(Servidor servidor)
        {
            Armeiros.Add(servidor);
        }

        public static void MobiliarArmaria()
        {
            foreach (Servidor servidor in Efetivo.EfetivoBase)
            {
                if (servidor.Funcao == "ARMEIRO")
                    AddArmeiro(servidor);
            }
        }

        public static void ImprimirArmeiros()
        {
            foreach(Servidor armeiro in Armeiros)
            {
                Console.WriteLine(armeiro.Dist + " " + armeiro.NomeGuerra + " " + armeiro.Inicio + " " + armeiro.Termino);
                Console.WriteLine();
            }
        }
    }
}
