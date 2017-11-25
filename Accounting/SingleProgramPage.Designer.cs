namespace Accounting
{
    partial class SingleProgramPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProgramNameLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.ProgramNameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.AddProgram = new System.Windows.Forms.Button();
            this.FiscalYearLabel = new System.Windows.Forms.Label();
            this.FiscalYearTextBox = new System.Windows.Forms.TextBox();
            this.ContributorsTextBox = new System.Windows.Forms.TextBox();
            this.ContributorsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgramNameLabel
            // 
            this.ProgramNameLabel.AutoSize = true;
            this.ProgramNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameLabel.Location = new System.Drawing.Point(44, 26);
            this.ProgramNameLabel.Name = "ProgramNameLabel";
            this.ProgramNameLabel.Size = new System.Drawing.Size(125, 22);
            this.ProgramNameLabel.TabIndex = 0;
            this.ProgramNameLabel.Text = "ProgramName";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(44, 168);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(72, 22);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(44, 237);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(76, 22);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(44, 377);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(57, 22);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Notes";
            // 
            // ProgramNameTextBox
            // 
            this.ProgramNameTextBox.Location = new System.Drawing.Point(71, 63);
            this.ProgramNameTextBox.Name = "ProgramNameTextBox";
            this.ProgramNameTextBox.Size = new System.Drawing.Size(353, 20);
            this.ProgramNameTextBox.TabIndex = 4;
            this.ProgramNameTextBox.Text = "Please give this program a name";
            this.ProgramNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramNameTestBox_KeyPress);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(71, 272);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(353, 20);
            this.AddressTextBox.TabIndex = 5;
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(71, 203);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(353, 20);
            this.ContactTextBox.TabIndex = 6;
            this.ContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextBox_KeyPress);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(71, 402);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(353, 50);
            this.NotesTextBox.TabIndex = 7;
            this.NotesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotesTextBox_KeyPress);
            // 
            // AddProgram
            // 
            this.AddProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProgram.Location = new System.Drawing.Point(144, 462);
            this.AddProgram.Name = "AddProgram";
            this.AddProgram.Size = new System.Drawing.Size(185, 43);
            this.AddProgram.TabIndex = 8;
            this.AddProgram.Text = "Make Changes";
            this.AddProgram.UseVisualStyleBackColor = true;
            this.AddProgram.Click += new System.EventHandler(this.AddProgram_Click);
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalYearLabel.Location = new System.Drawing.Point(44, 101);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(100, 22);
            this.FiscalYearLabel.TabIndex = 9;
            this.FiscalYearLabel.Text = "Fiscal Year";
            // 
            // FiscalYearTextBox
            // 
            this.FiscalYearTextBox.Location = new System.Drawing.Point(71, 137);
            this.FiscalYearTextBox.Name = "FiscalYearTextBox";
            this.FiscalYearTextBox.Size = new System.Drawing.Size(353, 20);
            this.FiscalYearTextBox.TabIndex = 10;
            this.FiscalYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiscalYearTextBox_KeyPress);
            // 
            // ContributorsTextBox
            // 
            this.ContributorsTextBox.Location = new System.Drawing.Point(71, 344);
            this.ContributorsTextBox.Name = "ContributorsTextBox";
            this.ContributorsTextBox.Size = new System.Drawing.Size(353, 20);
            this.ContributorsTextBox.TabIndex = 12;
            this.ContributorsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContributorsTextBox_KeyPress);
            // 
            // ContributorsLabel
            // 
            this.ContributorsLabel.AutoSize = true;
            this.ContributorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContributorsLabel.Location = new System.Drawing.Point(44, 309);
            this.ContributorsLabel.Name = "ContributorsLabel";
            this.ContributorsLabel.Size = new System.Drawing.Size(108, 22);
            this.ContributorsLabel.TabIndex = 11;
            this.ContributorsLabel.Text = "Contributors";
            // 
            // SingleProgramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 517);
            this.Controls.Add(this.ContributorsTextBox);
            this.Controls.Add(this.ContributorsLabel);
            this.Controls.Add(this.FiscalYearTextBox);
            this.Controls.Add(this.FiscalYearLabel);
            this.Controls.Add(this.AddProgram);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ProgramNameTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.ProgramNameLabel);
            this.Name = "SingleProgramPage";
            this.Text = "SingleProgramPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramNameLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox ProgramNameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button AddProgram;
        private System.Windows.Forms.Label FiscalYearLabel;
        private System.Windows.Forms.TextBox FiscalYearTextBox;
        private System.Windows.Forms.TextBox ContributorsTextBox;
        private System.Windows.Forms.Label ContributorsLabel;
    }
}