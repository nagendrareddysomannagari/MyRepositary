using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalGoldMember;

namespace DigitalGoldBusinessOperations
{
    public interface  IDigitalGoldOperations
    {
         void CalculateData(DigitalGoldDataMembers obj);
         void RandomGoldRate(DigitalGoldDataMembers obj);
         decimal CalculateProfitorLoss(decimal totalAccumalatedGoldUnits, decimal totalGoldUnits, decimal currentPrice);
         decimal RandomGoldRate();
         decimal CalculateComission(decimal goldSaleUnits);
         decimal CalculateGST(decimal investmentAmount);
         decimal CalculateGoldUnits(decimal netInvestmentAmount, decimal currentPrice);
    }
}
