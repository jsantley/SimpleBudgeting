
namespace SimpleBudgeting
{
    partial class StartupPage
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
            this.components = new System.ComponentModel.Container();
            this.totalPaycheckLabel = new System.Windows.Forms.Label();
            this.leftToBudgetTextBox = new System.Windows.Forms.TextBox();
            this.unbudgetedLabel = new System.Windows.Forms.Label();
            this.totalPaycheckTextBox = new System.Windows.Forms.NumericUpDown();
            this.addBudgetItemBttn = new System.Windows.Forms.Button();
            this.transactionButton = new System.Windows.Forms.Button();
            this.editTransaction = new System.Windows.Forms.Button();
            this.deletebgtItemBttn = new System.Windows.Forms.Button();
            this.refreshData = new System.Windows.Forms.Button();
            this.overviewTableGridView = new System.Windows.Forms.DataGridView();
            this.itemTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amtBudgeted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalPaycheckTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalPaycheckLabel
            // 
            this.totalPaycheckLabel.AutoSize = true;
            this.totalPaycheckLabel.ForeColor = System.Drawing.Color.Black;
            this.totalPaycheckLabel.Location = new System.Drawing.Point(31, 57);
            this.totalPaycheckLabel.Name = "totalPaycheckLabel";
            this.totalPaycheckLabel.Size = new System.Drawing.Size(82, 13);
            this.totalPaycheckLabel.TabIndex = 1;
            this.totalPaycheckLabel.Text = "Total Paycheck";
            // 
            // leftToBudgetTextBox
            // 
            this.leftToBudgetTextBox.Location = new System.Drawing.Point(352, 56);
            this.leftToBudgetTextBox.Name = "leftToBudgetTextBox";
            this.leftToBudgetTextBox.ReadOnly = true;
            this.leftToBudgetTextBox.Size = new System.Drawing.Size(100, 20);
            this.leftToBudgetTextBox.TabIndex = 3;
            // 
            // unbudgetedLabel
            // 
            this.unbudgetedLabel.AutoSize = true;
            this.unbudgetedLabel.ForeColor = System.Drawing.Color.Black;
            this.unbudgetedLabel.Location = new System.Drawing.Point(262, 60);
            this.unbudgetedLabel.Name = "unbudgetedLabel";
            this.unbudgetedLabel.Size = new System.Drawing.Size(66, 13);
            this.unbudgetedLabel.TabIndex = 4;
            this.unbudgetedLabel.Text = "Unbudgeted";
            // 
            // totalPaycheckTextBox
            // 
            this.totalPaycheckTextBox.DecimalPlaces = 2;
            this.totalPaycheckTextBox.Location = new System.Drawing.Point(119, 54);
            this.totalPaycheckTextBox.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.totalPaycheckTextBox.Name = "totalPaycheckTextBox";
            this.totalPaycheckTextBox.Size = new System.Drawing.Size(120, 20);
            this.totalPaycheckTextBox.TabIndex = 5;
            this.totalPaycheckTextBox.ThousandsSeparator = true;
            this.totalPaycheckTextBox.ValueChanged += new System.EventHandler(this.TotalPaycheckTextBox_ValueChanged);
            // 
            // addBudgetItemBttn
            // 
            this.addBudgetItemBttn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addBudgetItemBttn.ForeColor = System.Drawing.Color.Black;
            this.addBudgetItemBttn.Location = new System.Drawing.Point(500, 42);
            this.addBudgetItemBttn.Name = "addBudgetItemBttn";
            this.addBudgetItemBttn.Size = new System.Drawing.Size(118, 23);
            this.addBudgetItemBttn.TabIndex = 6;
            this.addBudgetItemBttn.Text = "Add a Budget Item";
            this.addBudgetItemBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addBudgetItemBttn.UseVisualStyleBackColor = false;
            this.addBudgetItemBttn.Click += new System.EventHandler(this.AddBudgetItemBttn_Click);
            // 
            // transactionButton
            // 
            this.transactionButton.ForeColor = System.Drawing.Color.Black;
            this.transactionButton.Location = new System.Drawing.Point(489, 400);
            this.transactionButton.Name = "transactionButton";
            this.transactionButton.Size = new System.Drawing.Size(129, 23);
            this.transactionButton.TabIndex = 8;
            this.transactionButton.Text = "Add Transaction";
            this.transactionButton.UseVisualStyleBackColor = true;
            // 
            // editTransaction
            // 
            this.editTransaction.ForeColor = System.Drawing.Color.Black;
            this.editTransaction.Location = new System.Drawing.Point(489, 439);
            this.editTransaction.Name = "editTransaction";
            this.editTransaction.Size = new System.Drawing.Size(129, 23);
            this.editTransaction.TabIndex = 9;
            this.editTransaction.Text = "View Transactions";
            this.editTransaction.UseVisualStyleBackColor = true;
            // 
            // deletebgtItemBttn
            // 
            this.deletebgtItemBttn.ForeColor = System.Drawing.Color.Black;
            this.deletebgtItemBttn.Location = new System.Drawing.Point(500, 80);
            this.deletebgtItemBttn.Name = "deletebgtItemBttn";
            this.deletebgtItemBttn.Size = new System.Drawing.Size(118, 23);
            this.deletebgtItemBttn.TabIndex = 10;
            this.deletebgtItemBttn.Text = "Delete Budget Item";
            this.deletebgtItemBttn.UseVisualStyleBackColor = true;
            // 
            // refreshData
            // 
            this.refreshData.ForeColor = System.Drawing.Color.Black;
            this.refreshData.Location = new System.Drawing.Point(44, 417);
            this.refreshData.Name = "refreshData";
            this.refreshData.Size = new System.Drawing.Size(96, 45);
            this.refreshData.TabIndex = 11;
            this.refreshData.Text = "Refresh Data";
            this.refreshData.UseVisualStyleBackColor = true;
            this.refreshData.Click += new System.EventHandler(this.refreshData_Click);
            // 
            // overviewTableGridView
            // 
            this.overviewTableGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.overviewTableGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetItem,
            this.amtBudgeted});
            this.overviewTableGridView.Location = new System.Drawing.Point(68, 181);
            this.overviewTableGridView.Name = "overviewTableGridView";
            this.overviewTableGridView.Size = new System.Drawing.Size(432, 150);
            this.overviewTableGridView.TabIndex = 12;
            // 
            // itemTableBindingSource
            // 
            this.itemTableBindingSource.DataMember = "itemTable";
            // 
            // budgetItem
            // 
            this.budgetItem.HeaderText = "Budget Item";
            this.budgetItem.Name = "budgetItem";
            this.budgetItem.ReadOnly = true;
            // 
            // amtBudgeted
            // 
            this.amtBudgeted.HeaderText = "Amount Budgeted";
            this.amtBudgeted.Name = "amtBudgeted";
            this.amtBudgeted.ReadOnly = true;
            // 
            // StartupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 521);
            this.Controls.Add(this.overviewTableGridView);
            this.Controls.Add(this.refreshData);
            this.Controls.Add(this.deletebgtItemBttn);
            this.Controls.Add(this.editTransaction);
            this.Controls.Add(this.transactionButton);
            this.Controls.Add(this.addBudgetItemBttn);
            this.Controls.Add(this.totalPaycheckTextBox);
            this.Controls.Add(this.unbudgetedLabel);
            this.Controls.Add(this.leftToBudgetTextBox);
            this.Controls.Add(this.totalPaycheckLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "StartupPage";
            this.Text = "Startup Page";
            ((System.ComponentModel.ISupportInitialize)(this.totalPaycheckTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalPaycheckLabel;
        private System.Windows.Forms.TextBox leftToBudgetTextBox;
        private System.Windows.Forms.Label unbudgetedLabel;
        private System.Windows.Forms.NumericUpDown totalPaycheckTextBox;
        private System.Windows.Forms.Button addBudgetItemBttn;
        private System.Windows.Forms.Button transactionButton;
        private System.Windows.Forms.Button editTransaction;
        private System.Windows.Forms.Button deletebgtItemBttn;
        private System.Windows.Forms.Button refreshData;
        public System.Windows.Forms.DataGridView overviewTableGridView;
        private System.Windows.Forms.BindingSource itemTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn amtBudgeted;
    }
}

