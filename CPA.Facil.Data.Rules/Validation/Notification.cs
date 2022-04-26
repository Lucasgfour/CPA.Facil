using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Rules.Validation {
    public class Notification {
        public String Message { get; set; }

        public Notification(String message) {
            this.Message = message;
        }

    }
}
