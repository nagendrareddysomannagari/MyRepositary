using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalGoldMember
{
   public class InvestDto
    {
       public DateTime investmentDate { get; set; }
       public decimal investmentAmount { get; set; }
       public decimal accumulatedGoldUnits { get; set; }
       public string trnsactionType { get; set; }
       public decimal currentPrice { get; set; }
       public decimal investedPrice { get; set; }
       public decimal totalInvestedAmount { get; set; }
       public decimal totalInvestedAmountInADay { get; set; }
       public decimal gstValue { get; set; }
       public decimal sellingCommission { get; set; }
       public decimal netInvestedAmount { get; set; }
       public decimal netSaleAmount { get; set; }
       public decimal grossSaleAmount { get; set; }
       public decimal goldSaleUnits { get; set; }
    }
}
