using CPA.Facil.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Model {
    public class Pergunta {

        public int id { get; set; }
        public int questionario_id { get; set; }
        public Permissao aluno { get; set; }
        public Permissao professor { get; set; }
        public Permissao administrativo { get; set; }
        public String? descricao { get; set; }
        public TipoPergunta tipo { get; set; }
        public int posicao { get; set; }

    }
}
