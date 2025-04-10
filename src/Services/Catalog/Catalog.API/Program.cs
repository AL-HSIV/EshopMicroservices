var builder = WebApplication.CreateBuilder(args);

//add services to containder

var app = builder.Build();

// configure HTTP request pipeline

app.Run();
