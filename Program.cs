
using ControleEmpresa.Data;
using ControleEmpresa.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conn = (builder.Configuration.GetConnectionString("ControleEmpresaConn"));

builder.Services.AddDbContext<AppDbContext>(opts => opts.UseMySql(
    conn, ServerVersion.AutoDetect(conn)));

builder.Services.AddScoped<IFuncionarioDao, FuncionarioDaoComEfCore>();
builder.Services.AddScoped<ISetorDao, SetorDaoComEfCore>();
builder.Services.AddScoped<IPontoDao, PontoDaoComEfCore>();

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

app.UseAuthorization();

app.MapControllers();

app.Run();
