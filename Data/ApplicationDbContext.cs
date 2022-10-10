using AppCompletaMvc.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AppCompletaMvc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Produto> Produtos { get; set; }
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
    }
}