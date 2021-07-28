
namespace SimpleBudgeting
{
    partial class AddBudgetItem
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
            this.nameBudgetItemlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgtItemNmetxtBox = new System.Windows.Forms.TextBox();
            this.amtBudgeted = new System.Windows.Forms.NumericUpDown();
            this.isAFundcheckBx = new System.Windows.Forms.CheckBox();
            this.goalLabel = new System.Windows.Forms.Label();
            this.goalTextBox = new System.Windows.Forms.NumericUpDown();
            this.AddBgtItmDoneBttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backToOverviewButton = new System.Windows.Forms.Button();
            this.budgetItemStorageTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnthlyBudgetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myfundGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.amtBudgeted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetItemStorageTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBudgetItemlbl
            // 
            this.nameBudgetItemlbl.AutoSize = true;
            this.nameBudgetItemlbl.Location = new System.Drawing.Point(12, 68);
            this.nameBudgetItemlbl.Name = "nameBudgetItemlbl";
            this.nameBudgetItemlbl.Size = new System.Drawing.Size(179, 13);
            this.nameBudgetItemlbl.TabIndex = 0;
            this.nameBudgetItemlbl.Text = "Name of Budget Item(e.g. Groceries)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Budget Amount";
            // 
            // bgtItemNmetxtBox
            // 
            this.bgtItemNmetxtBox.Location = new System.Drawing.Point(218, 65);
            this.bgtItemNmetxtBox.Name = "bgtItemNmetxtBox";
            this.bgtItemNmetxtBox.Size = new System.Drawing.Size(146, 20);
            this.bgtItemNmetxtBox.TabIndex = 2;
            this.bgtItemNmetxtBox.TextChanged += new System.EventHandler(this.bgtItemNmetxtBox_TextChanged);
            // 
            // amtBudgeted
            // 
            this.amtBudgeted.DecimalPlaces = 2;
            this.amtBudgeted.Location = new System.Drawing.Point(218, 117);
            this.amtBudgeted.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.amtBudgeted.Name = "amtBudgeted";
            this.amtBudgeted.Size = new System.Drawing.Size(146, 20);
            this.amtBudgeted.TabIndex = 3;
            this.amtBudgeted.ThousandsSeparator = true;
            this.amtBudgeted.ValueChanged += new System.EventHandler(this.amtBudgeted_ValueChanged);
            // 
            // isAFundcheckBx
            // 
            this.isAFundcheckBx.AutoSize = true;
            this.isAFundcheckBx.Location = new System.Drawing.Point(133, 170);
            this.isAFundcheckBx.Name = "isAFundcheckBx";
            this.isAFundcheckBx.Size = new System.Drawing.Size(95, 17);
            this.isAFundcheckBx.TabIndex = 4;
            this.isAFundcheckBx.Text = "Is this a Fund?";
            this.isAFundcheckBx.UseVisualStyleBackColor = true;
            this.isAFundcheckBx.CheckedChanged += new System.EventHandler(this.isAFundcheckBx_CheckedChanged);
            // 
            // goalLabel
            // 
            this.goalLabel.AutoSize = true;
            this.goalLabel.Location = new System.Drawing.Point(12, 211);
            this.goalLabel.Name = "goalLabel";
            this.goalLabel.Size = new System.Drawing.Size(119, 13);
            this.goalLabel.TabIndex = 5;
            this.goalLabel.Text = "What is your fund goal?";
            this.goalLabel.Visible = false;
            // 
            // goalTextBox
            // 
            this.goalTextBox.Location = new System.Drawing.Point(218, 211);
            this.goalTextBox.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(146, 20);
            this.goalTextBox.TabIndex = 6;
            this.goalTextBox.ThousandsSeparator = true;
            this.goalTextBox.Visible = false;
            this.goalTextBox.ValueChanged += new System.EventHandler(this.goalTextBox_ValueChanged);
            // 
            // AddBgtItmDoneBttn
            // 
            this.AddBgtItmDoneBttn.Location = new System.Drawing.Point(15, 272);
            this.AddBgtItmDoneBttn.Name = "AddBgtItmDoneBttn";
            this.AddBgtItmDoneBttn.Size = new System.Drawing.Size(105, 23);
            this.AddBgtItmDoneBttn.TabIndex = 7;
            this.AddBgtItmDoneBttn.Text = "Add Budget Item";
            this.AddBgtItmDoneBttn.UseVisualStyleBackColor = true;
            this.AddBgtItmDoneBttn.Click += new System.EventHandler(this.AddBgtItmDoneBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.budgetItem,
            this.mnthlyBudgetAmount,
            this.amountRemaining,
            this.isFund,
            this.myfundGoal});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(381, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 230);
            this.dataGridView1.TabIndex = 8;
            // 
            // backToOverviewButton
            // 
            this.backToOverviewButton.Location = new System.Drawing.Point(218, 272);
            this.backToOverviewButton.Name = "backToOverviewButton";
            this.backToOverviewButton.Size = new System.Drawing.Size(105, 23);
            this.backToOverviewButton.TabIndex = 9;
            this.backToOverviewButton.Text = "Back to Overview";
            this.backToOverviewButton.UseVisualStyleBackColor = true;
            this.backToOverviewButton.Click += new System.EventHandler(this.backToOverviewButton_Click);
            // 
            // budgetItemStorageTableBindingSource
            // 
            this.budgetItemStorageTableBindingSource.DataMember = "budgetItemStorageTable";
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.Visible = false;
            // 
            // budgetItem
            // 
            this.budgetItem.HeaderText = "Budget Item";
            this.budgetItem.Name = "budgetItem";
            // 
            // mnthlyBudgetAmount
            // 
            this.mnthlyBudgetAmount.HeaderText = "Monthly Budget Amount";
            this.mnthlyBudgetAmount.Name = "mnthlyBudgetAmount";
            // 
            // amountRemaining
            // 
            this.amountRemaining.HeaderText = "Amount Remaining";
            this.amountRemaining.Name = "amountRemaining";
            // 
            // isFund
            // 
            this.isFund.HeaderText = "Fund";
            this.isFund.Name = "isFund";
            this.isFund.Width = 50;
            // 
            // myfundGoal
            // 
            this.myfundGoal.HeaderText = "Fund Goal";
            this.myfundGoal.Name = "myfundGoal";
            // 
            // AddBudgetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 475);
            this.Controls.Add(this.backToOverviewButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddBgtItmDoneBttn);
            this.Controls.Add(this.goalTextBox);
            this.Controls.Add(this.goalLabel);
            this.Controls.Add(this.isAFundcheckBx);
            this.Controls.Add(this.amtBudgeted);
            this.Controls.Add(this.bgtItemNmetxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBudgetItemlbl);
            this.Name = "AddBudgetItem";
            this.Text = "AddBudgetItem";
            ((System.ComponentModel.ISupportInitialize)(this.amtBudgeted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetItemStorageTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameBudgetItemlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bgtItemNmetxtBox;
        private System.Windows.Forms.NumericUpDown amtBudgeted;
        private System.Windows.Forms.CheckBox isAFundcheckBx;
        private System.Windows.Forms.Label goalLabel;
        private System.Windows.Forms.NumericUpDown goalTextBox;
        private System.Windows.Forms.Button AddBgtItmDoneBttn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button backToOverviewButton;
        private System.Windows.Forms.BindingSource budgetItemStorageTableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgetItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mnthlyBudgetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountRemaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn myfundGoal;
    }
}