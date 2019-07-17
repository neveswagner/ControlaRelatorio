using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Previsao
    {

        public int Id_relatorio { get; set; }

        public String Requisito { get; set; }
       
        public String Cliente { get; set; }

        public String Atendente { get; set; }
    
        public DateTime DtaInclusao { get; set; }

        public DateTime DtaPrevisao { get; set; }

        public String ClienteAtualizado { get; set; }

        public String RequisitoAtualizacao { get; set; }
    
        public String ConcluidoStatus { get; set; }

        public String BaixadoProgramacao { get; set; }

        public String Observacao { get; set; }

        public String DiasPrevisao { get; set; }

        public String MesPrevisao { get; set; }

    }
}
