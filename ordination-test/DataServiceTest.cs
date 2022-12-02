namespace ordination_test;

using Microsoft.EntityFrameworkCore;

using Service;
using Data;
using shared.Model;

[TestClass]
public class DataServiceTest
{
    private readonly DataService service;

    public DataServiceTest()
    {
        var optionsBuilder = new DbContextOptionsBuilder<OrdinationContext>();
        optionsBuilder.UseInMemoryDatabase(databaseName: "test-database");
        var context = new OrdinationContext(optionsBuilder.Options);
        service = new DataService(context);
        service.SeedData();
    }
    //Den kan ikke genkende GetAnbefaletDosisPerDøgn, og derfor virker testen ikke
    /*
    
    
    [TestMethod]
    public void GetAnbefaletdosisPerDøgnTC2(int patientId, int laegemiddelId)
    {

        DataService dataService= service.GetAnbefaletDosisPerDøgn = new DataService(service.GetAnbefaletDosisPerDøgn(0, 1));
       
        Assert.AreEqual(95.1, service.GetAnbefaletDosisPerDøgn());
    }
    */
}
    






