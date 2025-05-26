using System;
using System.Collections.Generic;

public abstract class Corso
{
    public string Titolo { get; set; }
    private int DurataOre { get; set; }
    
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

public class CorsoOnline : Corso
{
    private string Piattaforma { get; set; }
    private string LinkAccesso { get; set; }
    
    public string piattaforma { get { return Piattaforma; } set { Piattaforma = value; } }

    public string linkAccesso { get { return LinkAccesso; } set { LinkAccesso = value; } }

    public CorsoOnline(string titolo, int durataOre, string _piattaforma, string _linkAccesso) : base(titolo, durataOre)
    {
        Piattaforma = _piattaforma;
        LinkAccesso = _linkAccesso;
    }
    public override void StampaDettagli()
    {
        Console.WriteLine($"Accesso al corso online: {Titolo} su {Piattaforma}");   
    }
    public override void ErrogaCorso()
    {
        Console.WriteLine($"{Titolo} - {Descrizione} ({DurataOre} ore) - Categoria: {Categoria}");
    }

    public override string ToString()
    {
        return $"{Titolo} - {Descrizione} ({DurataOre} ore) - Categoria: {Categoria}";
    }
}