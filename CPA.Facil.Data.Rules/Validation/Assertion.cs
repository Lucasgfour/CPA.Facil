using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Rules.Validation {
    public class Assertion {

        public Notifications notifications = new Notifications();

        public void Equal(String value, String compare, String message) {
            if(value.Equals(compare)) 
                notifications.Add(message);
        }

        public void Equal(Double value, Double compare, String message) {
            if (value == compare)
                notifications.Add(message);
        }

        public void isNull(Object value, String message) {
            if (value == null)
                notifications.Add(message);
        }

        public void isNullOrEmpty(String value, String message) {
            if (value == null) {
                notifications.Add(message);
            } else if (value.Equals("")) {
                notifications.Add(message);
            }
        }

        public void NotEqual(String value, String compare, String message) {
            if (!value.Equals(compare))
                notifications.Add(message);
        }

        public void Contains(String value, String text, String message) {
            if(text.Contains(value)) 
                notifications.Add(message);
        }

        public void NotContains(String value, String text, String message) {
            
            if (!text.Contains(value))
                notifications.Add(message);
        }

        public void GreatherThan(Double value, Double compare, String message) {
            if(value > compare)
                notifications.Add(message);
        }

        public void LessThan(Double value, Double compare, String message) {
            if (value < compare)
                notifications.Add(message);
        }

        public void GreatherOrEqual(Double value, Double compare, String message) {
            if (value >= compare)
                notifications.Add(message);
        }

        public void LessOrEqual(Double value, Double compare, String message) {
            if (value <= compare)
                notifications.Add(message);
        }

        public void isTrue(Boolean value, String message) {
            if(value)
                notifications.Add(message);
        }

        public void isFalse(Boolean value, String message) {
            if (!value)
                notifications.Add(message);
        }

    }
}
