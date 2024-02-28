using CD_CD_on_Azure;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var connectionString = app.Configuration.GetConnectionString("DefaultConnection");

var secrets = new Secrets();
app.Configuration.GetSection("secrets").Bind(secrets);


app.MapGet("/", () =>new
{
    connectionString=connectionString,
    secrets=secrets
});

app.Run();
