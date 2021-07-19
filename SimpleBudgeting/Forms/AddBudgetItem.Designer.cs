
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
            this.nameBudgetItemlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bgtItemNmetxtBox = new System.Windows.Forms.TextBox();
            this.amtBudgeted = new System.Windows.Forms.NumericUpDown();
            this.isAFundcheckBx = new System.Windows.Forms.CheckBox();
            this.goalLabel = new System.Windows.Forms.Label();
            this.goalTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amtBudgeted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalTextBox)).BeginInit();
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
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(146, 20);
            this.goalTextBox.TabIndex = 6;
            this.goalTextBox.Visible = false;
            this.goalTextBox.ValueChanged += new System.EventHandler(this.goalTextBox_ValueChanged);
            // 
            // AddBudgetItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 388);
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
    }
}