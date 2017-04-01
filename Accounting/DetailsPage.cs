using System;
using System.Windows.Forms;
using System.Xml;




namespace Accounting
{
    public partial class DetailsPage : Form
    {
        XmlNode Details;
        public DetailsPage(XmlNode Company )
        {
            InitializeComponent();
            Details = Company;

            CompanyNameTextBox.Text = Details.ChildNodes.Item(0).InnerXml;
            FiscalYearTextBox.Text  = Details.ChildNodes.Item(1).InnerXml;
            ContactTextBox.Text     = Details.ChildNodes.Item(2).InnerXml;
            AddressTextBox.Text     = Details.ChildNodes.Item(3).InnerXml;
            NotesTextBox.Text       = Details.ChildNodes.Item(4).InnerXml;
            
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            //CompanyPage backToCompanyPage = new CompanyPage();
            //backToCompanyPage.ShowDialog();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CompanyNameTextBox.Text != null)
            {
                Details.ChildNodes.Item(0).InnerText = CompanyNameTextBox.Text; // assign company name
            }
            
            if (FiscalYearTextBox.Text != null)
            {
                Details.ChildNodes.Item(1).InnerText = FiscalYearTextBox.Text; // assign year
            }
            
            if (ContactTextBox.Text != null)
            {
                Details.ChildNodes.Item(2).InnerText = ContactTextBox.Text; // assign contac
            }

            if (AddressTextBox.Text != null)
            {
                Details.ChildNodes.Item(3).InnerText = AddressTextBox.Text; // assign address
            }

            if (NotesTextBox.Text != null)
            {
                Details.ChildNodes.Item(4).InnerText = NotesTextBox.Text; // assign notes
            }
            Close();
        }

        private void CompanyNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                FiscalYearTextBox.Select();
            }
        }

        private void FiscalYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ContactTextBox.Select();
            }
        }

        private void ContactTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                AddressTextBox.Select();
            }
        }

        private void AddressTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                NotesTextBox.Select();
            }
        }

        private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {   
            // This feature allows users to save company details by pressing enter
            /*
            if (e.KeyChar == '\r')
            {
                SaveButton_Click(sender, e);
            }
            */
        }

        private void DetailsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            this.Owner.Show();
        }
    }
}