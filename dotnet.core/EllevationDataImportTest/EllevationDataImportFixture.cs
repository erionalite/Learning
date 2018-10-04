using System;
using Xunit;
using System.Data.Common;
using Microsoft.Data.Sqlite;

namespace EllevationDataImportTest
{
    public class EllevationDataImportFixture : IDisposable
    {
        public SqliteConnection Connection { get;private set;}
        public EllevationDataImportFixture(){
            var conn = new SqliteConnection("Data Source=:memory:");
            Connection = conn;
            conn.Open();
            var comman = new SqliteCommand(@"Create table GenderCodes(id integer primvary key, name varchar(255) not null);",conn);
            comman.ExecuteNonQuery();
            
        }
        public void Dispose(){
            if(Connection != null){
                Connection.Dispose();
            }
        }
    }
}
