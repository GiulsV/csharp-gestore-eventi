using System.Diagnostics;

public class Conferenza : Evento
{
    private double _prezzo;
    public string Relatore { get; set; }
    public double Prezzo
    {
        get => _prezzo;
        set
        {
            if (_prezzo < 0) throw new Exception("Il prezzo deve essere per forza positivo");
            _prezzo = value;
        }
    }
    public Conferenza(string titolo, DateTime data, int capienza, string relatore, double prezzo) : base(titolo, data, capienza)
    {
        Relatore = relatore;
        Prezzo = prezzo;

    }


    //public override string ToString()
    //{
    //    return base.ToString();
    //}

}