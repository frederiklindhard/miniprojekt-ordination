namespace ordination_test;

using Microsoft.EntityFrameworkCore;

using Service;
using Data;
using shared.Model;

[TestClass]
public class OpretPNTest
{
    private readonly DataService service;

    public OpretPNTest()
    {
        var optionsBuilder = new DbContextOptionsBuilder<OrdinationContext>();
        optionsBuilder.UseInMemoryDatabase(databaseName: "test-database");
        var context = new OrdinationContext(optionsBuilder.Options);
        service = new DataService(context);
        service.SeedData();
    }

    [TestMethod]
    public void PNOprettelse()
    {
        Patient p = service.GetPatienter().First();
        Laegemiddel lm = service.GetLaegemidler().First();

        service.OpretPN(p.PatientId, lm.LaegemiddelId, 5, DateTime.Now, DateTime.Now.AddDays(10));
        Assert.AreEqual(5, service.GetPNs().Count());
    }

}
