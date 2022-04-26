using CPA.Facil.Data.Model;
using CPA.Facil.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Repository.DataAccess {
    public static class QuestionarioDao {

        public static Questionario Consult(int id, int instituicao_id) {

            ICommand comando = RepositoryResolver.NewCommand("SELECT * FROM questionario WHERE id = @id AND instituicao_id = @instituicao_id");
            comando.NewParameter("@id", id);
            comando.NewParameter("@instituicao_id", instituicao_id);

            return comando.Read<Questionario>();
            
        }

        public static List<Questionario> ListAll(int instituicao_id) {

            ICommand comando = RepositoryResolver.NewCommand("SELECT * FROM questionario WHERE instituicao_id = @id");
            comando.NewParameter("@id", instituicao_id);

            return comando.ReadAll<Questionario>();

        }

        public static void Insert(Questionario questionario) {

            String sql = "INSERT INTO questionario(instituicao_id, data_inicio, data_fim, titulo, chave, descricao) ";
            sql = sql + "VALUES(@Instituicao, @DataInicio, @DataFim, @Titulo, @Chave, @Descricao)";

            ICommand comando = RepositoryResolver.NewCommand(sql);

            comando.NewParameter("@Instituicao", questionario.instituicao_id);
            comando.NewParameter("@DataInicio", questionario.data_inicio);
            comando.NewParameter("@DataFim", questionario.data_fim);
            comando.NewParameter("@Titulo", questionario.titulo);
            comando.NewParameter("@Chave", questionario.chave);
            comando.NewParameter("@Descricao", questionario.descricao);

            comando.Execute();

        }


    }
}