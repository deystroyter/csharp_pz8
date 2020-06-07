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
    public partial class DeleteAbonentForm : Form
    {
        public DeleteAbonentForm(MainForm MF)
        {
            InitializeComponent();
            maskedTextBoxDeleteAbonent.Mask = "9990000000000";
            this.MF = MF;
        }
        public MainForm MF;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                XDocument xdoc = XDocument.Load(MainForm.source);
                IEnumerable<XElement> delArr = xdoc.Element("Abonents").Elements("Abonent").Where(s => s.Element("contractNum").Value == maskedTextBoxDeleteAbonent.Text);

                if (delArr.Count() == 0)
                {
                    MessageBox.Show("Договор не найден: " + maskedTextBoxDeleteAbonent.Text);
                }
                else
                {
                    foreach (var elem in delArr)
                    {
                        try
                        {
                            delArr.Remove();
                            xdoc.Save(MainForm.source);
                            MessageBox.Show("Удалена информация об абоненте: \n" + maskedTextBoxDeleteAbonent);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при удалении.\n" + ex.Message, "Ошибка");
                        }
                    }
                    MF.ShowWithFilter(999, "AllUsersPlease");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex);
            }
            this.Close();
        }
    }
}

