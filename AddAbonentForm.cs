using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FedorovAD_Pz8
{
    public partial class AddAbonentForm : Form
    {
        public AddAbonentForm(MainForm context)
        {
            InitializeComponent();
            MasksInit();
            MF = context;
        }
        public MainForm MF;
        private void MasksInit()
        {
            foreach (MaskedTextBox MTB in this.Controls.OfType<MaskedTextBox>())
                MTB.Text = "foo";
            maskedTextBoxAddContractNum.Mask = "00000000000000000";
            maskedTextBoxAddDateLastPay.Mask = "00.00.0000";
            maskedTextBoxAddDateContract.Mask = "00.00.0000";
            maskedTextBoxAddPhone.Mask = "00000000000000000";
            maskedTextBoxAddDistrict.Mask = ">L<L??????????????????????";
            maskedTextBoxAddSubPayment.Mask = "999000";
            maskedTextBoxAddSurname.Mask = ">L<L??????????????????????";

        }

        private void buttonAddConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var Surname = new XElement("surname", maskedTextBoxAddSurname.Text);
                var District = new XElement("district", maskedTextBoxAddDistrict.Text);
                var Address = new XElement("address", maskedTextBoxAddAddress.Text);
                var Phone = new XElement ("phone", maskedTextBoxAddPhone.Text);
                var ContractNum = new XElement("contractNum", maskedTextBoxAddContractNum.Text);
                var DateContract = new XElement("dateContract", DateTime.Parse(maskedTextBoxAddDateContract.Text));
                var InstallPayment = new XElement("installPayment", checkBoxInstallPayment.Checked);
                var SubPayment = new XElement("subPayment", uint.Parse(maskedTextBoxAddSubPayment.Text));
                var DateLastPay = new XElement("dateLastPay", DateTime.Parse(maskedTextBoxAddDateLastPay.Text));
                

                XDocument xdoc = XDocument.Load(MainForm.source);
                var Abonents = xdoc.Element("Abonents");
                Abonents.Add(new XElement("Abonent", Surname, District, Address, Phone, ContractNum, DateContract, InstallPayment, SubPayment, DateLastPay));

                xdoc.Save(MainForm.source);
                MF.ShowWithFilter(999, "AllUsersPlease");
                
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex);
                this.Close();
            }
        }

        #region maskedTextBoxesClicks

        private void maskedTextBoxAddSurname_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddSurname.SelectionStart = 0;
        }

        private void maskedTextBoxAddDistrict_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddDistrict.SelectionStart = 0;
        }

        private void maskedTextBoxAddAddress_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddAddress.SelectionStart = 0;
        }

        private void maskedTextBoxAddPhone_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddPhone.SelectionStart = 0;
        }

        private void maskedTextBoxAddContractNum_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddContractNum.SelectionStart = 0;
        }

        private void maskedTextBoxAddDateContract_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddDateContract.SelectionStart = 0;
        }

        private void maskedTextBoxAddSubPayment_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddSubPayment.SelectionStart = 0;
        }

        private void maskedTextBoxAddDateLastPay_Click(object sender, EventArgs e)
        {
            maskedTextBoxAddDateLastPay.SelectionStart = 0;
        }

        #endregion

    }
}
