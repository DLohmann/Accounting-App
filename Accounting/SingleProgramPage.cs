using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class SingleProgramPage : Form
    {
        public DataGridView programList = null; // Points to the dataGridview on ProgramListPage. used to add a new row
        public DataGridViewRow dataList = null; // Points to an individual row in datagridview on ProgramListPage. Used to modify a row
        public SingleProgramPage(DataGridView dataChart)
        {   // This constructor is to create a new program
            InitializeComponent();
            programList = dataChart;
        }

        public SingleProgramPage(DataGridView dataChart, DataGridViewRow dataRow)
        {   // This constructor is to modify program in datagridview
            InitializeComponent();
            programList = dataChart;
            dataList = dataRow;

            for (short colm = 0; colm < dataRow.Cells.Count; colm++)
            {
                try
                {
                    switch (colm)
                    {
                        case 0:
                            ProgramNameTextBox.Text = dataList.Cells[0].Value.ToString();
                            break;
                        case 1:
                            FiscalYearTextBox.Text = dataList.Cells[1].Value.ToString();
                            break;
                        case 2:
                            ContactTextBox.Text = dataList.Cells[2].Value.ToString();
                            break;
                        case 3:
                            AddressTextBox.Text = dataList.Cells[3].Value.ToString();
                            break;
                        case 4:
                            ContributorsTextBox.Text = dataList.Cells[4].Value.ToString();
                            break;
                        case 5:
                            NotesTextBox.Text = dataList.Cells[5].Value.ToString();
                            break;
                        default:
                            MessageBox.Show("Error: unexpexted number of columns in program row");
                            break;
                    }
                }
                catch (NullReferenceException)  // this will catch if the value of the cell being read is empty
                {
                    //colm++; // skip over any boxes in which the row does not have a value
                    continue;
                }
                
            }
            
            
            
            
            
            
        }

        private void ProgramNameTestBox_KeyPress(object sender, KeyPressEventArgs e)
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
                ContributorsTextBox.Select();
            }
        }

        private void ContributorsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                NotesTextBox.Select();
            }
        }

        private void NotesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                AddProgram_Click(sender, null);
            }
        }

        private void AddProgram_Click(object sender, EventArgs e)
        {   /* 
            Make a new row and assign the values from the textboxes to it

            if a new row is to be added (meaning that the first singleprogrampage constructor was used, 
            and datagridview was passed to this SingleProgramPage.cs, then add the new row.

            else assume that a row is being modified. So delete that row and replace it, at it's position, 
            with new row
            */

            DataGridViewRow programRow = new DataGridViewRow();                 // create datagridviewrow to add stuff to                                                           
            programRow.CreateCells(programList);                                // Make the DataGridViewRow's columns just like the DataGridView's Columns
            programRow.Cells[0].Value = ProgramNameTextBox.Text;                // Add the Program Name
            programRow.Cells[1].Value = FiscalYearTextBox.Text;                 // Add the Fiscal Year
            programRow.Cells[2].Value = ContactTextBox.Text;                    // Add the Contact
            programRow.Cells[3].Value = AddressTextBox.Text;                    // Add the Address
            programRow.Cells[4].Value = ContributorsTextBox.Text;               // Add the Contibutors
            programRow.Cells[5].Value = NotesTextBox.Text;                      // Add the Notes

            if (dataList == null)
            {   // occurs it dataList was not assigned to point to a row, and therefore a new row should be added
                // add the new row to datagridview
                
                programList.Rows.Add(programRow);   // Add this row to the dataGridView of programs in programListPage
                
            }
            else
            {
                // delete the row that is modified, and replace it at it's position with new row
                programList.Rows.Insert(dataList.Index, programRow);
                programList.Rows.Remove(dataList);
            }
            this.Close();
        }  
    }
}
