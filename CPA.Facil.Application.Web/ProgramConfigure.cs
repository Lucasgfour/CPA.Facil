using CPA.Facil.Data.Commom;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace CPA.Facil.Application.Web {
    public static class ProgramConfigure {

        public static void BeforeBuilder(WebApplicationBuilder builder) {

            var services = builder.Services;

            services.AddCors();
            services.AddControllers();

            var secret = builder.Configuration.GetSection("Secret").Value.ToString();

            if (secret == null)
                throw new Exception("Favor informar chave 'Secret' para JWT no AppSettings");

            UserAuthentication.Secret = secret;

            var key = Encoding.ASCII.GetBytes(secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

        }

        public static void AfterBuilder(WebApplicationBuilder builder, WebApplication app) {

            if (app.Environment.IsDevelopment()) {
                //app.UseDeveloperExceptionPage();
            }

            app.UseExceptionHandler(errorApp => {
                errorApp.Run(async context => {
                    context.Response.StatusCode = 500; // or another Status accordingly to Exception Type
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null) {
                        var ex = error.Error;

                        Resultado result = new Resultado(false, ex.Message);

                        await context.Response.WriteAsync(JsonConvert.SerializeObject(result), Encoding.UTF8);
                    }
                });
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });

            DependencyResolver.Resolver(builder);

        }

    }
}
