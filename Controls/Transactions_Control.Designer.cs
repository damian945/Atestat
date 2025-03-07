namespace Atestat.Controls
{
    partial class Transactions_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transactions";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(103, 73);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(121, 23);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "Add Transaction";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridTransactions
            // 
            this.dataGridTransactions.AllowUserToAddRows = false;
            this.dataGridTransactions.AllowUserToDeleteRows = false;
            this.dataGridTransactions.AllowUserToResizeColumns = false;
            this.dataGridTransactions.AllowUserToResizeRows = false;
            this.dataGridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransactions.Location = new System.Drawing.Point(415, 0);
            this.dataGridTransactions.MultiSelect = false;
            this.dataGridTransactions.Name = "dataGridTransactions";
            this.dataGridTransactions.ReadOnly = true;
            this.dataGridTransactions.Size = new System.Drawing.Size(602, 430);
            this.dataGridTransactions.TabIndex = 3;
            // 
            // Transactions_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridTransactions);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label1);
            this.Name = "Transactions_Control";
            this.Size = new System.Drawing.Size(1017, 430);
            this.Load += new System.EventHandler(this.Transactions_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        public System.Windows.Forms.DataGridView dataGridTransactions;
    }
}
