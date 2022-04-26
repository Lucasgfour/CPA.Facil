using CPA.Facil.Data.Model;
using CPA.Facil.Data.Repository.DataAccess;
using CPA.Facil.Data.Rules.Rules;
using CPA.Facil.Data.Rules.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Service.Service {
    public static class QuestionarioService {

        public static Questionario Consult(int id, int instituicao_id) {

            return QuestionarioDao.Consult(id, instituicao_id);

        }

        public static Notifications Insert(Questionario questionario) {

            Notifications saida = QuestionarioRule.OnInsert(questionario);

            saida.Validation();
            
            QuestionarioDao.Insert(questionario);

            return saida;

        }

    }
}
