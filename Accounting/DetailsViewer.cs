using System;
using System.Xml;
using System.Windows.Forms;

namespace Accounting
{
    public partial class DetailsViewer : Form
    {
        XmlNode Details;
        public DetailsViewer(XmlNode Company)
        {
            InitializeComponent();
            Details = Company;

            DetailsLabel.Text       = Details.ChildNodes.Item(0).InnerXml + " Details";
            DisplayFiscalYear.Text  = Details.ChildNodes.Item(1).InnerXml;
            DisplayContactInfo.Text = Details.ChildNodes.Item(2).InnerXml;
            DisplayAddress.Text     = Details.ChildNodes.Item(3).InnerXml;
            Notes.Text              = Details.ChildNodes.Item(4).InnerXml;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NotesLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void ContactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContactLabel_Click(object sender, EventArgs e)
        {

        }

        private void FiscalYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiscalYearLabel_Click(object sender, EventArgs e)
        {

        }

        private void DetailsLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {

        }

        private void AccountButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void DetailsViewer_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void DetailsViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            this.Owner.Show();
        }
    }
}
