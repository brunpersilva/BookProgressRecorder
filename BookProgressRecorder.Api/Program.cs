using BookProgressRecorder.Dependencies;
using BookProgressRecorder.Infrasctructure.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var appconfiguration = new AppConfiguration();
builder.Services.AddSingleton<IAppConfiguration>(appconfiguration);
builder.Configuration.Bind(appconfiguration);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDependencies(appconfiguration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
