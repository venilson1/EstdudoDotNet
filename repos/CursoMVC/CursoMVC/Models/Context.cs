using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    /* == PACOTE DO SQLSEVER INSTALADO COM O CONSOLE DO NUGET==
     *Install-Package Microsoft.EntityFrameworkCore.SqlServer
     */
    public class Context : DbContext
    {
       
         //avisando ao Entity que irei ter uma tabela de categoria
         //indicando o tipo <Categoria> ;; o nome Categorias 
         public DbSet<Categoria> Categorias { get; set; }
         public DbSet<Produto> Produtos { get; set; }



        //Responsavel por configurar o EntityFramework
        //dentro dele vai dizer qual BD vai ser utilizado
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True");
        }
    }
}

/*
 * Executar o Migrations para criar a tabela no Migration
 * == Add-Migration InitialCreate
 * => InitialCreate é uma variavel é o nome da migration
 * => O Add-Migration é reconhecido pois foi instalado o 
 * Microsoft.EntityFrameworkCore.tools
 */

/* 
 * Depois que executar o Add-Migration 
 * EXECUTAR O :
 * Update-Database
 * Para criar o Banco de Dados
 */

/* 
 * Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 3.1
 */
