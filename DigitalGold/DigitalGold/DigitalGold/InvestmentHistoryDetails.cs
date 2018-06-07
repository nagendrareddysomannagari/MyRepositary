using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalGoldMember
{
    public class InvestmentHistoryDetails
    {
        List<InvestDto> dtoInvestment = new List<InvestDto>();

        public List<InvestDto> GetData()
        {
            dtoInvestment.Add(
                new InvestDto()
            {
                
                trnsactionType = "Buy",
                accumulatedGoldUnits = 12.59M,
                investedPrice = 4032,
                investmentAmount = 53436M,
                netInvestedAmount=50764.2M,
                gstValue=2671.8M,
                investmentDate = System.DateTime.Now.AddDays(-4)
               
            });

            dtoInvestment.Add(
                new InvestDto()
                {
                    
                    trnsactionType = "Buy",
                    accumulatedGoldUnits = 17.25M,
                    investedPrice = 3556,
                    investmentAmount = 64564M,
                    netInvestedAmount = 61335.8M,
                    gstValue = 3228.2M,
                    investmentDate = System.DateTime.Now.AddDays(-6.3)
                });

            return dtoInvestment;
        }
    }
}

