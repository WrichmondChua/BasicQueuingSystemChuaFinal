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
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 100);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
        Boolean openForm = false;
        CustomerView customerView = new CustomerView();
        FormCollection AllForms = Application.OpenForms;
        Form OpenedForm = new Form();

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());

            }
        }
        public delegate void PassControl(object sender);
        public PassControl passControl;

        public void OpenCashier()
        {
            if (openForm == false)
            {
                CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
                cashierWindow.Visible = true;
                openForm = true;

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextServing();
        }
        public void NextServing()
        {
            foreach (Form form in AllForms)
            {
                if (form.Name == "Customer View")
                {
                    OpenedForm = form;
                    openForm = true;
                }
            }
            if (openForm == true)
            {
                if (passControl != null)
                {
                    customerView.lblNowServing.Text = CashierClass.CashierQueue.Peek();
                    CashierClass.CashierQueue.Dequeue();
                    passControl(customerView.lblNowServing);
                }
            }
            else
            {
                customerView.ShowDialog();
                customerView.lblNowServing.Text = CashierClass.CashierQueue.Peek().ToString();
                CashierClass.CashierQueue.Dequeue();
                
            }
        }
    }
}



