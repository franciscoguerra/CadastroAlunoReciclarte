
using CadastroAlunoReciclarte.Map;
using CadastroAlunoReciclarte.Repositorios.Interfaces;
using CadastroAlunoReciclarte.Repositorios;
using Microsoft.EntityFrameworkCore;
using CadastroAlunoReciclarte.Context;
using Microsoft.Extensions.Configuration;

namespace CadastroAlunoReciclarte
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(
            options =>
            {
                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
            });
          
            builder.Services
               .AddDbContext<CadastroAlunoReciclarteDbContext>(
                   options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
               );
       


            builder.Services.AddScoped<IAlunoRepositorio, AlunoRepositorio>();
            builder.Services.AddScoped<ICursoRepositorio, CursoRepositorio>();
            builder.Services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            builder.Services.AddScoped<IEscolaRepositorio, EscolaRepositorio>();
            builder.Services.AddScoped<IFiliacaoRepositorio, FiliacaoRepositorio>();
            builder.Services.AddScoped<ITurmaRepositorio, TurmaRepositorio>();



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
        }
    }
}