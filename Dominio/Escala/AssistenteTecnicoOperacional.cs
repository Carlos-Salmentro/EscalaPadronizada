using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public class AssistenteTecnicoOperacional
    {
        public static Servidor ATO { get; set; }

        public static void MobiliarATO()
        {
            foreach (Servidor servidor in Efetivo.EfetivoBase)
            {
                if (servidor.Funcao == "ASSISTENTE TÉCNICO OPERACIONAL")
                    ATO = servidor;
            }

            if (ATO == null)
                throw new ArgumentNullException("ATO", "A função ATO deve obrigatoriamente ser preenchida. (Atualizar função no PLANEJAMENTO DE ESCALA - SIG-GCM/AlimentaçãoDeDados)");
        }

        public static void ImprimirATO()
        {
            Console.WriteLine("ATO: " + ATO.Rf + " " + ATO.NomeGuerra + " " + ATO.Inicio + " " + ATO.Termino);
        }

    }
}
