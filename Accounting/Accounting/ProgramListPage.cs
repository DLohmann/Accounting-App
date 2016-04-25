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
    public partial class ProgramListPage : Form
    {
        public ProgramListPage()
        {
            InitializeComponent();
        }

        private void ProgramPage_Load(object sender, EventArgs e)
        {

        }

        private void NewProgram_Click(object sender, EventArgs e)
        {
            SingleProgramPage newProgram = new SingleProgramPage();
            newProgram.ShowDialog();

        }
    }
}
