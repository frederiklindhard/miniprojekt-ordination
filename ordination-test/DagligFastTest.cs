namespace ordination_test;

using shared.Model;

[TestClass]
public class DagligFastTest 
{
    [TestMethod]
    public void DoegnDosisTC1()
    {
        DagligFast dagligfast = new DagligFast(new DateTime(2022, 11, 23), new DateTime(2022, 11, 24), new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"), 1, 2, 3, 2);
        Assert.AreEqual(8, dagligfast.doegnDosis());
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void DoegnDosisTC2()
    {
        DagligFast dagligfast = new DagligFast(new DateTime(2022, 11, 23), new DateTime(2022, 11, 24), new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"), -1, -2, -3, -2);
        dagligfast.doegnDosis();
    }
      [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void DoegnDosisTC3()
    {
        DagligFast dagligfast = new DagligFast(new DateTime(2022, 11, 23), new DateTime(2022, 11, 24), new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"), 2, 19, 5, 6);
        dagligfast.doegnDosis();
    }

}