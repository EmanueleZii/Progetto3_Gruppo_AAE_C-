public class CorsoOnline : Corso
{
    private string Piattaforma { get; set; }
    private string LinkAccesso { get; set; }
    
    public string piattaforma { get { return Piattaforma; } set { Piattaforma = value; } }

    public string linkAccesso { get { return LinkAccesso; } set { LinkAccesso = value; } }

    public CorsoOnline(string titolo, int durataOre, string _piattaforma, string _linkAccesso)
    {
        Piattaforma = _piattaforma;
        LinkAccesso = _linkAccesso;
        Titolo = titolo;
        DurataOre = durataOre;
    }
    public override void StampaDettagli()
    {
        Console.WriteLine($"Accesso al corso online: {Titolo} su {Piattaforma}");   
    }
    public override void ErogaCorso()
    {
        Console.WriteLine($"{Titolo} ({DurataOre} ore) - Piattaforma: {Piattaforma}");
    }

    public override string ToString()
    {
        return $"{Titolo} ({DurataOre} ore) - Piattaforma: {Piattaforma}";
    }
}