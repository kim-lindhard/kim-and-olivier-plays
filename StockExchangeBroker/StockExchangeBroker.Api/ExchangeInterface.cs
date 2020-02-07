using System;
using System.Collections.Generic;
using System.Linq;

namespace StockExhangeBroker.Api
{
    public class ExchangeInterface
    {
        public void BuyStock(string name, int nrOfStocks, DateTime sellDate)
        {
            
        }

        public void SellStocks(string stock, int nrOfStocks, in DateTime sellDate)
        {
        }

        public IEnumerable<Stock> ViewPortfolio()
        {
            return Enumerable.Empty<Stock>();
        } 
    }
}