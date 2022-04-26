using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Rules.Validation {
    public class Notifications {

        public List<Notification> notifications = new List<Notification>();

        public void Add(String message) {
            notifications.Add(new Notification(message));
        }

        public bool isOK() {
            return (notifications.Count == 0);
        }

        public void Validation() {

            if (isOK())
                return;

            String saida = "";

            notifications.ForEach((x) => {
                saida += x.Message + Environment.NewLine;
            });

            throw new Exception(saida);

        }

    }
}
