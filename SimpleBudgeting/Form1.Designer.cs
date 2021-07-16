
namespace SimpleBudgeting
{
    partial class Form1
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
            this.totalPaycheckLabel = new System.Windows.Forms.Label();
            this.totalPaycheckTextBox = new System.Windows.Forms.TextBox();
            this.leftToBudgetTextBox = new System.Windows.Forms.TextBox();
            this.unbudgetedLabel = new System.Windows.Forms.Label();
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
            // totalPaycheckTextBox
            // 
            this.totalPaycheckTextBox.AcceptsReturn = true;
            this.totalPaycheckTextBox.Location = new System.Drawing.Point(131, 57);
            this.totalPaycheckTextBox.Name = "totalPaycheckTextBox";
            this.totalPaycheckTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPaycheckTextBox.TabIndex = 2;
            this.totalPaycheckTextBox.TextChanged += new System.EventHandler(this.TotalPaycheckTextBox_TextChanged);
            this.totalPaycheckTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TotalPaycheckTextBox_KeyDown);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unbudgetedLabel);
            this.Controls.Add(this.leftToBudgetTextBox);
            this.Controls.Add(this.totalPaycheckTextBox);
            this.Controls.Add(this.totalPaycheckLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label totalPaycheckLabel;
        private System.Windows.Forms.TextBox totalPaycheckTextBox;
        private System.Windows.Forms.TextBox leftToBudgetTextBox;
        private System.Windows.Forms.Label unbudgetedLabel;
    }
}

