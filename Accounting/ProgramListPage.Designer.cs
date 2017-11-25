namespace Accounting
{
    partial class ProgramListPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramListPage));
            this.BackButton = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.Label();
            this.NewProgram = new System.Windows.Forms.Button();
            this.ProgramDataGridView = new System.Windows.Forms.DataGridView();
            this.ProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiscalYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contributors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteProgram = new System.Windows.Forms.Button();
            this.ModProgram = new System.Windows.Forms.Button();
            this.SavePrograms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(77, 50);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(251, 9);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(160, 25);
            this.CompanyName.TabIndex = 1;
            this.CompanyName.Text = "CompanyName";
            // 
            // NewProgram
            // 
            this.NewProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProgram.Location = new System.Drawing.Point(417, 12);
            this.NewProgram.Name = "NewProgram";
            this.NewProgram.Size = new System.Drawing.Size(77, 50);
            this.NewProgram.TabIndex = 2;
            this.NewProgram.Text = "+Add Program";
            this.NewProgram.UseVisualStyleBackColor = true;
            this.NewProgram.Click += new System.EventHandler(this.NewProgram_Click);
            // 
            // ProgramDataGridView
            // 
            this.ProgramDataGridView.AllowUserToAddRows = false;
            this.ProgramDataGridView.AllowUserToDeleteRows = false;
            this.ProgramDataGridView.AllowUserToOrderColumns = true;
            this.ProgramDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgramDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProgramDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProgramName,
            this.FiscalYear,
            this.Contact,
            this.Address,
            this.Contributors,
            this.Notes});
            this.ProgramDataGridView.Location = new System.Drawing.Point(12, 68);
            this.ProgramDataGridView.Name = "ProgramDataGridView";
            this.ProgramDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProgramDataGridView.Size = new System.Drawing.Size(656, 315);
            this.ProgramDataGridView.TabIndex = 3;
            // 
            // ProgramName
            // 
            this.ProgramName.HeaderText = "Program";
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.ReadOnly = true;
            // 
            // FiscalYear
            // 
            this.FiscalYear.HeaderText = "Fiscal Year";
            this.FiscalYear.Name = "FiscalYear";
            this.FiscalYear.ReadOnly = true;
            // 
            // Contact
            // 
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            this.Contact.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Contributors
            // 
            this.Contributors.HeaderText = "Contributors";
            this.Contributors.Name = "Contributors";
            this.Contributors.ReadOnly = true;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            // 
            // DeleteProgram
            // 
            this.DeleteProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProgram.Location = new System.Drawing.Point(587, 12);
            this.DeleteProgram.Name = "DeleteProgram";
            this.DeleteProgram.Size = new System.Drawing.Size(81, 50);
            this.DeleteProgram.TabIndex = 4;
            this.DeleteProgram.Text = "-Delete Selected";
            this.DeleteProgram.UseVisualStyleBackColor = true;
            this.DeleteProgram.Click += new System.EventHandler(this.DeleteProgram_Click);
            // 
            // ModProgram
            // 
            this.ModProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModProgram.Location = new System.Drawing.Point(500, 12);
            this.ModProgram.Name = "ModProgram";
            this.ModProgram.Size = new System.Drawing.Size(81, 50);
            this.ModProgram.TabIndex = 5;
            this.ModProgram.Text = "Modify Selected";
            this.ModProgram.UseVisualStyleBackColor = true;
            this.ModProgram.Click += new System.EventHandler(this.ModProgram_Click);
            // 
            // SavePrograms
            // 
            this.SavePrograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePrograms.Location = new System.Drawing.Point(95, 12);
            this.SavePrograms.Name = "SavePrograms";
            this.SavePrograms.Size = new System.Drawing.Size(150, 50);
            this.SavePrograms.TabIndex = 6;
            this.SavePrograms.Text = "Save Programs";
            this.SavePrograms.UseVisualStyleBackColor = true;
            this.SavePrograms.Click += new System.EventHandler(this.ChangePrograms_Click);
            // 
            // ProgramListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 395);
            this.Controls.Add(this.SavePrograms);
            this.Controls.Add(this.ModProgram);
            this.Controls.Add(this.DeleteProgram);
            this.Controls.Add(this.ProgramDataGridView);
            this.Controls.Add(this.NewProgram);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.BackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramListPage";
            this.Text = "ProgramListPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramListPage_FormClosed);
            this.Load += new System.EventHandler(this.ProgramPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProgramDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button NewProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProgramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FiscalYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contributors;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        public System.Windows.Forms.DataGridView ProgramDataGridView;
        private System.Windows.Forms.Button DeleteProgram;
        private System.Windows.Forms.Button ModProgram;
        private System.Windows.Forms.Button SavePrograms;
    }
}