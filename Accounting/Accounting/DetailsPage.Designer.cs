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
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(14, 7);
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
            this.AccountButton.Location = new System.Drawing.Point(416, 107);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(117, 45);
            this.AccountButton.TabIndex = 1;
            this.AccountButton.Text = "Account";
            this.AccountButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(416, 170);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(117, 45);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(23, 62);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(129, 39);
            this.DetailsLabel.TabIndex = 3;
            this.DetailsLabel.Text = "Details";
            // 
            // FiscalYearLabel
            // 
            this.FiscalYearLabel.AutoSize = true;
            this.FiscalYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiscalYearLabel.Location = new System.Drawing.Point(30, 105);
            this.FiscalYearLabel.Name = "FiscalYearLabel";
            this.FiscalYearLabel.Size = new System.Drawing.Size(109, 25);
            this.FiscalYearLabel.TabIndex = 5;
            this.FiscalYearLabel.Text = "Fiscal Year";
            // 
            // FiscalYearTextBox
            // 
            this.FiscalYearTextBox.Location = new System.Drawing.Point(35, 133);
            this.FiscalYearTextBox.Name = "FiscalYearTextBox";
            this.FiscalYearTextBox.Size = new System.Drawing.Size(355, 20);
            this.FiscalYearTextBox.TabIndex = 6;
            this.FiscalYearTextBox.Text = "FiscalYearBox";
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(35, 201);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(355, 20);
            this.ContactTextBox.TabIndex = 8;
            this.ContactTextBox.Text = "ContactBox";
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactLabel.Location = new System.Drawing.Point(30, 173);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(80, 25);
            this.ContactLabel.TabIndex = 7;
            this.ContactLabel.Text = "Contact";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(35, 263);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(355, 20);
            this.AddressTextBox.TabIndex = 10;
            this.AddressTextBox.Text = "AddressBox";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(30, 235);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(85, 25);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.AllowDrop = true;
            this.NotesTextBox.Location = new System.Drawing.Point(35, 321);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(355, 95);
            this.NotesTextBox.TabIndex = 12;
            this.NotesTextBox.Text = "NotesBox";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(30, 293);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(63, 25);
            this.NotesLabel.TabIndex = 11;
            this.NotesLabel.Text = "Notes";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(107, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 45);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // DetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 438);
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
            this.Name = "DetailsPage";
            this.Text = "DetailsPage";
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
    }
}