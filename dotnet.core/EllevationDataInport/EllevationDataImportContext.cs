using System.Data.Common;
using System.Collections;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

 namespace EllevationDataImport{
    public class DataImportContext : DbContext{
        
        public DbSet<GenderCodes> GenderCodes{ get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Filename=ellevation.db");
        }
    }
}