namespace DigitalGoldMember
{
    partial class frmDigitalGold
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTdyGldRate = new System.Windows.Forms.Label();
            this.txtGoldRate = new System.Windows.Forms.TextBox();
            this.txtInvAmount = new System.Windows.Forms.TextBox();
            this.lblInvestmentAmount = new System.Windows.Forms.Label();
            this.btnInvest = new System.Windows.Forms.Button();
            this.dtInvHistory = new System.Windows.Forms.DataGridView();
            this.btnSale = new System.Windows.Forms.Button();
            this.lblSaleUnits = new System.Windows.Forms.Label();
            this.txtGldSaleUnits = new System.Windows.Forms.TextBox();
            this.lblTotalInvestment = new System.Windows.Forms.Label();
            this.lblTotalGoldAccu = new System.Windows.Forms.Label();
            this.lblProfitorLoss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(881, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(98, 35);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTdyGldRate
            // 
            this.lblTdyGldRate.AutoSize = true;
            this.lblTdyGldRate.Location = new System.Drawing.Point(573, 35);
            this.lblTdyGldRate.Name = "lblTdyGldRate";
            this.lblTdyGldRate.Size = new System.Drawing.Size(124, 17);
            this.lblTdyGldRate.TabIndex = 1;
            this.lblTdyGldRate.Text = "Today Gold Rate::";
            // 
            // txtGoldRate
            // 
            this.txtGoldRate.Enabled = false;
            this.txtGoldRate.Location = new System.Drawing.Point(703, 32);
            this.txtGoldRate.Name = "txtGoldRate";
            this.txtGoldRate.Size = new System.Drawing.Size(161, 22);
            this.txtGoldRate.TabIndex = 2;
            // 
            // txtInvAmount
            // 
            this.txtInvAmount.Location = new System.Drawing.Point(228, 92);
            this.txtInvAmount.MaxLength = 10;
            this.txtInvAmount.Name = "txtInvAmount";
            this.txtInvAmount.Size = new System.Drawing.Size(220, 22);
            this.txtInvAmount.TabIndex = 3;
            this.txtInvAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvAmount_KeyPress);
            // 
            // lblInvestmentAmount
            // 
            this.lblInvestmentAmount.AutoSize = true;
            this.lblInvestmentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestmentAmount.Location = new System.Drawing.Point(31, 97);
            this.lblInvestmentAmount.Name = "lblInvestmentAmount";
            this.lblInvestmentAmount.Size = new System.Drawing.Size(178, 17);
            this.lblInvestmentAmount.TabIndex = 4;
            this.lblInvestmentAmount.Text = "Enter Investment Amount ::";
            // 
            // btnInvest
            // 
            this.btnInvest.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInvest.Location = new System.Drawing.Point(288, 145);
            this.btnInvest.Name = "btnInvest";
            this.btnInvest.Size = new System.Drawing.Size(75, 23);
            this.btnInvest.TabIndex = 5;
            this.btnInvest.Text = "Invest";
            this.btnInvest.UseVisualStyleBackColor = true;
            this.btnInvest.Click += new System.EventHandler(this.btnInvest_Click);
            // 
            // dtInvHistory
            // 
            this.dtInvHistory.AllowUserToAddRows = false;
            this.dtInvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtInvHistory.Location = new System.Drawing.Point(12, 299);
            this.dtInvHistory.Name = "dtInvHistory";
            this.dtInvHistory.RowTemplate.Height = 24;
            this.dtInvHistory.Size = new System.Drawing.Size(1121, 321);
            this.dtInvHistory.TabIndex = 6;
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(777, 145);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(75, 23);
            this.btnSale.TabIndex = 7;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // lblSaleUnits
            // 
            this.lblSaleUnits.AutoSize = true;
            this.lblSaleUnits.Location = new System.Drawing.Point(479, 97);
            this.lblSaleUnits.Name = "lblSaleUnits";
            this.lblSaleUnits.Size = new System.Drawing.Size(156, 17);
            this.lblSaleUnits.TabIndex = 9;
            this.lblSaleUnits.Text = "Enter Sale Unit(grms) ::";
            // 
            // txtGldSaleUnits
            // 
            this.txtGldSaleUnits.Location = new System.Drawing.Point(673, 97);
            this.txtGldSaleUnits.MaxLength = 10;
            this.txtGldSaleUnits.Name = "txtGldSaleUnits";
            this.txtGldSaleUnits.Size = new System.Drawing.Size(220, 22);
            this.txtGldSaleUnits.TabIndex = 8;
            this.txtGldSaleUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGldSaleUnits_KeyPress);
            // 
            // lblTotalInvestment
            // 
            this.lblTotalInvestment.AutoSize = true;
            this.lblTotalInvestment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvestment.Location = new System.Drawing.Point(31, 9);
            this.lblTotalInvestment.Name = "lblTotalInvestment";
            this.lblTotalInvestment.Size = new System.Drawing.Size(0, 17);
            this.lblTotalInvestment.TabIndex = 10;
            // 
            // lblTotalGoldAccu
            // 
            this.lblTotalGoldAccu.AutoSize = true;
            this.lblTotalGoldAccu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGoldAccu.Location = new System.Drawing.Point(31, 49);
            this.lblTotalGoldAccu.Name = "lblTotalGoldAccu";
            this.lblTotalGoldAccu.Size = new System.Drawing.Size(0, 17);
            this.lblTotalGoldAccu.TabIndex = 11;
            // 
            // lblProfitorLoss
            // 
            this.lblProfitorLoss.AutoSize = true;
            this.lblProfitorLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfitorLoss.Location = new System.Drawing.Point(673, 196);
            this.lblProfitorLoss.Name = "lblProfitorLoss";
            this.lblProfitorLoss.Size = new System.Drawing.Size(0, 17);
            this.lblProfitorLoss.TabIndex = 12;
            // 
            // frmDigitalGold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 732);
            this.Controls.Add(this.lblProfitorLoss);
            this.Controls.Add(this.lblTotalGoldAccu);
            this.Controls.Add(this.lblTotalInvestment);
            this.Controls.Add(this.lblSaleUnits);
            this.Controls.Add(this.txtGldSaleUnits);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.dtInvHistory);
            this.Controls.Add(this.btnInvest);
            this.Controls.Add(this.lblInvestmentAmount);
            this.Controls.Add(this.txtInvAmount);
            this.Controls.Add(this.txtGoldRate);
            this.Controls.Add(this.lblTdyGldRate);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmDigitalGold";
            this.Text = "Digital Gold Investment";
            this.Load += new System.EventHandler(this.frmDigitalGold_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtInvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTdyGldRate;
        private System.Windows.Forms.TextBox txtGoldRate;
        private System.Windows.Forms.TextBox txtInvAmount;
        private System.Windows.Forms.Label lblInvestmentAmount;
        private System.Windows.Forms.Button btnInvest;
        private System.Windows.Forms.DataGridView dtInvHistory;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Label lblSaleUnits;
        private System.Windows.Forms.TextBox txtGldSaleUnits;
        private System.Windows.Forms.Label lblTotalInvestment;
        private System.Windows.Forms.Label lblTotalGoldAccu;
        private System.Windows.Forms.Label lblProfitorLoss;
    }
}

