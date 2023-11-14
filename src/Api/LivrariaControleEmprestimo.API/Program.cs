using Microsoft.EntityFrameworkCore;
using LivrariaControleEmprestimo.Services;
using LivrariaControleEmprestimo.Infrastructure.Daos;
using LivrariaControleEmprestimo.Infrastructure.Daos.EfCore;
using LivrariaControleEmprestimo.Infrastructure.Interfaces.Handlers;
using LivrariaControleEmprestimo.Services.Interfaces.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LivrariaControleEmprestimoContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("LivrariaEmprestimoConnection")));

builder.Services.AddTransient<ILivroDao, LivroDao>();
builder.Services.AddTransient<IClienteDao, ClienteDao>();
builder.Services.AddTransient<IEmprestimoDao, EmprestimoDao>();

builder.Services.AddTransient<IDefaultLivroService, LivroService>();
builder.Services.AddTransient<IDefaultClienteService, ClienteService>();
builder.Services.AddTransient<IDefaultEmprestimoService, EmprestimoService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
