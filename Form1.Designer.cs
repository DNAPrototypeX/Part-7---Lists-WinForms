namespace Part_7___Lists_WinForms
{
    partial class frmMain
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
            this.btnNewHeroes = new System.Windows.Forms.Button();
            this.btnSortNumbers = new System.Windows.Forms.Button();
            this.btnNewNumbers = new System.Windows.Forms.Button();
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
            this.grpSortBy = new System.Windows.Forms.GroupBox();
            this.radDescending = new System.Windows.Forms.RadioButton();
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.chkToggleUpper = new System.Windows.Forms.CheckBox();
            this.grpSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.Location = new System.Drawing.Point(14, 84);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(149, 147);
            this.lstNumbers.TabIndex = 0;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.Location = new System.Drawing.Point(312, 81);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(149, 147);
            this.lstHeroes.TabIndex = 1;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveNumber.Location = new System.Drawing.Point(15, 255);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(64, 45);
            this.btnRemoveNumber.TabIndex = 2;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = false;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.BackColor = System.Drawing.Color.Red;
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(80, 255);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(73, 45);
            this.btnRemoveAllNumbers.TabIndex = 3;
            this.btnRemoveAllNumbers.Text = "Remove all";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = false;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewHeroes.Location = new System.Drawing.Point(319, 38);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(57, 40);
            this.btnNewHeroes.TabIndex = 4;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = false;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.BackColor = System.Drawing.Color.Turquoise;
            this.btnSortNumbers.Location = new System.Drawing.Point(103, 37);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(50, 41);
            this.btnSortNumbers.TabIndex = 5;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = false;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewNumbers.Location = new System.Drawing.Point(22, 37);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(57, 41);
            this.btnNewNumbers.TabIndex = 6;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = false;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.BackColor = System.Drawing.Color.Turquoise;
            this.btnSortHeroes.Location = new System.Drawing.Point(403, 37);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(50, 40);
            this.btnSortHeroes.TabIndex = 7;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = false;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddHero.Location = new System.Drawing.Point(412, 268);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(46, 23);
            this.btnAddHero.TabIndex = 8;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = false;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.BackColor = System.Drawing.Color.Red;
            this.btnRemoveHero.Location = new System.Drawing.Point(403, 317);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveHero.TabIndex = 9;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = false;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(10, 303);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(276, 46);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status: ";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbers.Location = new System.Drawing.Point(38, 9);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(98, 25);
            this.lblNumbers.TabIndex = 11;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroes.Location = new System.Drawing.Point(351, 9);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(81, 25);
            this.lblHeroes.TabIndex = 12;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblNumRemove
            // 
            this.lblNumRemove.AutoSize = true;
            this.lblNumRemove.Location = new System.Drawing.Point(16, 239);
            this.lblNumRemove.Name = "lblNumRemove";
            this.lblNumRemove.Size = new System.Drawing.Size(137, 13);
            this.lblNumRemove.TabIndex = 13;
            this.lblNumRemove.Text = "Select a number to remove.";
            // 
            // lblHeroAdd
            // 
            this.lblHeroAdd.AutoSize = true;
            this.lblHeroAdd.Location = new System.Drawing.Point(291, 252);
            this.lblHeroAdd.Name = "lblHeroAdd";
            this.lblHeroAdd.Size = new System.Drawing.Size(130, 13);
            this.lblHeroAdd.TabIndex = 14;
            this.lblHeroAdd.Text = "Enter a hero name to add:";
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Location = new System.Drawing.Point(291, 301);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(147, 13);
            this.lblHeroRemove.TabIndex = 15;
            this.lblHeroRemove.Text = "Enter a hero name to remove:";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(294, 268);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(100, 20);
            this.txtAddHero.TabIndex = 16;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(294, 320);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(100, 20);
            this.txtRemoveHero.TabIndex = 17;
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.radDescending);
            this.grpSortBy.Controls.Add(this.radAscending);
            this.grpSortBy.Location = new System.Drawing.Point(184, 116);
            this.grpSortBy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpSortBy.Size = new System.Drawing.Size(111, 68);
            this.grpSortBy.TabIndex = 18;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Text = "Sort in:";
            // 
            // radDescending
            // 
            this.radDescending.AutoSize = true;
            this.radDescending.Location = new System.Drawing.Point(0, 39);
            this.radDescending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(109, 17);
            this.radDescending.TabIndex = 1;
            this.radDescending.Text = "Descending order";
            this.radDescending.UseVisualStyleBackColor = true;
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Checked = true;
            this.radAscending.Location = new System.Drawing.Point(0, 18);
            this.radAscending.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(102, 17);
            this.radAscending.TabIndex = 0;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Ascending order";
            this.radAscending.UseVisualStyleBackColor = true;
            // 
            // chkToggleUpper
            // 
            this.chkToggleUpper.AutoSize = true;
            this.chkToggleUpper.Location = new System.Drawing.Point(319, 233);
            this.chkToggleUpper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkToggleUpper.Name = "chkToggleUpper";
            this.chkToggleUpper.Size = new System.Drawing.Size(139, 17);
            this.chkToggleUpper.TabIndex = 19;
            this.chkToggleUpper.Text = "Upper case hero names";
            this.chkToggleUpper.UseVisualStyleBackColor = true;
            this.chkToggleUpper.CheckedChanged += new System.EventHandler(this.chkToggleUpper_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 349);
            this.Controls.Add(this.chkToggleUpper);
            this.Controls.Add(this.grpSortBy);
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
            this.Controls.Add(this.btnNewNumbers);
            this.Controls.Add(this.btnSortNumbers);
            this.Controls.Add(this.btnNewHeroes);
            this.Controls.Add(this.btnRemoveAllNumbers);
            this.Controls.Add(this.btnRemoveNumber);
            this.Controls.Add(this.lstHeroes);
            this.Controls.Add(this.lstNumbers);
            this.Name = "frmMain";
            this.Text = "Part 7 - Lists in Winforms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSortBy.ResumeLayout(false);
            this.grpSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumbers;
        private System.Windows.Forms.ListBox lstHeroes;
        private System.Windows.Forms.Button btnRemoveNumber;
        private System.Windows.Forms.Button btnRemoveAllNumbers;
        private System.Windows.Forms.Button btnNewHeroes;
        private System.Windows.Forms.Button btnSortNumbers;
        private System.Windows.Forms.Button btnNewNumbers;
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
        private System.Windows.Forms.GroupBox grpSortBy;
        private System.Windows.Forms.RadioButton radDescending;
        private System.Windows.Forms.RadioButton radAscending;
        private System.Windows.Forms.CheckBox chkToggleUpper;
    }
}

