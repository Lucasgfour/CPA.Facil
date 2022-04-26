using CPA.Facil.Data.Repository;

namespace CPA.Facil.Application.Web {
    public static class DependencyResolver {

        public static void Resolver(WebApplicationBuilder builder) {

            Repository(builder);

        }

        private static void Repository(WebApplicationBuilder builder) {

            String ConnectionString = builder.Configuration.GetSection("ConnectionString").Value.ToString();

            RepositoryConfigure.ConnectionString = ConnectionString;

        }

    }
}
