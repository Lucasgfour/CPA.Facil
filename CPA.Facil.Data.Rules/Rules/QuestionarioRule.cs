using CPA.Facil.Data.Model;
using CPA.Facil.Data.Rules.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Rules.Rules {
    public static class QuestionarioRule {

        public static Notifications OnInsert(Questionario questionario) {

            Assertion rule = new Assertion();

            rule.isNullOrEmpty(questionario.titulo, "Favor informar um título valido.");
            rule.isNullOrEmpty(questionario.descricao, "Favor informar uma descrição valida.");
            rule.Equal(questionario.instituicao_id, 0, "Favor informar a instituição referente ao questionário.");
            rule.isTrue((questionario.data_inicio >= questionario.data_fim), "Data final deve ser maior que data de ínicio.");
            rule.isTrue((questionario.data_inicio < DateTime.Today), "Data/hora de ínicio não pode ser uma data/hora inferior a hoje.");
            rule.isNull(questionario.chave, "Chave não pode ser em branco.");

            return rule.notifications;

        }


    }
}
