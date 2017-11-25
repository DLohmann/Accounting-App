using System;
using System.Windows.Forms;
using System.Xml;

namespace Accounting
{
    public partial class CompanyPage : Form
    {
        /*
        "fileName" indicates the path of where the file was opened from (and thus where to 
        save it back to), or is "null" if it is a new file
        */
        string fileName = null;
        XmlDocument compDoc = new XmlDocument();
        
        

        public CompanyPage()
        {
            InitializeComponent();
            string compXml = 
                "<Company>"
                    + "<Details>"
                        + "<Name></Name>"
                        + "<FiscalYear></FiscalYear>"
                        + "<Contact></Contact>"
                        + "<Address></Address>"
                        + "<Note></Note>"
                    + "</Details>"
                    + "<Programs></Programs>"
              + "</Company>";


            compDoc.LoadXml(compXml);
            compDoc.PreserveWhitespace = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Details_Button(object sender, EventArgs e)
        {
            DetailsViewer DisplayDetails = new DetailsViewer(compDoc.ChildNodes.Item(0).ChildNodes.Item(0));  // Passes details node in constructor
            DisplayDetails.Owner = this;
            DisplayDetails.Show();
            this.Hide();
            //this.Close();
            
        }

        private void Programs_Button(object sender, EventArgs e)
        {
            ProgramListPage programs = new ProgramListPage(compDoc.ChildNodes.Item(0).ChildNodes.Item(1));
            programs.Owner = this;
            programs.Show();
            this.Hide();


            /*
            programs.FormClosed += new FormClosedEventHandler (programs_FormClosed);
            programs.ShowDialog();
            this.Hide();
            */
            //this.Close();
        }
        /*
        void programs_FormClosed (object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        */




        private void LogOff_Button(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Button(object sender, EventArgs e)
        {   
            DetailsPage companyInfoEdit = new DetailsPage(compDoc.ChildNodes.Item(0).ChildNodes.Item(0));  // Passes details node in constructor
            companyInfoEdit.Owner = this;
            companyInfoEdit.Show();
            this.Hide();
            
            
            //companyInfoEdit.ShowDialog();
            //this.Hide();

            CompanyNameLabel.Text = compDoc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(0).InnerXml;  // assign company name label to get name from compDoc <Company>, <Details>, <Name>
            FiscalYearLabel.Text  = compDoc.ChildNodes.Item(0).ChildNodes.Item(0).ChildNodes.Item(1).InnerXml;  // assign company name label to get name from compDoc <Company>, <Details>, <FiscalYear>
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the Xml Doc, and reset all the labels so they can be edited
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Xml Files (.xml)|*.xml|All Files (*.*)|*.*";
            // Process input if the user clicked OK.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;    // This line makes sure that any more saves also go to "fileName"

                // Pass to the save function, which actually does the savin
                saveToolStripMenuItem_Click(sender, e);

            }
            
        }

        

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (fileName == null)
            {// if it is a new file (with no save location specified), treat file as if user had clicked "save as"
                saveAsToolStripMenuItem_Click(sender, e);
            } else  {   // if it is not a new file, and was opened already, then save to the old file location

                // Assign values to xml file's details node
                //compDoc.CreateNode(XmlNodeType.Element, "Name", "");  

                // Ensure the xml doc has a Company Name
                if (compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(0).InnerText == "")
                {
                    compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(0).InnerText = "Unnamed Company";
                }

                // Ensure the xml doc has a Fiscal Year
                if (compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(1).InnerText == "")
                {
                    compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(1).InnerText = "Fiscal Year not chosen";
                }

                // Ensure the xml doc has a Contact
                if (compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(2).InnerText == "")
                {
                    compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(2).InnerText = "Contacts not added";
                }

                // Ensure the xml doc has an Address
                if (compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(3).InnerText == "")
                {
                    compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(3).InnerText = "Address not added";
                }

                // Ensure the xml doc has Notes
                if (compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(4).InnerText == "")
                {
                    compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(4).InnerText = "No Notes";
                }

                compDoc.Save(fileName);
                MessageBox.Show("Saved " + fileName + "\nto " + fileName);
            }
            
        }

        //Hallelujah

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // sets value of XmlDocument "compDoc" to the file specified, and the fileName to correct save location

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Xml Files (.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;    // What the heck does this do?

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                compDoc = new XmlDocument();
                compDoc.Load(openFileDialog1.FileName);
            }
            
            // Makes all the labels the values of the labels in details

            CompanyNameLabel.Text = compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(0).InnerText;
            FiscalYearLabel.Text  = compDoc.GetElementsByTagName("Details").Item(0).ChildNodes.Item(1).InnerText;
        }

        private void viewXmlCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //compDoc.PreserveWhitespace = true; ;
            MessageBox.Show(compDoc.OuterXml);
        }
    }
}
