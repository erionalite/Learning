using System;
using System.Data.Common;
using Microsoft.Data.Sqlite;

namespace EllevationDataImport
{
    public class EllevationDataImportFixture 
    {
        
        public EllevationDataImportFixture(){
           using(var ctxt = new DataImportContext()){
                var genderName = "Male";
                var Code = 1;
                var genderCode = new GenderCodes(){ 
                    SisGenderName = genderName,
                    EllevationGenderCode = Code
                    };
            ctxt.GenderCodes.Add(genderCode);
            ctxt.SaveChanges();
           }
        }
        
    }
}
