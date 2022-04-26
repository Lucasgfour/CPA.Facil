using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Model {
    public class Resposta {

        public int id { get;set; }
        public int participante_id { get;set; }
        public int pergunta_id { get;set; }
        public string? valor { get;set; }

    }
}
