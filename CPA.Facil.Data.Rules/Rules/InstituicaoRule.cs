using CPA.Facil.Data.Model;
using CPA.Facil.Data.Rules.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPA.Facil.Data.Rules.Rules {
    public static class InstituicaoRule {

        public static Notifications OnInsert(Instituicao instituicao) {

            Assertion rule = new Assertion();

            rule.isNullOrEmpty(instituicao.telefone, "Favor informar um telefone");

            return rule.notifications;

        }

    }
}
