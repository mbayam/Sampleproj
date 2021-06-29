using CoinJar.utils;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.interfaces
{
    public class CoinJarI : ICoinJar
    {
        StreamWriterAndRead streamWriterAndRead = new StreamWriterAndRead();
        public async void addCoin(ICoin coin)
        {
           var currentValue = GetTotalAmount();
           var newAmount = currentValue + coin.Amount;
           string text  = coin.Volume + "," + newAmount;
           await StreamWriterAndRead.AddCoin(text);
         
        }

        public decimal GetTotalAmount()
        {
            string text = System.IO.File.ReadAllText(@"C:\\Projects\\WriteText.txt");
            string[] values = text.Split(",");
            var amount = default(decimal);
            if(values.Length > 0)
            {
                amount = Convert.ToDecimal(values[1]);
            }

            return amount;
        }

        public async void Reset()
        {
            string text = 42 + "," + 0;
            await StreamWriterAndRead.AddCoin(text);
        }

        
    }
}
