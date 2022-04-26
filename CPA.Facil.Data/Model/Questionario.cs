using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Model {
    public class Questionario {

        public int id { get; set; }
        public int instituicao_id { get; set; }
        public DateTime? data_inicio { get; set; }
        public DateTime? data_fim { get; set; }
        public String? titulo { get; set; }
        public String? chave { get; set; }
        public String? descricao { get; set; }


    }
}
