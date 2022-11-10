/*
BONUS FILES

 Questa mattina abbiamo visto come lavorare (scrivere e leggere) i file attraverso c#. Come possiamo utilizzare questo strumento? Dato che stiamo costruendo un programma per la gestione di eventi aggiungiamo una funzionalità di Import/Export del programma di eventi (quello di milestone 3).
Una volta che avete quindi terminato tutte le milestone e anche il BONUS, facciamo il BONUS FILES:
si chieda all’utente di poter effettuare l’export del programma eventi in formato csv
si chieda all’utente di poter effettuare l’import del programma eventi in formato csv
Le informazioni del file conterranno quindi una lista di eventi divisa per linee le cui informazioni saranno divise per colonne attraverso il carattere della virgola , nel seguente modo:
titolo,data,capienza massima,posti prenotati
conferenza clima,22/01/2023,500,136
jazz lounge,03/02/2023,30,12
apericena,04/02/2023,20,18
corso c-sharp,07/12/2022,30,22
Attenzione alla fase di import: potremmo aver bisogno di fare dei controlli sui dati … magari qualcosa che abbiamo già fatto ci può tornare utile.
 */

public static class Esporta
{
    public static void NuovaEsportazione(List<Evento> eventi)
    {
        string path = "C:\\Users\\UTENTE\\Documents\\Corso_NET_Developer\\Esercizi\\csharp-gestore-eventi\\programmaEvento.csv";
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            StreamWriter file = File.CreateText(path);
            file.WriteLine("data,titolo,relatore,prezzo,capienza massima,posti prenotati");
            foreach (Evento evento in eventi)
            {
                string riga = evento.ToString();
                riga = riga.Replace('-', ',');
                if (evento.GetType().ToString() == " ")
                    riga += "";
                riga += "," + evento.capienzaMassima + "," + evento.postiPrenotati;
                file.WriteLine(riga);
            }
            file.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}