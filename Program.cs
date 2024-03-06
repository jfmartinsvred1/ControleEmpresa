
using ControleEmpresa.Data;
using ControleEmpresa.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conn = (builder.Configuration.GetConnectionString("ControleEmpresaConn"));
var myAllowSpecificOrigins = "_var myAllowSpecificOrigins";

builder.Services.AddDbContext<AppDbContext>(opts => opts.UseSqlServer(
    conn));
builder.Services.AddCors(opts =>
{
    opts.AddPolicy(name: myAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins("http://localhost:3000")
        .AllowAnyOrigin()
        .AllowAnyHeader();
    });
});

builder.Services.AddTransient<IFuncionarioDao, FuncionarioDaoComEfCore>();
builder.Services.AddTransient<ISetorDao, SetorDaoComEfCore>();
builder.Services.AddTransient<IPontoDao, PontoDaoComEfCore>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers().AddNewtonsoftJson
    (opts => opts.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(myAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
