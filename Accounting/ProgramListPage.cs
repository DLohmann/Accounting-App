using System;
using System.Windows.Forms;
using System.Xml;



namespace Accounting
{
    public partial class ProgramListPage : Form
    {
        bool wasModified = false; // used to tell whether the datagridview (and thus the programs) were modified since last save
        XmlNode progsNod = null;    // used to reference nodes in the xml file
        
        public ProgramListPage(XmlNode progsNod)
        {
            InitializeComponent();
            this.progsNod = progsNod;

            // This "foreach" loop sets the values in the datagridview "programRow" to correspond the the various programs
            foreach (XmlNode program in progsNod.ChildNodes)
            {
                DataGridViewRow programRow = new DataGridViewRow();                 // create datagridviewrow to add stuff to   
                programRow.CreateCells(ProgramDataGridView);                                // Make the DataGridViewRow's columns just like the DataGridView's Columns
                
                XmlNode progNod = program.FirstChild;   // progNod is for each detail a program has. "program" is for each of the programs

                for (short i = 0; i < ProgramDataGridView.ColumnCount; i++)
                {
                    // MessageBox.Show("Row " + programRow.Cells[0].Value + " index " + i + " value " + programRow.Cells[i].Value); // used to check how cell was modified
                    if (progNod.InnerText == null)
                    {
                        programRow.Cells[i].Value = "";
                    } else {
                        programRow.Cells[i].Value = progNod.InnerText;
                        
                    }
                    progNod = progNod.NextSibling;
                }


                // The above code in the loop already does everything the commented code below used to do
                /*
                programRow.Cells[0].Value = progNod.InnerText;  // Add the Program Name
                progNod = progNod.NextSibling;
                programRow.Cells[1].Value = progNod.InnerText;  // Add the Fiscal Year
                progNod = progNod.NextSibling;
                programRow.Cells[2].Value = progNod.InnerText;  // Add the Contact
                progNod = progNod.NextSibling;
                programRow.Cells[3].Value = progNod.InnerText;  // Add the Address
                progNod = progNod.NextSibling;
                programRow.Cells[4].Value = progNod.InnerText;  // Add the Contibutors
                progNod = progNod.NextSibling;
                programRow.Cells[5].Value = progNod.InnerText;  // Add the Notes
                */
                // MessageBox.Show ("adding row " + programRow.Cells[0].Value + " to datagridview index " +)
                ProgramDataGridView.Rows.Add(programRow);
            }
        }
        
        private void ProgramPage_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
        }

        private void NewProgram_Click(object sender, EventArgs e)
        {
            SingleProgramPage newProgram = new SingleProgramPage(ProgramDataGridView);
            newProgram.ShowDialog();
            wasModified = true;  // ensure that the boolean indicates the progrms were attempted to be modified
        }

        private void ModProgram_Click(object sender, EventArgs e)
        {
            if (ProgramDataGridView.RowCount == 0)
            {
                MessageBox.Show("Must have at least 1 row to modify");
                return;
            }

            SingleProgramPage newProgram = new SingleProgramPage(ProgramDataGridView, ProgramDataGridView.SelectedRows[0]);
            newProgram.ShowDialog();
            wasModified = true;  // ensure that the boolean indicates the progrms were attempted to be modified
        }

        private void DeleteProgram_Click(object sender, EventArgs e)
        {
            DialogResult del = MessageBox.Show("Are you sure you would like to delete?", "Delete Selected?", MessageBoxButtons.YesNo);
            switch (del)
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    return;
                    break;
            }



            if (ProgramDataGridView.SelectedRows.Count > 0) // Must check if a row is selected when delete button is pushed. This is so that we don't get an error when referring to selectedRows
            {
                // delete row user selected
                foreach (DataGridViewRow row in ProgramDataGridView.SelectedRows)
                {
                    ProgramDataGridView.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete by clicking the side to the left of the row.");
            }
            wasModified = true;  // ensure that the boolean indicates the progrms were attempted to be modified
        }



        private void BackButton_Click(object sender, EventArgs e)
        {



            if (wasModified) {
                DialogResult shouldSave = MessageBox.Show ("Would you like to save changes to the program list before exiting?", "Save Programs?", MessageBoxButtons.YesNoCancel);
                switch (shouldSave)
                {
                    case DialogResult.Yes:
                        ChangePrograms_Click(sender, e);
                        break;
                    case DialogResult.Cancel:
                        return;
                    case DialogResult.No:
                        break;
                }
            }



            Close();
        }


        // This method saves the programs
        private void ChangePrograms_Click(object sender, EventArgs e)
        {
            // this is the new node to hold the list of programs
            progsNod.RemoveAll();
            //progsNod.InnerXml += "<tag></tag>";
            //XmlNode modProgsNod = null;
            
            foreach (DataGridViewRow progRow in ProgramDataGridView.Rows)
            {   // runs for each row in table
                //XmlNode progNod = new ;
                //progNod.ChildNodes.
                /*foreach (DataGridViewCell info in progRow.Cells)
                {   // runs for each cell in row
                    if (info.Value.ToString() != null)
                    {   // runs if cell is not empty. if cell is empty, then leave that node blank
                        //MessageBox.Show(progsNod.OuterXml);
                        //MessageBox.Show(progsNod.ChildNodes.Item(0).ChildNodes.Item(info.ColumnIndex).OuterXml);
                        progsNod.ChildNodes.Item(0).ChildNodes.Item(info.ColumnIndex).InnerXml = info.Value.ToString();
                    }
                    else
                    {
                        progsNod.ChildNodes.Item(0).ChildNodes.Item(info.ColumnIndex).InnerXml = "";
                    }
                }*/
                progsNod.InnerXml += "<Program" + progRow.Index + ">"  
                                        + "<Name>"          + progRow.Cells[0].Value.ToString() + "</Name>"
                                        + "<FiscalYear>"    + progRow.Cells[1].Value.ToString() + "</FiscalYear>"
                                        + "<Contact>"       + progRow.Cells[2].Value.ToString() + "</Contact>"
                                        + "<Address>"       + progRow.Cells[3].Value.ToString() + "</Address>"
                                        + "<Contributors>"  + progRow.Cells[4].Value.ToString() + "</Contributors>"
                                        + "<Note>"          + progRow.Cells[5].Value.ToString() + "</Note>"
                                    + "</Program" + progRow.Index + ">";
                
                //modProgsNod.AppendChild(progNod);
            }

            // if saving programlist worked, then assign the old programs node to become the modified programs node

            /*progsNod.RemoveAll();
            progsNod.InnerXml = modProgsNod.InnerXml;  //.Clone();
            */

            wasModified = false;    // since program is saved, from now on it was not modified since last save


            //Close(); // This closes the programListPage (after saving)
        }

        private void ProgramListPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
            this.Owner.Show();
        }
    }
}
