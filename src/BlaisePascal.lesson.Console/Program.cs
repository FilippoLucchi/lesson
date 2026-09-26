public class Program // Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    { 
        Console.WriteLine("Benvenuto nella libreria Easy Library!");

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione 
        costoSpedizioneSingoloPacco = 10; // assegnazione

        int numeroPacchiComprati = 2;

        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;


        // Stampa a  video con concatenazione di stringhe e variabili
        // oppure: ($" Il tipo di consegna selezionato è: {tipoConsegna}" e il costo totale è: {costoTotale}) per unire le due righe
        // $ carattere speciale per interpolazione di righe
        Console.WriteLine("Il tipo di consegna selezionata è: " + tipoConsegna);  
        Console.WriteLine(costoTotale);
    }
    
} 