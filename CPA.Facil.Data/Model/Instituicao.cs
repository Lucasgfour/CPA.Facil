﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Model {
    public class Instituicao {

        public int id { get; set; }
        public String nome { get; set; } = "";
        public String documento { get; set; } = "";
        public String telefone { get; set; } = "";
        public String email { get; set; } = "";
        public String cidade { get; set; } = "";
        public String senha { get; set; } = "";
        public String presidenteCpa { get; set; } = "";

    }
}
