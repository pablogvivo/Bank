using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Main : Form
    {
        BDCom BBDD;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BBDD = new BDCom("localhost", "client_conn", "client", "tyu567");
            btCreateClient.BackColor = Color.LawnGreen;
        }
        #region ButtonTab
        private void BtDeposit_Click(object sender, EventArgs e)
        {
            //CHANGING BETWEEN TABS
            btTransfer.BackColor = btCreateClient.BackColor = Color.LightGray;
            btDeposit.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbDeposit;

        }
        private void BtCreateClient_Click(object sender, EventArgs e)
        {
            //CHANGING BETWEEN TABS
            btTransfer.BackColor = btDeposit.BackColor =  Color.LightGray;
            btCreateClient.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbCreate;
        }

        private void BtTransfer_Click(object sender, EventArgs e)
        {
            //CHANGING BETWEEN TABS
            btDeposit.BackColor = btCreateClient.BackColor = Color.LightGray;
            btTransfer.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbTransfer;
        }
        #endregion

        #region Button BBDD
        private void BtTransferMake_Click(object sender, EventArgs e)
        {
            BBDD.transfer(txtIBANSend.Text, txtIBANRecv.Text, float.Parse(txtTransMoney.Text)) ;
        }
        private void BtDepMake_Click(object sender, EventArgs e)
        {
            BBDD.deposit(txtDepIBAN.Text, float.Parse(txtDepMoney.Text));
        }

        private void BtCreateMake_Click(object sender, EventArgs e)
        {
            BBDD.createClient(txtName.Text, txtSurname.Text, txtTelephone.Text, txtEmail.Text, txtIBAN.Text);
        }
        #endregion


    }
}
