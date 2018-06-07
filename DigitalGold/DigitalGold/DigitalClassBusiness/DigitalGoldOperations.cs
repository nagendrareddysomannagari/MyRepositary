using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DigitalGoldMember;


namespace DigitalGoldBusinessOperations
{
  public  class DigitalGoldOperations: IDigitalGoldOperations
    {

        public void CalculateData(DigitalGoldDataMembers obj)
        {
            throw new NotImplementedException();
        }

        public void RandomGoldRate(DigitalGoldDataMembers obj)
        {
            throw new NotImplementedException();
        }

        public decimal CalculateProfitorLoss(decimal totalInvestmentAmount, decimal totalAccumalatedGoldUnits, decimal currentPrice)
        {
            decimal totalProfitorLossAmount;
            decimal currentTotalUnitsValue = (totalAccumalatedGoldUnits * Convert.ToDecimal(currentPrice)) - (totalAccumalatedGoldUnits * 100);
            totalProfitorLossAmount = totalInvestmentAmount - currentTotalUnitsValue;

            decimal plPercent = Math.Round(totalProfitorLossAmount / totalInvestmentAmount, 2);
            return plPercent;
        }

        public decimal RandomGoldRate()
        {
            Random random = new Random();
            int randomNumber = random.Next(3000, 5000);
            return randomNumber;
        }

        public decimal CalculateComission(decimal goldSaleUnits)
        {
            decimal sellingCommission = goldSaleUnits * 100;

            return sellingCommission;
        }

        public decimal CalculateGST(decimal investmentAmount)
        {
            decimal amount = investmentAmount;
            amount = (amount * 5) / 100;
           decimal gstValue = Math.Round(amount, 2);
           return gstValue;
        }

        public decimal CalculateGoldUnits(decimal netInvestmentAmount, decimal currentPrice)
        {
            decimal accumulatedGoldUnits = Math.Round(netInvestmentAmount / currentPrice, 2);
            return accumulatedGoldUnits;
        }


    }
}
