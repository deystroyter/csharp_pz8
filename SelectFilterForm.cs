using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FedorovAD_Pz8
{
    public partial class SelectFilterForm : Form
    {
        MainForm MForm;
        public SelectFilterForm(MainForm context)
        {
            InitializeComponent();
            InitializeComboBox();
            MForm = context;

            maskedTextBoxFilter.Text = "";
            maskedTextBoxFilter.Mask = ">L<L????????????????????????????????????";
        }

        private void InitializeComboBox()
        {

            comboBoxFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFilter.Items.Add("Фамилия");
            comboBoxFilter.Items.Add("Район");
            comboBoxFilter.Items.Add("Дата заключения договора");
            comboBoxFilter.Items.Add("Дата последнего платежа");
            comboBoxFilter.SelectedIndex = 0;
        }
        private void buttonСonfirmFilter_Click(object sender, EventArgs e)
        {
            try
            {
                MForm.ShowWithFilter(comboBoxFilter.SelectedIndex, maskedTextBoxFilter.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка");
            }
            this.Close();
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFilter.Text.ToLower().Contains("дата"))
            {
                maskedTextBoxFilter.Mask = "00.00.00";
            }
            else
            {
                maskedTextBoxFilter.Mask = ">L<L????????????????????????????????????";
            }
        }

        private void maskedTextBoxFilter_Click(object sender, EventArgs e)
        {
            maskedTextBoxFilter.SelectionStart = 0;
        }
    }
}
