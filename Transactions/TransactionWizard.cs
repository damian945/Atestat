using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atestat.Controls;
using Atestat.Models;
using Atestat.Transactions;

namespace Atestat.Transactions
{
    public partial class TransactionWizard: Form
    {
        public TransactionWizard()
        {
            InitializeComponent();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var transaction = new TransactionModel
            {
                DateOfTransaction = dateTimePicker1.Value,
                TransactionType = comboBox1.SelectedItem?.ToString(),  // "Expense" or "Income"
                CategoryID = (int)comboBox2.SelectedValue,    // if bound to a list with CategoryID
                Amount = decimal.Parse(textBox1.Text),
                Note = textBox2.Text
            };

            var repo = new TransactionRepository();
            repo.InsertTransaction(transaction);

            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void TransactionWizard_Load(object sender, EventArgs e)
        {
            var repo = new TransactionRepository();
            var dt = repo.GetCategories();

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "CategoryName";
            comboBox2.ValueMember = "CategoryID";
        }
    }
}
