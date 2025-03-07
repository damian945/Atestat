namespace Atestat
{
    partial class Dashboard
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.home_button = new System.Windows.Forms.Button();
            this.transactions_button = new System.Windows.Forms.Button();
            this.budget_button = new System.Windows.Forms.Button();
            this.stats_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 196);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1017, 430);
            this.panelMain.TabIndex = 0;
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(0, 156);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(159, 34);
            this.home_button.TabIndex = 1;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // transactions_button
            // 
            this.transactions_button.Location = new System.Drawing.Point(169, 156);
            this.transactions_button.Name = "transactions_button";
            this.transactions_button.Size = new System.Drawing.Size(159, 34);
            this.transactions_button.TabIndex = 1;
            this.transactions_button.Text = "Transactions";
            this.transactions_button.UseVisualStyleBackColor = true;
            this.transactions_button.Click += new System.EventHandler(this.transactions_button_Click);
            // 
            // budget_button
            // 
            this.budget_button.Location = new System.Drawing.Point(338, 156);
            this.budget_button.Name = "budget_button";
            this.budget_button.Size = new System.Drawing.Size(159, 34);
            this.budget_button.TabIndex = 1;
            this.budget_button.Text = "Budget";
            this.budget_button.UseVisualStyleBackColor = true;
            // 
            // stats_button
            // 
            this.stats_button.Location = new System.Drawing.Point(507, 156);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(159, 34);
            this.stats_button.TabIndex = 1;
            this.stats_button.Text = "Stats";
            this.stats_button.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(683, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 178);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 138);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.budget_button);
            this.Controls.Add(this.transactions_button);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.panelMain);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button transactions_button;
        private System.Windows.Forms.Button budget_button;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}