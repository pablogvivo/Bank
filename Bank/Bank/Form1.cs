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
        private byte _selectButton=0;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BDCom t = new BDCom("localhost", "client_conn", "client", "tyu567");
            btCreateClient.BackColor = Color.LawnGreen;
        }
        #region Button
        private void BtDeposit_Click(object sender, EventArgs e)
        {
            btTransfer.BackColor = btCreateClient.BackColor = Color.LightGray;
            btDeposit.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbDeposit;

        }
        private void BtCreateClient_Click(object sender, EventArgs e)
        {
            btTransfer.BackColor = btDeposit.BackColor =  Color.LightGray;
            btCreateClient.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbCreate;
        }

        private void BtTransfer_Click(object sender, EventArgs e)
        {
            btDeposit.BackColor = btCreateClient.BackColor = Color.LightGray;
            btTransfer.BackColor = Color.LawnGreen;
            tbMain.SelectedTab = tbTransfer;
        }
        #endregion

    }
}
