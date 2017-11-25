using System;

namespace Accounting
{
    partial class DetailsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsPage));
            this.Back = new System.Windows.Forms.Button();
            this.AccountButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.FiscalYearLabel = new System.Windows.Forms.Label();
            this.FiscalYearTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.CompanyNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 45);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.Location = new System.Drawing.Point(366, 12);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(101, 45);
            this.AccountButton.TabIndex = 1;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(473, 12);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(79, 45);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(184, 9);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(176, 25);
            this.DetailsLabel.TabIndex = 3;
            this.DetailsLabel.Text = "Company Details";
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalYearLabel.Location = new System.Drawing.Point(7, 140);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(109, 25);
            this.FiscalYearLabel.TabIndex = 5;
            this.FiscalYearLabel.Text = "Fiscal Year";
            // 
            // FiscalYearTextBox
            // 
            this.FiscalYearTextBox.Location = new System.Drawing.Point(12, 168);
            this.FiscalYearTextBox.Name = "FiscalYearTextBox";
            this.FiscalYearTextBox.Size = new System.Drawing.Size(540, 20);
            this.FiscalYearTextBox.TabIndex = 6;
            this.FiscalYearTextBox.Text = "FiscalYearBox";
            this.FiscalYearTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiscalYearTextBox_KeyPress);
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(12, 219);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(540, 20);
            this.ContactTextBox.TabIndex = 8;
            this.ContactTextBox.Text = "ContactBox";
            this.ContactTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactTextBox_KeyPress);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(7, 191);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(80, 25);
            this.ContactLabel.TabIndex = 7;
            this.ContactLabel.Text = "Contact";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(12, 270);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(540, 20);
            this.AddressTextBox.TabIndex = 10;
            this.AddressTextBox.Text = "AddressBox";
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(7, 242);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(85, 25);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.AllowDrop = true;
            this.NotesTextBox.Location = new System.Drawing.Point(12, 321);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(540, 105);
            this.NotesTextBox.TabIndex = 12;
            this.NotesTextBox.Text = "NotesBox";
            this.NotesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NotesTextBox_KeyPress);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(7, 293);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(63, 25);
            this.NotesLabel.TabIndex = 11;
            this.NotesLabel.Text = "Notes";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(98, 12);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 45);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(12, 117);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(540, 20);
            this.CompanyNameTextBox.TabIndex = 15;
            this.CompanyNameTextBox.Text = "CompanyNameBox";
            this.CompanyNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CompanyNameTextBox_KeyPress);
            // 
            // CompanyNameLabel
            // 
            this.CompanyNameLabel.AutoSize = true;
            this.CompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameLabel.Location = new System.Drawing.Point(7, 89);
            this.CompanyNameLabel.Name = "CompanyNameLabel";
            this.CompanyNameLabel.Size = new System.Drawing.Size(154, 25);
            this.CompanyNameLabel.TabIndex = 14;
            this.CompanyNameLabel.Text = "Company Name";
            // 
            // DetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 438);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.CompanyNameLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.FiscalYearTextBox);
            this.Controls.Add(this.FiscalYearLabel);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.AccountButton);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetailsPage";
            this.Text = "DetailsPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetailsPage_FormClosed);
            this.Load += new System.EventHandler(this.DetailsPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label FiscalYearLabel;
        private System.Windows.Forms.TextBox FiscalYearTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label CompanyNameLabel;
    }
}