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


    
    
    if (span < 0)
    {
        throw new ArgumentException("La lunghezza deve essere maggiore o uguale a zero");
    }

    if (span == 0)
    {
        
        
        return 1;
    }

    
    
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
