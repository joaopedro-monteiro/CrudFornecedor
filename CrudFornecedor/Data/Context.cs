using CrudFornecedor.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudFornecedor.Data;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public DbSet<Fornecedor> Fornecedor { get; set; } = default!;
}