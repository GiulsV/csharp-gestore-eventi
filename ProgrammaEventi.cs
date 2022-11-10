public class ProgrammaEventi
{
    string Titolo;
    public List<Evento> eventi;

    public ProgrammaEventi(string titolo)
    {
        this.Titolo = titolo;
        eventi = new List<Evento>();
    }

    // METODO 1
        //add evento
    public void AggiungiEvento(Evento evento)
    {
        this.eventi.Add(evento);
    }
        //add conferenza
    public void AggiungiConferenza(Conferenza conferenza)
    {
        this.eventi.Add(conferenza);
    }

    // METODO 2
    public string EventiData(DateTime dataRicerca)
    {
        string stringa = "\n";
        foreach (Evento evento in eventi)
        {
            if (evento.Data.Date == dataRicerca.Date)
            {
                stringa += evento.RigaLista() + "\n";
            }
        }
        stringa += "\n";
        return stringa;
    }

    // METODO 3
    public string StampaListaEventi()
    {
        string stringa = "";

        foreach (Evento evento in eventi)
        {
            stringa += " " + "\n";
            stringa += evento.RigaLista() + "\n";
        }
        return stringa;
    }

    // METODO 4
    public int NumeroEventi()
    {
        return this.eventi.Count();
    }

    // METODO 5
    public void SvuotaEventi()
    {
        this.eventi.Clear();
    }

    // METODO 6
    public override string ToString()
    {
        string stringa = "Nome evento: " + this.Titolo + " \n";
        foreach (Evento evento in eventi)
        {
            stringa += evento.RigaLista() + "\n";
        }
        stringa += "\n ";
        return stringa;
    }
}
