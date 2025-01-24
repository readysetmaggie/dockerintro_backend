using System.Data.SqlClient;
using Dapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(a => a.AllowAnyOrigin());

app.MapGet("/podcasts", async () =>
{
    var db = new SqlConnection("Server=tcp:database;Initial Catalog=podcasts;Persist Security Info=False;User ID=sa;Password=Dometrain#123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
    
    return (await db.QueryAsync<Podcast>("SELECT * FROM Podcasts")).Select(p => p.Title);
    // return new List<string>()
    // {
    //     "Podcast 1",
    //     "Podcast 2",
    //     "Podcast 3"
    // };
});

app.Run();

public record Podcast(Guid Id, string Title);