using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System;

namespace BasicQueuingSystemChuaFinal
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier = new CashierClass();
         
        public QueuingForm()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.OpenCashier();
        }
    }
}
