using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    public class GameDbContextFactory : IDesignTimeDbContextFactory<GameDbContext>
    {
        public GameDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GameDbContext>();
            optionsBuilder.UseSqlServer(@"Server=Localhost\SQL2014;Database=TicTacToe;Trusted_Connection=True;MultipleActiveResultSets=true;Persist Security Info=True;Integrated Security=SSPI;");
            return new GameDbContext(optionsBuilder.Options);
        }
    }
}
