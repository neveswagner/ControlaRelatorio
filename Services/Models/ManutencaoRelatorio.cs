using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class ManutencaoRelatorio
    {
        public int Id_relatorio { get; set; }

        public String Requisito { get; set; }

        public String RequisitoAtualizacao { get; set; }

        public String RequisitoCorrecao { get; set; }

        public String Cliente { get; set; }

        public String ClienteAtualizado { get; set; }

        public String Atendente { get; set; }

        public String PendenteStatus { get; set; }

        public String Observacao { get; set; }

        public DateTime DtaInclusao { get; set; }

        public String ObservacaoBaixa { get; set; }

        public String QuantidadeAtendente { get; set; }

        public String DiasCountAtendente { get; set; }


    }
}
