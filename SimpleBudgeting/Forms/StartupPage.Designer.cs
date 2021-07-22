
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
            this.overviewTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleBudgetDBDataSet = new SimpleBudgeting.simpleBudgetDBDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.overviewTableTableAdapter = new SimpleBudgeting.simpleBudgetDBDataSetTableAdapters.overviewTableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleBudgetDBDataSet1 = new SimpleBudgeting.simpleBudgetDBDataSet1();
            this.overviewTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.overviewTableTableAdapter1 = new SimpleBudgeting.simpleBudgetDBDataSet1TableAdapters.overviewTableTableAdapter();
            this.budgetItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountBudgetedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.totalPaycheckTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBudgetDBDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBudgetDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableBindingSource1)).BeginInit();
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
            // overviewTableBindingSource
            // 
            this.overviewTableBindingSource.DataMember = "overviewTable";
            this.overviewTableBindingSource.DataSource = this.simpleBudgetDBDataSet;
            // 
            // simpleBudgetDBDataSet
            // 
            this.simpleBudgetDBDataSet.DataSetName = "simpleBudgetDBDataSet";
            this.simpleBudgetDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(692, 25);
            this.fillByToolStrip.TabIndex = 13;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            // 
            // overviewTableTableAdapter
            // 
            this.overviewTableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.budgetItemDataGridViewTextBoxColumn,
            this.amountBudgetedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.overviewTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(56, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 212);
            this.dataGridView1.TabIndex = 14;
            // 
            // simpleBudgetDBDataSet1
            // 
            this.simpleBudgetDBDataSet1.DataSetName = "simpleBudgetDBDataSet1";
            this.simpleBudgetDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // overviewTableBindingSource1
            // 
            this.overviewTableBindingSource1.DataMember = "overviewTable";
            this.overviewTableBindingSource1.DataSource = this.simpleBudgetDBDataSet1;
            // 
            // overviewTableTableAdapter1
            // 
            this.overviewTableTableAdapter1.ClearBeforeFill = true;
            // 
            // budgetItemDataGridViewTextBoxColumn
            // 
            this.budgetItemDataGridViewTextBoxColumn.DataPropertyName = "Budget Item";
            this.budgetItemDataGridViewTextBoxColumn.HeaderText = "Budget Item";
            this.budgetItemDataGridViewTextBoxColumn.Name = "budgetItemDataGridViewTextBoxColumn";
            // 
            // amountBudgetedDataGridViewTextBoxColumn
            // 
            this.amountBudgetedDataGridViewTextBoxColumn.DataPropertyName = "Amount Budgeted";
            this.amountBudgetedDataGridViewTextBoxColumn.HeaderText = "Amount Budgeted";
            this.amountBudgetedDataGridViewTextBoxColumn.Name = "amountBudgetedDataGridViewTextBoxColumn";
            // 
            // StartupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 521);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
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
            this.Load += new System.EventHandler(this.StartupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalPaycheckTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBudgetDBDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleBudgetDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overviewTableBindingSource1)).EndInit();
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
        private simpleBudgetDBDataSet simpleBudgetDBDataSet;
        private System.Windows.Forms.BindingSource overviewTableBindingSource;
        private simpleBudgetDBDataSetTableAdapters.overviewTableTableAdapter overviewTableTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private simpleBudgetDBDataSet1 simpleBudgetDBDataSet1;
        private System.Windows.Forms.BindingSource overviewTableBindingSource1;
        private simpleBudgetDBDataSet1TableAdapters.overviewTableTableAdapter overviewTableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountBudgetedDataGridViewTextBoxColumn;
    }
}

