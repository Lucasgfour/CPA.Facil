using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Commom {
    public class Resultado {
        public Resultado(bool condition, string message) {
            this.Condition = condition;
            this.Message = message;
        }

        public Resultado(bool condition, string message, object result) {
            this.Condition = condition;
            this.Message = message;
            this.Result = result;
        }

        public bool Condition { get; set; }
        public string Message { get; set; }
        public object Result { get; set; }

    }
}
