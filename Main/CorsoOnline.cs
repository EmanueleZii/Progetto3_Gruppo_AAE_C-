public class CorsoOnline : Corso
{
    private string Piattaforma { get; set; }
    private string LinkAccesso { get; set; }
    
    public string piattaforma { get { return Piattaforma; } set { Piattaforma = value; } }

    public string linkAccesso { get { return LinkAccesso; } set { LinkAccesso = value; } }

    public CorsoOnline(string titolo, int durataOre, string _piattaforma, string _linkAccesso, Docente _docente)
    {
        Piattaforma = _piattaforma;
        LinkAccesso = _linkAccesso;
        Titolo = titolo;
        DurataOre = durataOre;
        docente = _docente;
    }
    public override void StampaDettagli()
    {
        if (!(docente is null))
        {
            Console.WriteLine($"Accesso al corso online: {Titolo} su {Piattaforma}, docente: {docente.Nome}");
        }
        else
        {
            Console.WriteLine($"Accesso al corso online: {Titolo} su {Piattaforma}, docente: da assegnare");
        }
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