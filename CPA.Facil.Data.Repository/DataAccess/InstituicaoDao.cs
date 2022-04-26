using CPA.Facil.Data.Model;
using CPA.Facil.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository.DataAccess {
    public static class InstituicaoDao {

        public static void Insert(Instituicao institucao) {

            ICommand comando = RepositoryResolver.NewCommand("INSERT INTO instituicao");
            comando.NewParameter("@alala", "asdasd");

            comando.Execute();

        }

    }
}
