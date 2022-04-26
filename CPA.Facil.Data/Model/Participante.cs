using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Model {
    public class Participante {

        public int id { get; set; }
        public String? chave { get; set; }
        public int questionario_id { get; set; }
        public DateTime data_resposta { get; set; }


    }
}
