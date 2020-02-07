using System;
using System.Collections.Generic;
using StockExchangeBroker.Infrastructure;
using StockExhangeBroker.Api;
using Xunit;

namespace StockExchangeBroker.features
{
    public class Scenario_ViewCurrentPortfolio
    {
        private ExchangeInterface _exchangeInterface;
        private StockRepositoryDummy _stockRepositoryDummy;
        private IEnumerable<Stock> _portFolio;

        public Scenario_ViewCurrentPortfolio()
        {
            _exchangeInterface = new ExchangeInterface();
            //Given
            I_bought_shares(OldSchoolWaterfallSoftwareLimited, 1000, new DateTime(1990, 2, 14));
            I_bought_shares(CrafterMastersLimited, 400, new DateTime(2016, 6, 10));
            I_bought_shares(XpPractitionersIncorporated, 700, new DateTime(2018, 12, 10));
            I_sold_shares(OldSchoolWaterfallSoftwareLimited, 500, new DateTime(2018, 12, 11));
            Current_share_value_of(OldSchoolWaterfallSoftwareLimited, 5.75m);
            Current_share_value_of(CrafterMastersLimited, 17.25m);
            Current_share_value_of(XpPractitionersIncorporated, 25.55m);

            //When
            I_print_the_portfolio();
        }

        [Fact]
        public void Fivehundered_OldSchool_stocks_sold()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Fourhundered_Crafter_stocks_bought()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void Sevenhundered_Practitioners_stocks_bought()
        {
            throw new NotImplementedException();
        }

        #region private parts
        
        private void I_print_the_portfolio()
        {
            _portFolio = _exchangeInterface.ViewPortfolio();
        }

        private void Current_share_value_of(string stock, decimal stockValue)
        {
            _stockRepositoryDummy.SetCurrentStockValue(stock, stockValue);
        }

        private void I_sold_shares(string stock, int nrOfStocks, DateTime sellDate)
        {
            _exchangeInterface.SellStocks(stock, nrOfStocks, sellDate);
        }

        private void I_bought_shares(string stock, int nrOfStocks, DateTime buyDate)
        {
           _exchangeInterface.BuyStock(stock,nrOfStocks, buyDate);
        }

        private string XpPractitionersIncorporated { get; set; }

        private string CrafterMastersLimited { get; set; }

        private string OldSchoolWaterfallSoftwareLimited { get; set; }

        #endregion
    }

    internal class StockRepositoryDummy : IStockRepository
    {
        public void SetCurrentStockValue(string stock, decimal stockValue)
        {
        }
    }
}
