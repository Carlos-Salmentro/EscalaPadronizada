using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeEscalaGCM.Dominio.Escala
{
    public static class Efetivo
    {
        public static List<Servidor> EfetivoBase = new List<Servidor>();

        public static void CriarServidores(StreamReader sr, string ugcm)
        {
            while (!sr.EndOfStream)
            {
                string[] line = sr.ReadLine().Split(";");

                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == "")
                        line[i] = null;
                }

                if (line[20] == ugcm)
                {
                    Servidor servidor = new(line[21], line[20], line[1], line[3], (line[4]), line[5], line[25], int.Parse(line[58]), line[59], line[60], line[63], line[62], line[24], line[65], line[66], line[67], line[36], line[37], line[38], line[39], line[40], line[27], line[28], line[29], line[30], line[31], line[55], line[69], line[70], line[71], int.Parse(line[81]), line[83], line[82]);
                    Efetivo.EfetivoBase.Add(servidor);
                }
            }
                        
        }
    }
}
