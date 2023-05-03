# longSLice



Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.



``` 

using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
   public static long GetLargestProduct(string digits, int span)
{
    if (span > digits.Length)
    {
        
        throw new ArgumentException("La lunghezza non può essere maggiore della lunghezza della stringa di cifre");
    
    }


``` 


questa porzione di codice è una condizione che verifica se la variabile "span" è maggiore della lunghezza dell'array "digits".
Se è vera, cioè "span" è effettivamente maggiore della lunghezza dell'array "digits",e aloora  viene lanciata un'eccezione di tipo "ArgumentException" con il messaggio "La lunghezza non può essere maggiore della lunghezza della stringa di cifre".


   ```  
    
    if (span < 0)
    {
        throw new ArgumentException("La lunghezza deve essere maggiore o uguale a zero");
    }

    if (span == 0)
    {
        
        
        return 1;
    }
    
   ```  

  Il primo if controlla se "span" è minore di zero. Se questa è vero, viene lanciata un'eccezione di tipo "ArgumentException" con il messaggio "La lunghezza deve essere maggiore o uguale a zero"
Il secondo if controlla se "span" è uguale a zero. Se è vero, il metodo restituisce il valore 1. Questo è un controllo per il caso in cui la lunghezza specificata sia zero, il che significa che non ci sono cifre da utilizzare per creare il numero richiesto. In questo caso, la funzione restituisce 1, poiché c'è solo un modo per rappresentare il numero zero con zero cifre: il valore zero stesso.
    
    
        ```  
        
    long largestProduct = 0;

   
    for (int i = 0; i <= digits.Length - span; i++)
    {
       
        long product = 1;

       for (int j = 0; j < span; j++)
        {
            if (!Char.IsDigit(digits[i + j]))
            {
                throw new ArgumentException("La stringa  deve contenere solo cifre");
            }

            int digit = Convert.ToInt32(digits[i + j].ToString());
            product *= digit;
        }
       

        if (product > largestProduct)
        {
            largestProduct = product;
        }
    }

    return largestProduct;
}

}

  ```  
  
  

Questa porzione di codice calcola il prodotto più grande di una serie di "span" cifre all'interno di una stringa "digits" che contiene solo cifre.

In particolare, il codice itera attraverso ogni possibile serie di "span" cifre all'interno della stringa "digits". Per ogni serie, il codice verifica che tutte le cifre siano effettivamente cifre (e non caratteri non numerici) e quindi calcola il prodotto delle cifre nella serie.

Se il prodotto appena calcolato è maggiore del valore di "largestProduct" che inizialmente è 0, il valore di "largestProduct" viene aggiornato con il valore del nuovo prodotto.

Alla fine dell'iterazione, il valore di "largestProduct" rappresenta il prodotto più grande tra tutte le possibili serie di "span" cifre nella stringa "digits".

Se la stringa "digits" non contiene solo cifre, viene lanciata un'eccezione di tipo "ArgumentException" con il messaggio "La stringa deve contenere solo cifre".

