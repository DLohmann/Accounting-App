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
            this.button1 = new System.Windows.Forms.Button();
            this.CompanyName = new System.Windows.Forms.Label();
            this.NewProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyName.Location = new System.Drawing.Point(67, 66);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(265, 39);
            this.CompanyName.TabIndex = 1;
            this.CompanyName.Text = "CompanyName";
            // 
            // NewProgram
            // 
            this.NewProgram.Location = new System.Drawing.Point(350, 66);
            this.NewProgram.Name = "NewProgram";
            this.NewProgram.Size = new System.Drawing.Size(107, 58);
            this.NewProgram.TabIndex = 2;
            this.NewProgram.Text = "+AddProgram";
            this.NewProgram.UseVisualStyleBackColor = true;
            this.NewProgram.Click += new System.EventHandler(this.NewProgram_Click);
            // 
            // ProgramListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 395);
            this.Controls.Add(this.NewProgram);
            this.Controls.Add(this.CompanyName);
            this.Controls.Add(this.button1);
            this.Name = "ProgramListPage";
            this.Text = "ProgramListPage";
            this.Load += new System.EventHandler(this.ProgramPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.Button NewProgram;
    }
}