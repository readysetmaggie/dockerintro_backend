var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/podcasts", () => new List<string>()
{
    "Podcast 1",
    "Podcast 2",
    "Podcast 3"
});

app.Run();