/*namespace GeradorDeEscalaGCM.Dominio
{
    public class Servidor
    {
        //usar a lotacao informada no front para buscar no csv (split) se vira lançamento ou nao

        public DateTime Data { get; set; }
        public string Comando;  //21
        public string Lotacao;  //20
        public string Rf { get; set; } //1
        public string NomeGuerra { get; set; }  //3
        public int Dist { get; set; }   //4
        public string Graduacao { get; set; }     // 5 usar para decidir se mostra Dist. ou RF.
        public string Funcao { get; set; }      // 25 Coluna Z
        public int CodPosto { get; set; }   // 58
        public string TipoDePosto { get; set; } // 59
        public string NomeDoPosto { get; set; } // 60
        public string? Prefixo { get; set; }    // 63 Coluna BK
        public string? Placa { get; set; }  // 62 Coluna 62
        public string Programa { get; set; }        //? 24 Coluna Y
        public string Escala { get; set; }      // 65 Coluna BN
        public DateTime Inicio { get; set; }          // 66 Inicio do Plantao Coluna BO
        public DateTime Termino { get; set; }       // 67 Termino do Plantao Coluna BP
        public string Servico { get; set; }     // 36 Coluna AK
        public DateTime? InicioAfast { get; set; }  // 37 Coluna AL
        public DateTime? TerminoAfast { get; set; } // 38 Coluna AM
        public DateTime? InicioFerias { get; set; }  // 39 Coluna AN
        public DateTime? TerminoFerias { get; set; }    // 40 Coluna AO
        public DateTime? InicioEQP { get; set; }    // 27 Coluna AB
        public DateTime? TerminoEQP { get; set; }    // 28 Coluna AC
        public DateTime? InicioManuseio { get; set; }    // 29 Coluna AD
        public DateTime? TerminoManuseio { get; set; }    // 30 Coluna AE
        public DateTime? DataPsicologico { get; set; }  // 31 Coluna AF
        public string[]? RestricoesEncontradas { get; set; } // 55 Coluna BD - criar enum para possiveis restricoes
        // ? substituido por RestricoesEncontradas  public string SituacaoFuncional { get; set; }   // 57 Coluna BF
        // ? substituido por RestricoesEncontradas public string? DescricaoRestFunc { get; set; }  // 47 Coluna AV
        // ? substituido por RestricoesEncontradas public string? NaturezaReadaptacao { get; set; }
        public string Tipo { get; set; }    //69 Coluna BR - Matutino, Vespertino, Norturno
        public string? HorarioDeEstudante { get; set; }  // 70 Coluna BS
        // acrescentar inicio, fim, hora inicio, hora fim HE
        public string? ProvasFinais { get; set; }      // 71 Coluna BT
        public int Nivel { get; set; }          // 81 Coluna CD
        public string? UnidadeADisposicao { get; set; } // 83 Coluna CF
        public DateTime? InicioDisposicao { get; set; } // 82 Coluna CE
        public bool Status;

        public Servidor(string comando, string lotacao, string rf, string nomeGuerra, int dist, string graduacao, string funcao, int codPosto, string tipoDePosto, string nomeDoPosto, string? prefixo, string? placa, string programa, string escala, DateTime inicio, DateTime termino, string servico, DateTime? inicioAfast, DateTime? terminoAfast, DateTime? inicioFerias, DateTime? terminoFerias, DateTime? inicioEQP, DateTime? terminoEQP, DateTime? inicioManuseio, DateTime? terminoManuseio, DateTime? dataPsicologico, string[]? restricoesEncontradas, string tipo, string? horarioDeEstudante, string? provasFinais, int nivel, string? unidadeADisposicao, DateTime? inicioDisposicao)
        {
            Data = DateTime.Now.AddDays(1);
            Comando = comando;
            Lotacao = lotacao;
            Rf = rf;
            NomeGuerra = nomeGuerra;
            Dist = dist;
            Graduacao = graduacao;
            Funcao = funcao;
            CodPosto = codPosto;
            TipoDePosto = tipoDePosto;
            NomeDoPosto = nomeDoPosto;
            Prefixo = prefixo;
            Placa = placa;
            Programa = programa;
            Escala = escala;
            Inicio = inicio;
            Termino = termino;
            Servico = servico;
            InicioAfast = inicioAfast;
            TerminoAfast = terminoAfast;
            InicioFerias = inicioFerias;
            TerminoFerias = terminoFerias;
            InicioEQP = inicioEQP;
            TerminoEQP = terminoEQP;
            InicioManuseio = inicioManuseio;
            TerminoManuseio = terminoManuseio;
            DataPsicologico = dataPsicologico;
            RestricoesEncontradas = restricoesEncontradas;
            Tipo = tipo;
            HorarioDeEstudante = horarioDeEstudante;
            ProvasFinais = provasFinais;
            Nivel = nivel;
            UnidadeADisposicao = unidadeADisposicao;
            InicioDisposicao = inicioDisposicao;
            Status = false;
        }
    }

}*/

using System.Text;

namespace GeradorDeEscalaGCM.Dominio
{
    public class Servidor
    {
        //usar a lotacao informada no front para buscar no csv (split) se vira lançamento ou nao

        public string Comando;  //21
        public string Lotacao;  //20
        public string Rf { get; set; } //1
        public string NomeGuerra { get; set; }  //3
        public string Dist { get; set; }   //4
        public string Graduacao { get; set; }     // 5 usar para decidir se mostra Dist. ou RF.
        public string? Funcao { get; set; }      // 25 Coluna Z
        public int? CodPosto { get; set; }   // 58
        public string? TipoDePosto { get; set; } // 59
        public string? NomeDoPosto { get; set; } // 60
        public string? Prefixo { get; set; }    // 63 Coluna BK
        public string? Placa { get; set; }  // 62 Coluna 62
        public string? Programa { get; set; }        //? 24 Coluna Y
        public string? Escala { get; set; }      // 65 Coluna BN
        public string? /*DateTime?*/ Inicio { get; set; }          // 66 Inicio do Plantao Coluna BO
        public string? /*DateTime?*/ Termino { get; set; }       // 67 Termino do Plantao Coluna BP
        public string? Servico { get; set; }     // 36 Coluna AK
        public string? /*DateTime?*/ InicioAfast { get; set; }  // 37 Coluna AL
        public string? /*DateTime?*/ TerminoAfast { get; set; } // 38 Coluna AM
        public string? /*DateTime?*/ InicioFerias { get; set; }  // 39 Coluna AN
        public string? /*DateTime?*/ TerminoFerias { get; set; }    // 40 Coluna AO
        public string? /*DateTime?*/ InicioEQP { get; set; }    // 27 Coluna AB
        public string? /*DateTime?*/ TerminoEQP { get; set; }    // 28 Coluna AC
        public string? /*DateTime?*/ InicioManuseio { get; set; }    // 29 Coluna AD
        public string? /*DateTime?*/ TerminoManuseio { get; set; }    // 30 Coluna AE
        public string? /*DateTime?*/ DataPsicologico { get; set; }  // 31 Coluna AF
        public string? RestricoesEncontradas { get; set; } // 55 Coluna BD - criar enum para possiveis restricoes
        // ? substituido por RestricoesEncontradas  public string SituacaoFuncional { get; set; }   // 57 Coluna BF
        // ? substituido por RestricoesEncontradas public string? DescricaoRestFunc { get; set; }  // 47 Coluna AV
        // ? substituido por RestricoesEncontradas public string? NaturezaReadaptacao { get; set; }
        public string? Tipo { get; set; }    //69 Coluna BR - Matutino, Vespertino, Norturno
        public string? HorarioDeEstudante { get; set; }  // 70 Coluna BS
        // acrescentar inicio, fim, hora inicio, hora fim HE
        public string? ProvasFinais { get; set; }      // 71 Coluna BT
        public int? Nivel { get; set; }          // 81 Coluna CD
        public string? UnidadeADisposicao { get; set; } // 83 Coluna CF
        public string? /*DateTime?*/ InicioDisposicao { get; set; } // 82 Coluna CE
        public bool Status;

        public Servidor(string comando, string lotacao, string rf, string nomeGuerra, string dist, string graduacao, string? funcao, int? codPosto, string? tipoDePosto, string? nomeDoPosto, string? prefixo, string? placa, string? programa, string? escala, string? inicio, string? termino, string? servico, string? inicioAfast, string? terminoAfast, string? inicioFerias, string? terminoFerias, string? inicioEQP, string? terminoEQP, string? inicioManuseio, string? terminoManuseio, string? dataPsicologico, string restricoesEncontradas, string? tipo, string? horarioDeEstudante, string? provasFinais, int? nivel, string? unidadeADisposicao, string? inicioDisposicao)
        {
            Comando = comando;
            Lotacao = lotacao;
            Rf = rf;
            NomeGuerra = nomeGuerra;
            Dist = dist;
            Graduacao = graduacao;
            Funcao = funcao;
            CodPosto = codPosto;
            TipoDePosto = tipoDePosto;
            NomeDoPosto = nomeDoPosto;
            Prefixo = prefixo;
            Placa = placa;
            Programa = programa;
            Escala = escala;
            Inicio = inicio;
            Termino = termino;
            Servico = servico;
            InicioAfast = inicioAfast;
            TerminoAfast = terminoAfast;
            InicioFerias = inicioFerias;
            TerminoFerias = terminoFerias;
            InicioEQP = inicioEQP;
            TerminoEQP = terminoEQP;
            InicioManuseio = inicioManuseio;
            TerminoManuseio = terminoManuseio;
            DataPsicologico = dataPsicologico;
            RestricoesEncontradas = restricoesEncontradas;
            Tipo = tipo;
            HorarioDeEstudante = horarioDeEstudante;
            ProvasFinais = provasFinais;
            Nivel = nivel;
            UnidadeADisposicao = unidadeADisposicao;
            InicioDisposicao = inicioDisposicao;
            Status = false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Comando + " ");
            sb.AppendLine(Lotacao + " ");

            sb.Append(Rf + " ");
            sb.Append(Dist + " ");
            sb.Append(Graduacao + " ");
            sb.Append(NomeGuerra + " ");
            sb.Append(Inicio + " ");
            sb.Append(Termino + " ");
            sb.AppendLine(Programa + " ");


            return sb.ToString();
        }
    }


}

