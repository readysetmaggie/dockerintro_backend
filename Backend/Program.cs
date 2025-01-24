var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(a => a.AllowAnyOrigin());

app.MapGet("/podcasts", () => new List<string>()
{
    "Podcast 1",
    "Podcast 2",
    "Podcast 3"
});

app.Run();