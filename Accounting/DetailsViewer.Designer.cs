namespace Accounting
{
    partial class DetailsViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsViewer));
            this.SaveButton = new System.Windows.Forms.Button();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.FiscalYearLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ReportButton = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.DisplayFiscalYear = new System.Windows.Forms.Label();
            this.DisplayContactInfo = new System.Windows.Forms.Label();
            this.DisplayAddress = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(105, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 45);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(28, 298);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(63, 25);
            this.NotesLabel.TabIndex = 24;
            this.NotesLabel.Text = "Notes";
            this.NotesLabel.Click += new System.EventHandler(this.NotesLabel_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(28, 240);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(85, 25);
            this.AddressLabel.TabIndex = 22;
            this.AddressLabel.Text = "Address";
            this.AddressLabel.Click += new System.EventHandler(this.AddressLabel_Click);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(28, 178);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(80, 25);
            this.ContactLabel.TabIndex = 20;
            this.ContactLabel.Text = "Contact";
            this.ContactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalYearLabel.Location = new System.Drawing.Point(28, 110);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(109, 25);
            this.FiscalYearLabel.TabIndex = 18;
            this.FiscalYearLabel.Text = "Fiscal Year";
            this.FiscalYearLabel.Click += new System.EventHandler(this.FiscalYearLabel_Click);
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(21, 67);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(129, 39);
            this.DetailsLabel.TabIndex = 17;
            this.DetailsLabel.Text = "Details";
            this.DetailsLabel.Click += new System.EventHandler(this.DetailsLabel_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(414, 175);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(117, 45);
            this.ReportButton.TabIndex = 16;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.Location = new System.Drawing.Point(414, 112);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(117, 45);
            this.AccountButton.TabIndex = 15;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 45);
            this.Back.TabIndex = 14;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DisplayFiscalYear
            // 
            this.DisplayFiscalYear.AutoSize = true;
            this.DisplayFiscalYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFiscalYear.Location = new System.Drawing.Point(47, 135);
            this.DisplayFiscalYear.Name = "DisplayFiscalYear";
            this.DisplayFiscalYear.Size = new System.Drawing.Size(104, 15);
            this.DisplayFiscalYear.TabIndex = 27;
            this.DisplayFiscalYear.Text = "DisplayFiscalYear";
            // 
            // DisplayContactInfo
            // 
            this.DisplayContactInfo.AutoSize = true;
            this.DisplayContactInfo.Location = new System.Drawing.Point(47, 207);
            this.DisplayContactInfo.Name = "DisplayContactInfo";
            this.DisplayContactInfo.Size = new System.Drawing.Size(96, 13);
            this.DisplayContactInfo.TabIndex = 28;
            this.DisplayContactInfo.Text = "DisplayContactInfo";
            // 
            // DisplayAddress
            // 
            this.DisplayAddress.AutoSize = true;
            this.DisplayAddress.Location = new System.Drawing.Point(50, 269);
            this.DisplayAddress.Name = "DisplayAddress";
            this.DisplayAddress.Size = new System.Drawing.Size(79, 13);
            this.DisplayAddress.TabIndex = 29;
            this.DisplayAddress.Text = "DisplayAddress";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(53, 327);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(69, 13);
            this.Notes.TabIndex = 30;
            this.Notes.Text = "DisplayNotes";
            // 
            // DetailsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 443);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.DisplayAddress);
            this.Controls.Add(this.DisplayContactInfo);
            this.Controls.Add(this.DisplayFiscalYear);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.FiscalYearLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailsViewer";
            this.Text = "DetailsViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailsViewer_FormClosed);
            this.Load += new System.EventHandler(this.DetailsViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Label FiscalYearLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label DisplayFiscalYear;
        private System.Windows.Forms.Label DisplayContactInfo;
        private System.Windows.Forms.Label DisplayAddress;
        private System.Windows.Forms.Label Notes;
    }
}