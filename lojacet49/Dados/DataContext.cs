using lojacet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lojacet49.Dados
{
    public class DataContext : DbContext // a base de dados passa para a classe DataContext
    {
        //criar base de dados 

        public DbSet<Produto> Produtos { get; set; } //cria a tabela produtos so depois de ter a base de dados  

        public DataContext(DbContextOptions<DataContext> options) : base(options)

            //
        {

        }
    }
}
