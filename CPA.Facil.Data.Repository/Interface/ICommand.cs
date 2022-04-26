using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository.Interface {
    public interface ICommand {

        public int Execute();
        public T Read<T>();
        public List<T> ReadAll<T>();
        public T ReadValue<T>(String columnName);

        public void NewParameter(String name, Object value);


    }
}
