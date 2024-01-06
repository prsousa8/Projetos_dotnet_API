using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projetos_dotnet_API.Entities;

namespace Projetos_dotnet_API.Context
{
    public class AgendaContext : DbContext //DbContext --> Usar as operações do Microsoft.EntityFrameworkCore
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) //Recebe a conexão com o banco e envia para DbContext, que fará o gerenciamento do banco
        {

        }
        public DbSet<Contato> Contatos {get; set;} //Representação da classe 'Contato' como uma tabela chamada 'Contatos'
    }
}