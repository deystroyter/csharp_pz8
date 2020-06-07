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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowWithFilter(999, "AllUsersPlease");
        }

        public static string source = "../../source.xml";

        public void ShowWithFilter(int FIndex, string FText)
        {
            richTextBox1.Text = "";
            try
            {
                switch (FIndex)
                {
                    case 0:
                        richTextBox1.Text = ">>>>>>>>>>Включен фильтр по Фамилии<<<<<<<<<< " + Environment.NewLine;
                        break;
                    case 1:
                        richTextBox1.Text = ">>>>>>>>>>Включен фильтр по Району<<<<<<<<<< " + Environment.NewLine;
                        break;
                    case 2:
                        richTextBox1.Text = ">>>>>>>>>>Включен фильтр по Дате заключения договора<<<<<<<<<< " + Environment.NewLine;
                        break;
                    case 3:
                        richTextBox1.Text = ">>>>>>>>>>Включен фильтр по Дате последнего платежа<<<<<<<<<< " + Environment.NewLine;
                        break;
                    case 999:
                        richTextBox1.Text = ">>>>>>>>>>Фильтры отключены<<<<<<<<<< " + Environment.NewLine;
                        break;
                    default:
                        throw new Exception("Это как сюда попасть-то? (ShowWithFilters Switch Default Exception)");
                }

                XDocument xdoc = XDocument.Load(source);
                var Abonents = xdoc.Element("Abonents");
                foreach (XElement Abonent in Abonents.Elements("Abonent"))
                {

                    richTextBox1.Text += GetAbonentInfo(Abonent, FIndex, FText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:\n" + ex.Message);
            }

        }

        public string GetAbonentInfo(XElement xe, int FIndex, string FText)
        {
            //int number;
            string info = "";
            XElement surname = xe.Element("surname");
            XElement district = xe.Element("district");
            XElement address = xe.Element("address");
            XElement phone = xe.Element("phone");
            XElement contractNum = xe.Element("contractNum");
            XElement dateContract = xe.Element("dateContract");
            XElement installPayment = xe.Element("installPayment");
            XElement subPayment = xe.Element("subPayment");
            XElement dateLastPay = xe.Element("dateLastPay");
            
            switch (FIndex)
            {
                case 0: //по фамилии
                    if (surname.Value != FText)
                    {
                        return "";
                    }
                    break;
                case 1: //по району
                    if (district.Value != FText)
                    {
                        return "";
                    }
                    break;
                case 2: //по дате заключения договора
                    if (dateContract.Value != FText)
                    {
                        return "";
                    }
                    break;
                case 3: //по дате последнего платежа
                    if (dateLastPay.Value != FText)
                    {
                        return "";
                    }
                    break;
                case 999:
                    break;
                default:
                    throw new Exception("Cюда вообще нереально попасть? (GetAbonentInfo Switch Default Exception)");
            }





            if (surname != null && phone != null && district != null &&
                address != null && contractNum != null && dateContract != null && installPayment != null && subPayment != null && dateLastPay != null &&
                surname.Value != "" && district.Value != "" && address.Value != "" && phone.Value != "" && contractNum.Value != "" && dateContract.Value != "" && installPayment.Value != "" && subPayment.Value != "" && dateLastPay.Value != "")
            {
                info = "Фамилия: " + surname.Value + Environment.NewLine +
                        "Район " + district.Value + Environment.NewLine +
                        "Адрес: " + address.Value + Environment.NewLine +
                        "Телефон: " + phone.Value + Environment.NewLine +
                        "Номер контракта: " + contractNum.Value + Environment.NewLine +
                        "Дата заключения контракта: " + dateContract.Value + Environment.NewLine +
                        "Оплата установки: " + installPayment.Value + Environment.NewLine +
                        "Ежемесячная плата: " + subPayment.Value + Environment.NewLine +
                        "Дата последнего платежа: " + dateLastPay.Value + Environment.NewLine + Environment.NewLine;
            }
            else { info = "Что-то пустоватенько :("; }
            return info;

        }
        private void выбратьФильтрПоискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFilterForm SFForm = new SelectFilterForm(this);
            SFForm.Show();
        }

        private void очиститьФильтрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWithFilter(999, "AllUsersPlease");
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAbonentForm AAForm = new AddAbonentForm(this);
            AAForm.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAbonentForm DAForm = new DeleteAbonentForm(this);
            DAForm.Show();
        }
    }
}
