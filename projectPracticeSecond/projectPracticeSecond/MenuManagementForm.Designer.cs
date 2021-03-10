
namespace projectPracticeSecond
{
    partial class MenuManagementForm
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
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAccountNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepositDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.advancedDataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.CumulativeAmount,
            this.Manager,
            this.ManagerPhone,
            this.ExpiredDate,
            this.ProductName,
            this.BankAccountNum,
            this.DepositDate,
            this.PhoneNum,
            this.Amount});
            this.advancedDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.advancedDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 25;
            this.advancedDataGridView1.Size = new System.Drawing.Size(1255, 495);
            this.advancedDataGridView1.TabIndex = 0;
            // 
            // customerName
            // 
            this.customerName.HeaderText = "고객명";
            this.customerName.MinimumWidth = 22;
            this.customerName.Name = "customerName";
            this.customerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CumulativeAmount
            // 
            this.CumulativeAmount.HeaderText = "누적 체결 금액";
            this.CumulativeAmount.MinimumWidth = 22;
            this.CumulativeAmount.Name = "CumulativeAmount";
            this.CumulativeAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Manager
            // 
            this.Manager.HeaderText = "담당자";
            this.Manager.MinimumWidth = 22;
            this.Manager.Name = "Manager";
            this.Manager.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ManagerPhone
            // 
            this.ManagerPhone.HeaderText = "담당자 전화번호";
            this.ManagerPhone.MinimumWidth = 22;
            this.ManagerPhone.Name = "ManagerPhone";
            this.ManagerPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ExpiredDate
            // 
            this.ExpiredDate.HeaderText = "만기 날짜";
            this.ExpiredDate.MinimumWidth = 22;
            this.ExpiredDate.Name = "ExpiredDate";
            this.ExpiredDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "상품명";
            this.ProductName.MinimumWidth = 22;
            this.ProductName.Name = "ProductName";
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BankAccountNum
            // 
            this.BankAccountNum.HeaderText = "은행 계좌 번호";
            this.BankAccountNum.MinimumWidth = 22;
            this.BankAccountNum.Name = "BankAccountNum";
            this.BankAccountNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DepositDate
            // 
            this.DepositDate.HeaderText = "입금 날짜";
            this.DepositDate.MinimumWidth = 22;
            this.DepositDate.Name = "DepositDate";
            this.DepositDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "전화번호";
            this.PhoneNum.MinimumWidth = 22;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "체결금액";
            this.Amount.MinimumWidth = 22;
            this.Amount.Name = "Amount";
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.advancedDataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1342, 495);
            this.splitContainer1.SplitterDistance = 1255;
            this.splitContainer1.TabIndex = 1;
            // 
            // MenuManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1342, 495);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuManagementForm";
            this.Text = "MenuManagementForm";
            this.Load += new System.EventHandler(this.MenuManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManagerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAccountNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepositDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}