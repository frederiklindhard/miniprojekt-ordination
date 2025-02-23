namespace shared.Model;

public class DagligSkæv : Ordination {
    public List<Dosis> doser { get; set; } = new List<Dosis>();

    public DagligSkæv(DateTime startDen, DateTime slutDen, Laegemiddel laegemiddel) : base(laegemiddel, startDen, slutDen) {
	}

    public DagligSkæv(DateTime startDen, DateTime slutDen, Laegemiddel laegemiddel, Dosis[] doser) : base(laegemiddel, startDen, slutDen)
    {
        this.doser = doser.ToList();
    }    

    public DagligSkæv() : base(null!, new DateTime(), new DateTime()) {
    }

	public void opretDosis(DateTime tid, double antal)
    {
        doser.Add(new Dosis(tid, antal));
    }

	public override double samletDosis()
    {
		return base.antalDage() * doegnDosis();
	}

    // TODO: Implement!
    // Viser den gennemsnitlige døgndosis for en periode
    public override double doegnDosis()
    {
        double antalDage = base.antalDage();
        double samletDoser = 0;

        foreach (var dose in doser)
        {
            samletDoser += dose.antal;
        }
        return Math.Round(samletDoser);
    }

	public override String getType()
    {
		return "DagligSkæv";
	}
}
