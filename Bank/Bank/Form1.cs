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
        //If all the textbox are ok the value is zero
        Byte CreateGood = 0b0000_1111;
        Byte DepoGood = 0b0000_0011;
        Byte TransGood = 0b0000_0111;
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
            if (TransGood == 0) {
                if (Utils.notEmptyTextBox(tbTransfer.Controls)) {
                    if (!BBDD.transfer(txtIBANSend.Text, txtIBANRecv.Text, Utils.fNumber(txtTransMoney.Text)))
                    {
                        txtError.Text = BBDD.Errors[BBDD.Errors.Count];
                        BBDD.ClearErrors = true;
                    }
                }
                else
                        txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
            }
            else
                txtError.Text = "THERE IS AT LEAST ONE ERROR IN THE FIELDS";

        }
        private void BtDepMake_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (DepoGood == 0) {
                if (Utils.notEmptyTextBox(tbDeposit.Controls)) {
                    if (!BBDD.deposit(txtDepIBAN.Text, Utils.fNumber(txtDepMoney.Text)))
                    {
                        txtError.Text = BBDD.Errors[BBDD.Errors.Count];
                        BBDD.ClearErrors = true;
                    }
                }
                else
                        txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
            }
            else
                txtError.Text = "THERE IS AT LEAST ONE ERROR IN THE FIELDS";

            
        }

        private void BtCreateMake_Click(object sender, EventArgs e)
        {
            txtError.Text = "";
            if (CreateGood == 0) {
                if (Utils.notEmptyTextBox(tbCreate.Controls)) {
                    if (!BBDD.createClient(txtName.Text, txtSurname.Text, txtTelephone.Text, txtEmail.Text, txtIBAN.Text))
                    {
                        txtError.Text = BBDD.Errors[BBDD.Errors.Count];
                        BBDD.ClearErrors = true;
                    }
                }
                else
                    txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
            }
            else
                txtError.Text = "THERE IS AT LEAST ONE ERROR IN THE FIELDS";

        }

        #endregion

        #region CheckText
        private void TxtIBAN_TextChanged(object sender, EventArgs e)
        {
            txtError.Text ="";
            txtIBAN.BackColor = Color.White;
            if (!Utils.IBANCheck(txtIBAN.Text)){
                txtIBAN.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN THE IBAN";
                CreateGood |= 0b0000_0001;
            }
            else if (BBDD.existIBAN(txtIBAN.Text)){
                    txtIBAN.BackColor = Color.IndianRed;
                    txtError.Text = "IBAN already in the database";
                    CreateGood |= 0b0000_0001;
            }
            else
                CreateGood &= 0b1111_1110;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtName.BackColor = Color.White;
            if (!Utils.justLetter(txtName.Text))
            {
                txtName.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN NAME";
                CreateGood |= 0b0000_0010;
            }
            else
                CreateGood &= 0b1111_1101;

        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtSurname.BackColor = Color.White;
            if (!Utils.justLetter(txtSurname.Text)) {
                txtSurname.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN SURNAME";
                CreateGood |= 0b0000_0100;
            }
            else
                CreateGood &= 0b1111_1011;


        }
        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtEmail.BackColor = Color.White;
            if (!Utils.emailCheck(txtEmail.Text))
            {
                txtEmail.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN EMAIL";
                CreateGood |= 0b0000_1000;
            }
            else
                CreateGood &= 0b1111_0111;


        }

        private void TxtDepIBAN_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtDepIBAN.BackColor = Color.White;

            if (!Utils.IBANCheck(txtDepIBAN.Text))
            {
                txtDepIBAN.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN DEPOSIT IBAN";
                DepoGood |= 0b0000_0001;
            }
            else
                DepoGood &= 0b1111_1110;


        }

        private void TxtDepMoney_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtDepMoney.BackColor = Color.White;

            float tempfloat = Utils.fNumber(txtDepMoney.Text);
            if (tempfloat == 0)
            {
                txtDepMoney.BackColor = Color.IndianRed;
                txtError.Text = "Money format incorrect or equal to zero";
                DepoGood |= 0b0000_0010;
            }
            else
                DepoGood &= 0b1111_1101;

        }

        private void TxtIBANSend_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtIBANSend.BackColor = Color.White;

            if (!Utils.IBANCheck(txtIBANSend.Text))
            {
                txtIBANSend.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN THE SEND IBAN";
            }
            else
                TransGood &= 0b1111_1110;
        }

        private void TxtIBANRecv_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtIBANRecv.BackColor = Color.White;

            if (!Utils.IBANCheck(txtIBANRecv.Text))
            {
                txtIBANRecv.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN THE RECEIVE IBAN";
                TransGood |= 0b0000_0010;
            }
            else
                TransGood &= 0b1111_1101;

        }

        private void TxtTransMoney_TextChanged(object sender, EventArgs e)
        {
            txtError.Text = "";
            txtTransMoney.BackColor = Color.White;

            float tempfloat = Utils.fNumber(txtTransMoney.Text);
            if (tempfloat == 0)
            {
                txtTransMoney.BackColor = Color.IndianRed;
                txtError.Text = "Money format incorrect or equal to zero";
                TransGood |= 0b0000_0100;
            }
            else
                TransGood &= 0b1111_1011;

        }

        #endregion


    }
}
