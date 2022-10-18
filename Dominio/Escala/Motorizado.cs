using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public static class Motorizado
    {
        public static List<Viatura>? Viaturas = new List<Viatura>();
        public static List<Servidor>? Motorizados = new List<Servidor>();

        public static void CriarViatura()
        {
            foreach (Servidor servidor in Efetivo.EfetivoBase)
            {
                if (servidor.Placa != null)
                {
                    Motorizados.Add(servidor);

                    if (Motorizado.Viaturas.FirstOrDefault(x => x.Placa == servidor.Placa && x.Turno == servidor.Tipo) == null)
                    {
                        Viatura viatura = new Viatura(servidor.Prefixo, servidor.Placa);
                        viatura.Turno = servidor.Tipo;
                        Motorizado.Viaturas.Add(viatura);
                    }
                }
            }

        }

        public static void MobiliarViaturas()
        {
            foreach (Servidor servidor in Motorizados)
            {
                Viatura viatura = Viaturas.First(x => x.Placa == servidor.Placa && x.Turno == servidor.Tipo);

                if (servidor.Funcao == "ENC.VTR" || servidor.Funcao == "CHEFE DE SUPERVISAO/SETOR")
                {
                    viatura.Encarregado = servidor;
                }

                else if (servidor.Funcao == "MOTORISTA" || servidor.Funcao == "MOTOCICLISTA")
                {
                    viatura.Motorista = servidor;
                }

                else
                {
                    viatura.Aux.Add(servidor);
                }
            }
        }

        public static void ImprimirViaturas()
        {
            foreach (Viatura vtr in Viaturas)
            {
                Console.WriteLine();
                Console.WriteLine(vtr.Placa + " " + vtr.Prefixo);
                Console.WriteLine("Motorista: " + vtr.Motorista.Graduacao + " " + vtr.Motorista.NomeGuerra + " " + vtr.Motorista.Inicio + " " + vtr.Motorista.Termino);
                Console.WriteLine("Encarregado: " + vtr.Encarregado.Graduacao + " " + vtr.Encarregado.NomeGuerra + " " + vtr.Encarregado.Inicio + " " + vtr.Encarregado.Termino);
                if (vtr.Aux.Count > 0)
                {
                    foreach (Servidor aux in vtr.Aux)
                    {
                        Console.WriteLine("Auxiliar: " + aux.Graduacao + " " + aux.NomeGuerra + " " + aux.Inicio + " " + aux.Termino);
                    }
                }

            }
        }

    }
}
