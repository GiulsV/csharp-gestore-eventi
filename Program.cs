// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* 
 MILESTONE 1

Per prima cosa è necessario creare una classe Evento che abbia i seguenti attributi:
    ● titolo
    ● data
    ● capienza massima dell’evento
    ● numero di posti prenotati

Aggiungere metodi getter e setter in modo che:
    ● titolo sia in lettura e in scrittura
    ● data sia in lettura e scrittura
    ● numero di posti per la capienza massima sia solo in lettura
    ● numero di posti prenotati sia solo in lettura

ai setters inserire gli opportuni controlli in modo che la data non sia già passata, che il titolo non sia vuoto e che la capienza massima di posti sia un numero positivo. 
In caso contrario sollevare opportune eccezioni.

Dichiarare un costruttore che prenda come parametri il titolo, la data e i posti a disposizione e inizializza gli opportuni attributi facendo uso dei metodi e controlli già fatti. 
Per l’attributo posti prenotati invece si occupa di inizializzarlo lui a 0.

Vanno inoltre implementati dei metodi public che svolgono le seguenti funzioni:
    1. PrenotaPosti: aggiunge i posti passati come parametro ai posti prenotati. Se l’evento è già passato o non ha posti o non ha più posti disponibili deve sollevare un’eccezione.

    2. DisdiciPosti: riduce del i posti prenotati del numero di posti indicati come parametro. Se l’evento è già passato o non ci sono i posti da disdire sufficienti, deve sollevare un’eccezione.

    3. l’override del metodo ToString() in modo che venga restituita una stringa contenente: data formattata – titolo
        Per formattare la data correttamente usate nomeVariabile.ToString("dd/MM/yyyy"); applicata alla vostra variabile DateTime.

Le eccezioni possono essere generiche (Exception) o usate quelle già messe a disposizione da C#, ma aggiungete un eventuale messaggio chiaro per comunicare che cosa è successo.

Vi ricordo che man mano che andrete avanti con le altre milestones, potrete aggiungere più avanti altri eventuali metodi (public e private) che vi aiutino a svolgere le funzioni richieste se ritenete necessari!
 */

/*
 MILESTONE 2
    1. Nel vostro programma principale Program.cs, chiedete all’utente di inserire un nuovo evento con tutti i parametri richiesti dal costruttore.

    2. Dopo che l’evento è stato istanziato, chiedete all’utente se e quante prenotazioni vuole fare e provare ad effettuarle.

    3. Stampare a video il numero di posti prenotati e quelli disponibili.

    4. Ora chiedere all’utente fintanto che lo desidera, se e quanti posti vuole disdire. Ogni volta che disdice dei posti, stampare i posti residui e quelli prenotati.

Attenzione: In questa prima fase non è necessario gestire le eventuali eccezioni da Program.cs che potrebbero insorgere, eventualmente il programma si blocca se qualcosa va storto che voi avevate già previsto.
Piuttosto pensate bene alla logica del vostro programma principale e della vostra classe Evento pensando bene alle responsabilità dei metodi e alla visibilità di attributi e metodi.
 */
/*
//MILESTONE 2

Console.WriteLine("Gestione Eventi");

//1 - Nuovo evento
Console.Write("Inserisci il nome dell'evento: ");

string nome = Console.ReadLine();

Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");

DateTime data = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserisci il numero di posti totali: ");

int posti = Convert.ToInt32(Console.ReadLine());

try {
    
    Evento test = new Evento(nome, data, posti);

    //2 - Pronotare posti
    Console.Write("Quanti posti desideri prenotare? ");

    int postiPrenotati = Convert.ToInt32(Console.ReadLine());

    //3 - Stampa posti prenotati/rimanenti
    test.PrenotaPosti(postiPrenotati);
    Console.WriteLine(test.StampaPosti());

    //4 - Disdetta
    bool disdici = true;
    do
    {
        Console.Write("Vuoi disdire dei posti? [ s ] o [ n ] ");
        string disdetta = Console.ReadLine();
        
        if (disdetta == "s")
        {
            Console.Write("Indica il numero di posti da disdire: ");
            int postiDisdetta = Convert.ToInt32(Console.ReadLine());
            test.DisdiciPosti(postiDisdetta);
            Console.WriteLine(test.StampaPosti());
        }
        else { 
            Console.WriteLine("Ok, va bene!");
            disdici = false;
        }

    } while (disdici);

}catch (GestoreEventiException)
{
    Console.WriteLine(posti.ToString());
}
*/

/*
 MILESTONE 3
Creare una classe ProgrammaEventi con i seguenti attributi
    ● string Titolo
    ● List<Evento> eventi

Nel costruttore valorizzare il titolo, passato come parametro, e inizializzate la lista di eventi come una nuova Lista vuota di eventi.

Aggiungete poi i seguenti metodi:
    ● un metodo che aggiunge alla lista del programma eventi un Evento, passato come parametro al metodo.

    ● un metodo che restituisce una lista di eventi con tutti gli eventi presenti in una certa data.
    ● un metodo statico che si occupa, presa una lista di eventi, di stamparla in Console, o ancora meglio vi restituisca la rappresentazione in stringa della vostra lista di eventi.

    ● un metodo che restituisce quanti eventi sono presenti nel programma eventi attualmente.

    ● un metodo che svuota la lista di eventi.

    ● un metodo che restituisce una stringa che mostra il titolo del programma e tutti gl eventi aggiunti alla lista. 
     Come nell’esempio qui sotto:
        Nome programma evento:
            data1 - titolo1
            data2 - titolo2
            data3 - titolo3
            …
 */

ProgrammaEventi programmaEventiTest = new ProgrammaEventi("TestEventi");

Console.Write("Inserisci il nome dell'evento: ");
string nome = Console.ReadLine();
Console.Write("Inserisci la data dell'evento: ");
DateTime data = Convert.ToDateTime(Console.ReadLine());
Console.Write("Inserisci il numero di posti totali: ");
int posti = Convert.ToInt32(Console.ReadLine());

Evento eventoTest = new Evento(nome, data, posti);

Console.Write("Quanti posti desideri prenotare? ");
int postiPrenotati = Convert.ToInt32(Console.ReadLine());
eventoTest.PrenotaPosti(postiPrenotati);
Console.WriteLine(eventoTest.StampaPosti());
programmaEventiTest.AggiungiEvento(eventoTest);
Console.WriteLine("----------------------Test Stampa-------------------------");
Console.WriteLine(eventoTest.RigaLista());