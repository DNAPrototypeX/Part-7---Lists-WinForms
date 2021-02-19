namespace Part_7___Lists_WinForms
{
    partial class Form1
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
            this.lstNumbers = new System.Windows.Forms.ListBox();
            this.lstHeroes = new System.Windows.Forms.ListBox();
            this.btnRemoveNumber = new System.Windows.Forms.Button();
            this.btnRemoveAllNumbers = new System.Windows.Forms.Button();
            this.btnNewNumbers = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortHeroes = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.btnRemoveHero = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblHeroes = new System.Windows.Forms.Label();
            this.lblNumRemove = new System.Windows.Forms.Label();
            this.lblHeroAdd = new System.Windows.Forms.Label();
            this.lblHeroRemove = new System.Windows.Forms.Label();
            this.txtAddHero = new System.Windows.Forms.TextBox();
            this.txtRemoveHero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(83, 73);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(149, 134);
            this.lstNumbers.TabIndex = 0;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(381, 73);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(149, 134);
            this.lstHeroes.TabIndex = 1;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(93, 235);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(64, 23);
            this.btnRemoveNumber.TabIndex = 2;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(158, 235);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(64, 23);
            this.btnRemoveAllNumbers.TabIndex = 3;
            this.btnRemoveAllNumbers.Text = "Remove all";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(396, 44);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(57, 23);
            this.btnNewNumbers.TabIndex = 4;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(172, 44);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(50, 23);
            this.btnSortNumbers.TabIndex = 5;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(93, 44);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(57, 23);
            this.btnNewHeroes.TabIndex = 6;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(470, 44);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(50, 23);
            this.btnSortHeroes.TabIndex = 7;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(495, 260);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(46, 23);
            this.btnAddHero.TabIndex = 8;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(495, 331);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveHero.TabIndex = 9;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status: ";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(128, 23);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(49, 13);
            this.lblNumbers.TabIndex = 11;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(434, 23);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(41, 13);
            this.lblHeroes.TabIndex = 12;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblNumRemove
            // 
            this.lblNumRemove.AutoSize = true;
            this.lblNumRemove.Location = new System.Drawing.Point(90, 219);
            this.lblNumRemove.Name = "lblNumRemove";
            this.lblNumRemove.Size = new System.Drawing.Size(137, 13);
            this.lblNumRemove.TabIndex = 13;
            this.lblNumRemove.Text = "Select a number to remove.";
            // 
            // lblHeroAdd
            // 
            this.lblHeroAdd.AutoSize = true;
            this.lblHeroAdd.Location = new System.Drawing.Point(386, 233);
            this.lblHeroAdd.Name = "lblHeroAdd";
            this.lblHeroAdd.Size = new System.Drawing.Size(130, 13);
            this.lblHeroAdd.TabIndex = 14;
            this.lblHeroAdd.Text = "Enter a hero name to add:";
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Location = new System.Drawing.Point(386, 301);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(147, 13);
            this.lblHeroRemove.TabIndex = 15;
            this.lblHeroRemove.Text = "Enter a hero name to remove:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(389, 263);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 16;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(389, 334);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 389);
            this.Controls.Add(this.txtRemoveHero);
            this.Controls.Add(this.txtAddHero);
            this.Controls.Add(this.lblHeroRemove);
            this.Controls.Add(this.lblHeroAdd);
            this.Controls.Add(this.lblNumRemove);
            this.Controls.Add(this.lblHeroes);
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRemoveHero);
            this.Controls.Add(this.btnAddHero);
            this.Controls.Add(this.btnSortHeroes);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnNewNumbers;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortHeroes;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Button btnRemoveHero;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblHeroes;
        private System.Windows.Forms.Label lblNumRemove;
        private System.Windows.Forms.Label lblHeroAdd;
        private System.Windows.Forms.Label lblHeroRemove;
        private System.Windows.Forms.TextBox txtAddHero;
        private System.Windows.Forms.TextBox txtRemoveHero;
    }
}

