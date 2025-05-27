using System;
public abstract class Corso
{
    public string Titolo { get; set; }
    private int durataOre;
    public Docente docente { get; set; }



    public int DurataOre
    {
        get { return durataOre; }
        set
        {
            if (value >= 0)
                durataOre = value;
        }
    }

    public Corso()
    {
        Titolo = "";
        DurataOre = 0;
    }

    public abstract void ErogaCorso();
    public abstract void StampaDettagli();
}
