namespace shared.Model;

public class PN : Ordination {
	public double antalEnheder { get; set; }
    public List<Dato> dates { get; set; } = new List<Dato>();

    public PN (DateTime startDen, DateTime slutDen, double antalEnheder, Laegemiddel laegemiddel) : base(laegemiddel, startDen, slutDen)
    {
		this.antalEnheder = antalEnheder;
	}

    public PN() : base(null!, new DateTime(), new DateTime()) {
    }

    /// <summary>
    /// Registrerer at der er givet en dosis på dagen givesDen
    /// Returnerer true hvis givesDen er inden for ordinationens gyldighedsperiode og datoen huskes
    /// Returner false ellers og datoen givesDen ignoreres
    /// </summary>
    // TODO: Implement!
    public bool givDosis(Dato givesDen)
    {
        if (givesDen.dato.Date >= startDen.Date && givesDen.dato.Date <= slutDen.Date)
        {
            dates.Add(givesDen);
            return true;
        }
        return false;
    }

    // TODO: Implement!
    // Viser den gennemsnitlige døngdosis
    public override double doegnDosis()
    {
        return Math.Round(samletDosis() / base.antalDage());
    }

    public override double samletDosis()
    {
        return dates.Count() * antalEnheder;
    }

    public int getAntalGangeGivet()
    {
        return dates.Count();
    }

	public override String getType()
    {
		return "PN";
	}
}
