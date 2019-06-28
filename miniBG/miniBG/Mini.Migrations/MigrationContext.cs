using Microsoft.EntityFrameworkCore;
using Mini.Data;
using System;

namespace Mini.Migrations
{
    public class MigrationContext : MiniDbContext
    {
        public MigrationContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;uid=root;pwd=root;database=mini_db;charset=utf8;sslMode=None");
        }
    }
}
