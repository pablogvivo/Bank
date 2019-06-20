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
        List<Client> tempClient = new List<Client>();
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
            btTransaction.BackColor = btTransfer.BackColor = btCreateClient.BackColor = Color.LightGray;
            btDeposit.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbDeposit;

        }
        private void BtCreateClient_Click(object sender, EventArgs e)
        {
            //CHANGING BETWEEN TABS
            btTransaction.BackColor = btTransfer.BackColor = btDeposit.BackColor =  Color.LightGray;
            btCreateClient.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbCreate;
        }

        private void BtTransfer_Click(object sender, EventArgs e)
        {
            //CHANGING BETWEEN TABS
            btTransaction.BackColor = btDeposit.BackColor = btCreateClient.BackColor = Color.LightGray;
            btTransfer.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbTransfer;
        }
        private void BtTransaction_Click(object sender, EventArgs e)
        {
            btTransfer.BackColor = btDeposit.BackColor = btCreateClient.BackColor = Color.LightGray;
            btTransaction.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbTrans;
        }
        #endregion

        #region Button BBDD
        private void BtTransferMake_Click(object sender, EventArgs e)
        {
            float tempMoney = 0;
            float.TryParse(txtTransMoney.Text.Replace(".",","), out tempMoney);
            txtError.Text = "";
            if (TransGood == 0) {
                if (Utils.notEmptyTextBox(tbTransfer.Controls)) {
                    if (txtIBANRecv.Text != txtIBANSend.Text) {
                        if (tempMoney > 0)
                        {
                            if (!BBDD.transfer(txtIBANSend.Text, txtIBANRecv.Text, Utils.fNumber(txtTransMoney.Text)))
                            {
                                if (BBDD.Errors.Count > 0)
                                {
                                    txtError.Text = BBDD.Errors[BBDD.Errors.Count];
                                    BBDD.ClearErrors = true;
                                }
                            }
                            else
                            {
                                Utils.resetTextbox(tbTransfer.Controls);
                                txtError.Text = "DONE";
                            }
                        }
                        else
                            txtError.Text = "MONEY MUST BE GREATER THAN 0";
                    }
                    else
                        txtError.Text = "THE  IBANs CANT BE THE SAME";
                }
                else
                        txtError.Text = "PLEASE INTRODUCE THE DATA IN ALL THE FIELDS";
            }
            else
                txtError.Text = "THERE IS AT LEAST ONE ERROR IN THE FIELDS";

        }
        private void BtDepMake_Click(object sender, EventArgs e)
        {
            float tempMoney=0;
            float.TryParse(txtDepMoney.Text.Replace(".", ","), out tempMoney);
            txtError.Text = "";
            if (DepoGood == 0) {
                if (Utils.notEmptyTextBox(tbDeposit.Controls)) {
                    if (tempMoney > 0){
                        if (!BBDD.deposit(txtDepIBAN.Text, Utils.fNumber(txtDepMoney.Text)))
                        {
                            txtError.Text = BBDD.Errors[BBDD.Errors.Count];
                            BBDD.ClearErrors = true;
                        }
                        else
                        {
                            Utils.resetTextbox(tbDeposit.Controls);
                            txtError.Text = "DONE";
                        }
                    }
                    else
                        txtError.Text = "MONEY MUST BE GREATER THAN 0";
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
                    else
                    {
                        Utils.resetTextbox(tbCreate.Controls);
                        txtError.Text = "DONE";
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

            if (!Utils.IBANCheck(txtDepIBAN.Text)){
                txtDepIBAN.BackColor = Color.IndianRed;
                txtError.Text = "ERROR IN DEPOSIT IBAN";
                DepoGood |= 0b0000_0001;
            }
            else{
                if (!BBDD.existIBAN(txtDepIBAN.Text)){
                    txtDepIBAN.BackColor = Color.IndianRed;
                    txtError.Text = " IBAN NOT IN THE DATABASE";
                    DepoGood |= 0b0000_0001;
                }
                else
                    DepoGood &= 0b1111_1110;
            }
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
            else {
                if (!BBDD.existIBAN(txtIBANSend.Text))
                {
                    txtIBANSend.BackColor = Color.IndianRed;
                    txtError.Text = "SEND IBAN NOT IN THE DATABASE";
                    TransGood |= 0b0000_0001;
                }
                else
                    TransGood &= 0b1111_1110;
            }
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
            else {
                if (!BBDD.existIBAN(txtIBANRecv.Text))
                {
                    txtIBANRecv.BackColor = Color.IndianRed;
                    txtError.Text = "RECEIVE IBAN NOT IN THE DATABASE";
                    TransGood |= 0b0000_0001;
                }
                else
                    TransGood &= 0b1111_1101;
            }
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

        #region ComboBox
        private void CBDepIBAN_Click(object sender, EventArgs e)
        {
            CBDepIBAN.DroppedDown = true;
        }
        private void CBDepIBAN_DropDown(object sender, EventArgs e)
        {
            CBDepIBAN.Items.Clear();
            tempClient.Clear();
            tempClient = BBDD.listClient();
            List<String> tempString = new List<string>();
            foreach (Client d in tempClient) {
                tempString.Add(d.Name + " " +d.Surname);
            }
            CBDepIBAN.Items.AddRange(tempString.ToArray());
        }

        private void CBSendIBAN_Click(object sender, EventArgs e)
        {
            CBSendIBAN.DroppedDown = true;
        }

        private void CBRecvIBAN_Click(object sender, EventArgs e)
        {
            CBRecvIBAN.DroppedDown = true;
        }

        private void CBSendIBAN_DropDown(object sender, EventArgs e)
        {
            CBSendIBAN.Items.Clear();
            tempClient.Clear();
            tempClient = BBDD.listClient();
            List<String> tempString = new List<string>();
            foreach (Client d in tempClient)
            {
                tempString.Add(d.Name + " " + d.Surname);
            }
            CBSendIBAN.Items.AddRange(tempString.ToArray());
        }

        private void CBRecvIBAN_DropDown(object sender, EventArgs e)
        {
            CBRecvIBAN.Items.Clear();
            tempClient.Clear();
            tempClient = BBDD.listClient();
            List<String> tempString = new List<string>();
            foreach (Client d in tempClient)
            {
                tempString.Add(d.Name + " " + d.Surname);
            }
            CBRecvIBAN.Items.AddRange(tempString.ToArray());
        }
        private void CBDepIBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDepIBAN.Text = BBDD.IBANfromID(tempClient[CBDepIBAN.SelectedIndex].ID);
        }
        private void CBSendIBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIBANSend.Text = BBDD.IBANfromID(tempClient[CBSendIBAN.SelectedIndex].ID);
        }
        private void CBRecvIBAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIBANRecv.Text = BBDD.IBANfromID(tempClient[CBRecvIBAN.SelectedIndex].ID);
        }

        #endregion

        private void CBTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DTTransaction.DataSource= Utils.ConvertListToDataTable(BBDD.listTransaction(tempClient[CBTransaction.SelectedIndex].ID));
        }
        private void CBTransaction_Click(object sender, EventArgs e)
        {
            CBTransaction.DroppedDown = true;
        }
        private void CBTransaction_DropDown(object sender, EventArgs e)
        {
            CBTransaction.Items.Clear();
            tempClient.Clear();
            tempClient = BBDD.listClient();
            List<String> tempString = new List<string>();
            foreach (Client d in tempClient)
            {
                tempString.Add(d.Name + " " + d.Surname);
            }
            CBTransaction.Items.AddRange(tempString.ToArray());
        }
    }
}
