using System;
using Xunit;

namespace StockExchangeBroker.features
{
    public class Scenario_ViewCurrentPortfolio
    {
        public Scenario_ViewCurrentPortfolio()
        {
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
            throw new NotImplementedException();
        }

        private void Current_share_value_of(string stock, decimal stockValue)
        {
            throw new NotImplementedException();
        }

        private void I_sold_shares(string stock, int nrOfStocks, DateTime sellDate)
        {
            throw new NotImplementedException();
        }

        private void I_bought_shares(string stock, int nrOfStocks, DateTime buyDate)
        {
            throw new NotImplementedException();
        }

        private string XpPractitionersIncorporated { get; set; }

        private string CrafterMastersLimited { get; set; }

        private string OldSchoolWaterfallSoftwareLimited { get; set; }

        #endregion
    }
}
