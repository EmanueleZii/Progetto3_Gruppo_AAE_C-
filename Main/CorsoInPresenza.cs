using System;


public class CorsoInPresenza : Corso
{
    private string _aula;
    private int _numeroPosti;

    public string Aula
    {
        get { return _aula; }
        set { _aula = value; }
    }
    public int NumeroPosti
    {
        get { return _numeroPosti; }
        set
        {
            if (value >= 1)
            {
                _numeroPosti = value;
            }
        }
    }

    public CorsoInPresenza(string titolo, int durataOre, string aula, int numeroPosti, Docente _docente)
    {
        NumeroPosti = numeroPosti;
        Aula = aula;
        DurataOre = durataOre;
        Titolo = titolo;
        docente = _docente;
    }

    public override void ErogaCorso()
    {
        Console.WriteLine($"Corso {Titolo} erogato.");
    }

    public override void StampaDettagli()
    {
        if (!(docente is null))
        {
            Console.WriteLine($"Corso: {Titolo}, durata in ore: {DurataOre}, aula: {Aula}, numero posti: {NumeroPosti}, docente: {docente.Nome}");
        }
        else
        {
            Console.WriteLine($"Corso: {Titolo}, durata in ore: {DurataOre}, aula: {Aula}, numero posti: {NumeroPosti}, docente: da assegnare");
        }
    }
}