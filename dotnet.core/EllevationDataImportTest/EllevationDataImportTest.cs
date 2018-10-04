using Xunit;

namespace EllevationDataImportTest
{
    public class EllevationDataImportTest : IClassFixture<EllevationDataImportFixture>{
        private EllevationDataImportFixture fixture;
        public EllevationDataImportTest(EllevationDataImportFixture fixture){
            this.fixture = fixture;
        }
        [Fact]
        public void Test(){
            Assert.True(true);
        }
    }
}