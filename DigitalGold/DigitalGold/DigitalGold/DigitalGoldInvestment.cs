using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DigitalGoldBusinessOperations;
using System.IO;

namespace DigitalGoldMember
{
    public partial class frmDigitalGold : Form
    {
        List<InvestDto> investmentCollection = new List<InvestDto>();
        InvestDto investementDetails;
        InvestmentHistoryDetails historyDetails = new InvestmentHistoryDetails();
        DigitalGoldOperations objOperations = new DigitalGoldOperations();

        decimal totalInvestmentAmount = 0;
        decimal totalAccumalatedGoldUnits = 0;
        decimal totalDayInvestment = 0;

        public frmDigitalGold()
        {
            InitializeComponent();
        }

        private void btnInvest_Click(object sender, EventArgs e)
        {

            BuyGold();
        }

        /// <summary>
        /// Code to Buy transaction
        /// </summary>
        private void BuyGold()
        {
            try
            {
                investementDetails = new InvestDto();
                investementDetails.gstValue = objOperations.CalculateGST(Convert.ToDecimal(txtInvAmount.Text));
                investementDetails.investedPrice = Convert.ToDecimal(txtGoldRate.Text);
                investementDetails.investmentAmount = Convert.ToDecimal(txtInvAmount.Text);
                totalDayInvestment = totalDayInvestment + investementDetails.investmentAmount;
                if (!DaylimitValidation(totalDayInvestment, investementDetails))
                {
                    totalDayInvestment = totalDayInvestment - investementDetails.investmentAmount;
                    return;
                }
               
                if (!BuyValidation(investementDetails))
                {
                    return;
                }
                investementDetails.netInvestedAmount = investementDetails.investmentAmount - investementDetails.gstValue;
                investementDetails.accumulatedGoldUnits = objOperations.CalculateGoldUnits(investementDetails.netInvestedAmount, investementDetails.investedPrice);
                investementDetails.trnsactionType = "Buy";
                investementDetails.investmentDate = System.DateTime.Now;
                totalInvestmentAmount = totalInvestmentAmount + investementDetails.investmentAmount;
                totalAccumalatedGoldUnits = totalAccumalatedGoldUnits + investementDetails.accumulatedGoldUnits;
                investmentCollection.Add(investementDetails);
                DisplayTotalDetails();
                BindData(investmentCollection);
                DisplayCalculateProfitorLoss();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }

        }

        private void BindData(List<InvestDto> objInvestmentCollection)
        {
            var source = new BindingSource();
            source.DataSource = investmentCollection;
            dtInvHistory.DataSource = source;
        }
        /// <summary>
        /// Code to Calculate Gold Units
        /// </summary>
        public void CalculateGoldsPerGram()
        {
            try
            {
                investementDetails.accumulatedGoldUnits = Math.Round(investementDetails.netInvestedAmount / investementDetails.currentPrice, 2);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleGold();
        }
        /// <summary>
        /// Code for Sale Transaction
        /// </summary>
        private void SaleGold()
        {
            try
            {
                investementDetails = new InvestDto();
                investementDetails.goldSaleUnits = Convert.ToDecimal(txtGldSaleUnits.Text);
                if (!SellValidation(investementDetails))
                {
                    return;
                }
                investementDetails.currentPrice = Convert.ToDecimal(txtGoldRate.Text);
                CalculateComission();
                investementDetails.grossSaleAmount = investementDetails.goldSaleUnits * investementDetails.currentPrice;
                investementDetails.netSaleAmount = investementDetails.grossSaleAmount - investementDetails.sellingCommission;
                investementDetails.trnsactionType = "Sale";
                investementDetails.investmentDate = System.DateTime.Now;
                CalculateTotalValues();
                investmentCollection.Add(investementDetails);
                DisplayTotalDetails();
                BindData(investmentCollection);
                DisplayCalculateProfitorLoss();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }

        }

        private void CalculateTotalValues()
        {
            totalAccumalatedGoldUnits = totalAccumalatedGoldUnits - investementDetails.goldSaleUnits;
            totalInvestmentAmount = totalInvestmentAmount - investementDetails.netSaleAmount;
        }
        /// <summary>
        /// Code to Calculate Commission
        /// </summary>
        private void CalculateComission()
        {
            investementDetails.sellingCommission = investementDetails.goldSaleUnits * 100;
        }

        private void frmDigitalGold_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayTotalDetails();
                RandomGoldRate();
                investmentCollection = historyDetails.GetData();
                totalInvestmentAmount = investmentCollection.Select(a => a.investmentAmount).Sum();
                totalAccumalatedGoldUnits = investmentCollection.Select(a => a.accumulatedGoldUnits).Sum();
                DisplayTotalDetails();
                DisplayCalculateProfitorLoss();
                BindData(investmentCollection);
                GridColumnNameChanges(dtInvHistory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }

        }
        /// <summary>
        /// Code to Calculate one Day Investment
        /// </summary>
        private void DisplayTotalDetails()
        {
            lblTotalInvestment.Text = "Total Investment :: " + totalInvestmentAmount;
            lblTotalGoldAccu.Text = "Total  Accumulated Gold Units :: " + totalAccumalatedGoldUnits;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtGoldRate.Text = Convert.ToString(objOperations.RandomGoldRate());
            DisplayCalculateProfitorLoss();
        }
        /// <summary>
        /// Code to Price Update
        /// </summary>
        private void RandomGoldRate()
        {
            Random r = new Random();
            int n = r.Next(3000, 5000);
            txtGoldRate.Text = Convert.ToString(n);
        }
        /// <summary>
        /// Code to check Buy Validation
        /// </summary>
        /// <param name="investementDetails"></param>
        /// <returns></returns>
        private bool BuyValidation(InvestDto investementDetails)
        {
            bool IsValid = true;
            if (investementDetails.investmentAmount <= 0)
            {
                MessageBox.Show("Please enter Investment Amount between 1 to 20000");
                IsValid = false;
            }
            return IsValid;

        }
        /// <summary>
        /// Code to Validate Sell Transaction Validation
        /// </summary>
        /// <param name="investementDetails"></param>
        /// <returns></returns>

        private bool SellValidation(InvestDto investementDetails)
        {
            bool IsValid = true;
            try
            {

                if (investementDetails.goldSaleUnits <= 0)
                {
                    MessageBox.Show(" Sale Units should be greater than zero");
                    IsValid = false;

                }
                if (investementDetails.goldSaleUnits > totalAccumalatedGoldUnits)
                {
                    MessageBox.Show(" Sale Units should be equal or less than Total Accumulated Gold Units");
                    IsValid = false;
                }

            }
            catch (Exception ex)
            {
                IsValid = false;
                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }
            return IsValid;
        }
        /// <summary>
        /// Code to Validate Day Limit Invetment Amount
        /// </summary>
        /// <param name="totalDayInvestment"></param>
        /// <returns></returns>
        private bool DaylimitValidation(decimal totalDayInvestment, InvestDto investementDetails)
        {
            bool isDaylimitValid = true;

            if (totalDayInvestment > 20000)
            {
                MessageBox.Show("Maximum Day Investment Limit is 20000");
                isDaylimitValid = false;
            }

            return isDaylimitValid;
        }
        /// <summary>
        /// Code to Change Grid View Columns Header Style and Make visible require Columns
        /// </summary>
        /// <param name="gridView"></param>
        private void GridColumnNameChanges(DataGridView gridView)
        {

            DataGridViewCellStyle style =
            gridView.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Navy;
            style.ForeColor = Color.White;
            style.Font = new Font(gridView.Font, FontStyle.Bold);
            gridView.Columns["investmentDate"].HeaderText = "Investment Date";
            gridView.Columns["investmentAmount"].HeaderText = "Investment Amount";
            gridView.Columns["accumulatedGoldUnits"].HeaderText = "Accumulated Gold Units";
            gridView.Columns["trnsactionType"].HeaderText = "Transaction Type";
            gridView.Columns["investedPrice"].HeaderText = "Invested Price";
            gridView.Columns["gstValue"].HeaderText = "GST Value";
            gridView.Columns["sellingCommission"].HeaderText = "Sale Commisson";
            gridView.Columns["netSaleAmount"].HeaderText = "Net Sale Amount";
            gridView.Columns["currentPrice"].Visible = false;
            gridView.Columns["totalInvestedAmount"].Visible = false;
            gridView.Columns["totalInvestedAmountInADay"].Visible = false;
            gridView.Columns["netInvestedAmount"].Visible = false;
            gridView.Columns["grossSaleAmount"].Visible = false;
            gridView.Columns["goldSaleUnits"].Visible = false;

        }
        /// <summary>
        /// Code to Calculate Profit or Loss %
        /// </summary>
        private void DisplayCalculateProfitorLoss()
        {
            try
            {
                decimal plPercent = objOperations.CalculateProfitorLoss(totalInvestmentAmount, totalAccumalatedGoldUnits, Convert.ToDecimal(txtGoldRate.Text));

                if (plPercent > 0)
                {
                    lblProfitorLoss.Text = "Profit :: " + plPercent + " %";
                    lblProfitorLoss.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblProfitorLoss.Text = "Loss :: " + plPercent + " %";
                    lblProfitorLoss.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured! Please Try Later.");
                LogFile(ex.Message);
            }

        }
        /// <summary>
        /// Code to Log Error Details
        /// </summary>
        /// <param name="strExceptionMessage"></param>
        public void LogFile(string strExceptionMessage)
        {
            StreamWriter log;
            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }
            log.WriteLine("Data Time:" + DateTime.Now);
            log.WriteLine("Exception Name:" + strExceptionMessage);
            log.Close();
        }

        private void txtInvAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtGldSaleUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
