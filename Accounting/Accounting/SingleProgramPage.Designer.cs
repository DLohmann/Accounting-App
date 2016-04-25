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
            this.ProgramNameTestBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ContactTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
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
            this.ContactLabel.Location = new System.Drawing.Point(44, 92);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(72, 22);
            this.ContactLabel.TabIndex = 1;
            this.ContactLabel.Text = "Contact";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(44, 161);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(76, 22);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(44, 233);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(57, 22);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Notes";
            // 
            // ProgramNameTestBox
            // 
            this.ProgramNameTestBox.Location = new System.Drawing.Point(71, 63);
            this.ProgramNameTestBox.Name = "ProgramNameTestBox";
            this.ProgramNameTestBox.Size = new System.Drawing.Size(353, 20);
            this.ProgramNameTestBox.TabIndex = 4;
            this.ProgramNameTestBox.Text = "Please give this program a name";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(71, 196);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(353, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // ContactTextBox
            // 
            this.ContactTextBox.Location = new System.Drawing.Point(71, 127);
            this.ContactTextBox.Name = "ContactTextBox";
            this.ContactTextBox.Size = new System.Drawing.Size(353, 20);
            this.ContactTextBox.TabIndex = 6;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Location = new System.Drawing.Point(71, 258);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(353, 20);
            this.NotesTextBox.TabIndex = 7;
            // 
            // SingleProgramPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 369);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.ContactTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.ProgramNameTestBox);
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
        private System.Windows.Forms.TextBox ProgramNameTestBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox ContactTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
    }
}