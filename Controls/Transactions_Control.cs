using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atestat.Transactions;

namespace Atestat.Controls
{
    public partial class Transactions_Control: UserControl
    {
        public Transactions_Control()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            using (var transactionWizard = new TransactionWizard())
            {
                // Show dialog and check if an operation was completed
                if (transactionWizard.ShowDialog() == DialogResult.OK)
                {
                    // Re-load the transactions after the wizard closes successfully
                    var repo = new TransactionRepository();
                    dataGridTransactions.DataSource = repo.LoadTransactions();
                }
            }
        }

        private void Transactions_Control_Load(object sender, EventArgs e)
        {
            var repo = new TransactionRepository();
            dataGridTransactions.DataSource = repo.LoadTransactions();
        }
    }
}
