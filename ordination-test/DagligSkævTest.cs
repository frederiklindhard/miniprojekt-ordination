namespace ordination_test;

using shared.Model;

[TestClass]
public class DagligSkævTest
{
    //Der er noget galt med den måde vi opretter en Dagligskæv ordination... Den kan ikke finde ud af TimeOnly" og derfor kan vi ikke afprøve testen
    /*
    [TestMethod]
    public void DoegnDosisTC3()
    {
        
        DagligSkæv dagligSkæv = new DagligSkæv(new DateTime(2022, 11, 23), new DateTime(2022, 11, 24), new Laegemiddel("Paracetamol", 1, 1.5, 2, "Ml"), new Dosis(TimeOnly 12, 0, 0), 0.5);
        Assert.AreEqual(8, dagligSkæv.doegnDosis());
        
    }
    */

}