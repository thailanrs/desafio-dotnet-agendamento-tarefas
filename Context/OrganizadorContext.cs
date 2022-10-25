using Microsoft.EntityFrameworkCore;
using desafio_dotnet_agendamento_tarefas.Models;

namespace desafio_dotnet_agendamento_tarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options){}

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}