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
        Byte CreateGood = 5;
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
            txtError.Text = "";
            if (Utils.notEmptyTextBox(tbTransfer.Controls))
                BBDD.transfer(txtIBANSend.Text, txtIBANRecv.Text, 10);
            else
                txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
        }
        private void BtDepMake_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (Utils.notEmptyTextBox(tbDeposit.Controls))
                BBDD.deposit(txtDepIBAN.Text, float.Parse(txtDepMoney.Text));
            else
                txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
            
        }

        private void BtCreateMake_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (Utils.notEmptyTextBox(tbCreate.Controls))
                BBDD.createClient(txtName.Text, txtSurname.Text, txtTelephone.Text, txtEmail.Text, txtIBAN.Text);
            else
                txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
        }

        #endregion

        #region CheckText
        private void TxtIBAN_TextChanged(object sender, EventArgs e)
        {
            txtError.Text ="";
            if (!Utils.IBANCheck(txtIBAN.Text))
                txtError.Text = "ERROR IN THE IBAN";
            
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.justLetter(txtName.Text))
                txtError.Text = "ERROR IN NAME";
            
                
        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.justLetter(txtSurname.Text))
                txtError.Text = "ERROR IN SURNAME";
        }
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.emailCheck(txtEmail.Text))
                txtError.Text = "ERROR IN EMAIL";
        }

        private void TxtDepIBAN_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.IBANCheck(txtDepIBAN.Text))            
                txtError.Text = "ERROR IN DEPOSIT IBAN";
            
        }

        private void TxtDepMoney_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            float tempfloat = Utils.fNumber(txtDepMoney.Text);
            if (tempfloat == 0)
                txtError.Text = "Money format incorrect or equal to zero";
        }

        private void TxtIBANSend_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.IBANCheck(txtIBANSend.Text))
                txtError.Text = "ERROR IN THE SEND IBAN";
            
        }

        private void TxtIBANRecv_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (!Utils.IBANCheck(txtIBANRecv.Text))            
                txtError.Text = "ERROR IN THE RECEIVE IBAN";
        }

        private void TxtTransMoney_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            float tempfloat = Utils.fNumber(txtTransMoney.Text);
            if (tempfloat == 0)
                txtError.Text = "Money format incorrect or equal to zero";
        }

        #endregion


    }
}
