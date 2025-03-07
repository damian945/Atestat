using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Dashboard: Form
    {
        Controls.Dashboard_Control dashboardControl = new Controls.Dashboard_Control();
        Controls.Transactions_Control transactionsControl = new Controls.Transactions_Control();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboardControl);
            dashboardControl.Dock = DockStyle.Fill;
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dashboardControl);
            dashboardControl.Dock = DockStyle.Fill;
        }

        private void transactions_button_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(transactionsControl);
            dashboardControl.Dock = DockStyle.Fill;
        }
    }
}
