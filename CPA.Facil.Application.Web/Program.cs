using CPA.Facil.Application.Web;

var builder = WebApplication.CreateBuilder(args);

ProgramConfigure.BeforeBuilder(builder);

var app = builder.Build();

ProgramConfigure.AfterBuilder(builder, app);

app.MapGet("/", () => "Servidor de API");

app.Run();
