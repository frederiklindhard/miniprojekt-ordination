namespace shared.Model;
using static shared.Util;

public class DagligFast : Ordination {
	
	public Dosis MorgenDosis { get; set; } = new Dosis();
    public Dosis MiddagDosis { get; set; } = new Dosis();
    public Dosis AftenDosis { get; set; } = new Dosis();
    public Dosis NatDosis { get; set; } = new Dosis();

	public DagligFast(DateTime startDen, DateTime slutDen, Laegemiddel laegemiddel, double morgenAntal, double middagAntal, double aftenAntal, double natAntal) : base(laegemiddel, startDen, slutDen)
	{
        MorgenDosis = new Dosis(CreateTimeOnly(6, 0, 0), morgenAntal);
        MiddagDosis = new Dosis(CreateTimeOnly(12, 0, 0), middagAntal);
        AftenDosis = new Dosis(CreateTimeOnly(18, 0, 0), aftenAntal);
        NatDosis = new Dosis(CreateTimeOnly(23, 59, 0), natAntal);

        if (morgenAntal < 0 || morgenAntal > 30 || middagAntal < 0 || middagAntal > 30 || aftenAntal < 0 || aftenAntal > 30 || natAntal < 0 || natAntal > 30)
        {
            throw new Exception("Fejlværdi");
        }
        double samletDoegnDosisFast = MorgenDosis.antal + MiddagDosis.antal + AftenDosis.antal + NatDosis.antal;
		if (samletDoegnDosisFast > 30)
        {
			throw new Exception("Fejlværdi");
        }

    }

    public DagligFast() : base(null!, new DateTime(), new DateTime()) {
    }

	public override double samletDosis()
	{
		return base.antalDage() * doegnDosis();
	}

    // TODO: Implement!
	// Summere den samlede døgndosis
    public override double doegnDosis()
	{
		double samletDoegnDosisFast = MorgenDosis.antal + MiddagDosis.antal + AftenDosis.antal + NatDosis.antal;

		return samletDoegnDosisFast;
    }
	
	public Dosis[] getDoser()
	{
		Dosis[] doser = {MorgenDosis, MiddagDosis, AftenDosis, NatDosis};
		return doser;
	}

	public override String getType()
	{
		return "DagligFast";
	}
}
