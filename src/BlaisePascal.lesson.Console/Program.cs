public class Program // Questa è una classe
{
    //Metodo di entrata per esecuzione del codice
    public static void Main()
    { 
        Console.WriteLine("Benvenuto nella libreria Easy Library!");


        // Console.ReadLine() ci permette di leggere l'imput del cliente
        // successivamnete assegno il valore letto alla variabile nomeCliente
        Console.WriteLine("Inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine($"Benvenuto {nomeCliente}");
        Console.WriteLine("Inserisci il tipo di spedizione");
        Console.WriteLine("Inserisci il numero di pacchi acquistati")
        int numeroPacchiComprati = int.Parse(Console.ReadLine());
        

        int costoSpedizioneSingoloPacco = 5; // dichiarazione + assegnazione 
        costoSpedizioneSingoloPacco = 10; // assegnazione

        string tipoConsegna = "Standard"; // dichiarazione

        int costoTotale = costoSpedizioneSingoloPacco * numeroPacchiComprati;


        // Stampa a  video con concatenazione di stringhe e variabili
        // oppure: ($" Il tipo di consegna selezionato è: {tipoConsegna}" e il costo totale è: {costoTotale}) per unire le due righe
        // $ carattere speciale per interpolazione di righe
        Console.WriteLine("Il tipo di consegna selezionata è: " + tipoConsegna);  
        Console.WriteLine(costoTotale);
    }
    
} 