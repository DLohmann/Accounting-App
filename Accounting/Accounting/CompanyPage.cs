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

namespace Accounting
{
    public partial class CompanyPage : Form
    {
        public CompanyPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Details_Button(object sender, EventArgs e)
        {
            DetailsViewer DisplayDetails = new DetailsViewer();
            DisplayDetails.ShowDialog();
            this.Close();
            
        }

        private void Programs_Button(object sender, EventArgs e)
        {
            ProgramListPage programs = new ProgramListPage();
            programs.ShowDialog();
            this.Close();
        }

        private void LogOff_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Button(object sender, EventArgs e)
        {
            DetailsPage companyInfoEdit = new DetailsPage();
            companyInfoEdit.ShowDialog();
            this.Close();
            
            /*
            XDocument programs = new XDocument();
            programs = XDocument.Parse("<Alliance>"
                                           +"<Details>"
                                                +"<FiscalYear>July 1st - June 30th</FiscalYear>"
                                                +"<Contact>Jane Mattheson, President</Contact>"
                                           +"</Details>"
                                           +"<Programs>"
                                           +"</Programs>"
                                      +"</Alliance>");
            */
            //var result = XMLData.Element("Programs").Desendants();
            /*
            foreach (XElement item in result)
            {
                textBox1.Text += ("item " + item.Value);
            }
            */
        }
    }
}
