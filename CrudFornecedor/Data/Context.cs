using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudFornecedor.Models;

namespace CrudFornecedor.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<CrudFornecedor.Models.Fornecedor> Fornecedor { get; set; } = default!;
    }
}
