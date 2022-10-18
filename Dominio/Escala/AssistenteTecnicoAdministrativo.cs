using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public static class AssistenteTecnicoAdministrativo
    {
        public static Servidor ATA { get; set; }

        public static void MobiliarATA()
        {
            foreach (Servidor servidor in Efetivo.EfetivoBase)
            {
                if (servidor.Funcao == "ASSISTENTE TÉCNICO ADM")
                    ATA = servidor;
            }

            if (ATA == null)
                throw new ArgumentNullException("ATA","A função ATA deve obrigatoriamente ser preenchida. (Atualizar função no PLANEJAMENTO DE ESCALA - SIG-GCM/AlimentaçãoDeDados)");
        }

        public static void ImprimirATA()
        {
            Console.WriteLine("ATA: " + ATA.Rf + " " + ATA.NomeGuerra + " " + ATA.Inicio + " " + ATA.Termino);
        }

    }

}
