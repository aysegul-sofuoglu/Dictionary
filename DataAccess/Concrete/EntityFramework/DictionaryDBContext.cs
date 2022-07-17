using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class DictionaryDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localDB)\mssqllocaldb;Database=DictionaryDB;Trusted_Connection=true");
        }

        public DbSet<Word> Words  { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
