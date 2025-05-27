using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Corso> corsi = new List<Corso>();
        List<Docente> docenti = new List<Docente>();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenù");
            Console.WriteLine("[1] Aggiungi corso in presenza");
            Console.WriteLine("[2] Aggiungi corso online");
            Console.WriteLine("[3] Eroga corsi");
            Console.WriteLine("[4] Stampa dettagli");
            Console.WriteLine("[5] Aggiungi docente");
            Console.WriteLine("[6] Visualizza docenti");
            Console.WriteLine("[0] Esci");
            Console.Write("Scelta: ");
            int menuAction = int.Parse(Console.ReadLine());

            switch (menuAction)
            {
                case 1:
                    Console.Write("\nInserisci titolo corso: ");
                    string titolo = Console.ReadLine();
                    Console.Write("\nInserisci durata in ore: ");
                    int durataOre = int.Parse(Console.ReadLine());
                    Console.Write("\nInserisci aula: ");
                    string aula = Console.ReadLine();
                    Console.Write("\nInserisci numero di posti: ");
                    int numeroPosti = int.Parse(Console.ReadLine());
                    Console.Write("\nInserisci il docente: ");
                    string nomeDocente = Console.ReadLine();
                    bool esiste = false;
                    Docente docente = null;
                    
                    foreach (Docente d in docenti)
                    {
                        if (d.Nome == nomeDocente)
                        {
                            esiste = true;
                            docente = d;
                        }
                    }

                    if (esiste)
                    {
                        corsi.Add(new CorsoInPresenza(titolo, durataOre, aula, numeroPosti, docente));
                    }
                    else
                    {
                        corsi.Add(new CorsoInPresenza(titolo, durataOre, aula, numeroPosti, null));
                    }
                    
                    break;

                case 2:
                    Console.Write("\nInserisci titolo corso: ");
                    titolo = Console.ReadLine();
                    Console.Write("\nInserisci durata in ore: ");
                    durataOre = int.Parse(Console.ReadLine());
                    Console.Write("\nInserisci la piattaforma: ");
                    string piattaforma = Console.ReadLine();
                    Console.Write("\nInserisci numero di posti: ");
                    string linkAccesso = Console.ReadLine();
                    Console.Write("\nInserisci il docente: ");
                    nomeDocente = Console.ReadLine();
                    esiste = false;
                    docente = null;

                    foreach (Docente d in docenti)
                    {
                        if (d.Nome == nomeDocente)
                        {
                            esiste = true;
                            docente = d;
                        }
                    }

                    if (esiste)
                    {
                        corsi.Add(new CorsoOnline(titolo, durataOre, piattaforma, linkAccesso, docente));
                    }
                    else
                    {
                        corsi.Add(new CorsoOnline(titolo, durataOre, piattaforma, linkAccesso, null));
                    }

                    break;

                case 3:
                    foreach (Corso c in corsi)
                    {
                        c.ErogaCorso();
                    }
                    break;

                case 4:
                    foreach (Corso c in corsi)
                    {
                        c.StampaDettagli();
                    }
                    break;

                case 5:
                    Console.Write("\nInserisci nome docente: ");
                    string nome = Console.ReadLine();
                    Console.Write("\nInserisci materia: ");
                    string materia = Console.ReadLine();
                    docenti.Add(new Docente(nome, materia));
                    break;

                case 6:
                    Console.WriteLine("\nDocenti:");
                    foreach (Docente d in docenti)
                    {
                        Console.WriteLine($"Nome: {d.Nome}, materia: {d.Materia}");
                    }
                    break;

                case 0:
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }
    }
}