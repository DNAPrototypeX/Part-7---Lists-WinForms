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
            this.radAscending = new System.Windows.Forms.RadioButton();
            this.radDescending = new System.Windows.Forms.RadioButton();
            this.chkToggleUpper = new System.Windows.Forms.CheckBox();
            this.grpSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNumbers
            // 
            this.lstNumbers.FormattingEnabled = true;
            this.lstNumbers.ItemHeight = 16;
            this.lstNumbers.Location = new System.Drawing.Point(111, 90);
            this.lstNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.lstNumbers.Name = "lstNumbers";
            this.lstNumbers.Size = new System.Drawing.Size(197, 164);
            this.lstNumbers.TabIndex = 0;
            // 
            // lstHeroes
            // 
            this.lstHeroes.FormattingEnabled = true;
            this.lstHeroes.ItemHeight = 16;
            this.lstHeroes.Location = new System.Drawing.Point(508, 90);
            this.lstHeroes.Margin = new System.Windows.Forms.Padding(4);
            this.lstHeroes.Name = "lstHeroes";
            this.lstHeroes.Size = new System.Drawing.Size(197, 164);
            this.lstHeroes.TabIndex = 1;
            // 
            // btnRemoveNumber
            // 
            this.btnRemoveNumber.Location = new System.Drawing.Point(124, 289);
            this.btnRemoveNumber.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveNumber.Name = "btnRemoveNumber";
            this.btnRemoveNumber.Size = new System.Drawing.Size(85, 28);
            this.btnRemoveNumber.TabIndex = 2;
            this.btnRemoveNumber.Text = "Remove";
            this.btnRemoveNumber.UseVisualStyleBackColor = true;
            this.btnRemoveNumber.Click += new System.EventHandler(this.btnRemoveNumber_Click);
            // 
            // btnRemoveAllNumbers
            // 
            this.btnRemoveAllNumbers.Location = new System.Drawing.Point(211, 289);
            this.btnRemoveAllNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAllNumbers.Name = "btnRemoveAllNumbers";
            this.btnRemoveAllNumbers.Size = new System.Drawing.Size(97, 28);
            this.btnRemoveAllNumbers.TabIndex = 3;
            this.btnRemoveAllNumbers.Text = "Remove all";
            this.btnRemoveAllNumbers.UseVisualStyleBackColor = true;
            this.btnRemoveAllNumbers.Click += new System.EventHandler(this.btnRemoveAllNumbers_Click);
            // 
            // btnNewHeroes
            // 
            this.btnNewHeroes.Location = new System.Drawing.Point(528, 54);
            this.btnNewHeroes.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewHeroes.Name = "btnNewHeroes";
            this.btnNewHeroes.Size = new System.Drawing.Size(76, 28);
            this.btnNewHeroes.TabIndex = 4;
            this.btnNewHeroes.Text = "New List";
            this.btnNewHeroes.UseVisualStyleBackColor = true;
            this.btnNewHeroes.Click += new System.EventHandler(this.btnNewHeroes_Click);
            // 
            // btnSortNumbers
            // 
            this.btnSortNumbers.Location = new System.Drawing.Point(229, 54);
            this.btnSortNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortNumbers.Name = "btnSortNumbers";
            this.btnSortNumbers.Size = new System.Drawing.Size(67, 28);
            this.btnSortNumbers.TabIndex = 5;
            this.btnSortNumbers.Text = "Sort";
            this.btnSortNumbers.UseVisualStyleBackColor = true;
            this.btnSortNumbers.Click += new System.EventHandler(this.btnSortNumbers_Click);
            // 
            // btnNewNumbers
            // 
            this.btnNewNumbers.Location = new System.Drawing.Point(124, 54);
            this.btnNewNumbers.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewNumbers.Name = "btnNewNumbers";
            this.btnNewNumbers.Size = new System.Drawing.Size(76, 28);
            this.btnNewNumbers.TabIndex = 6;
            this.btnNewNumbers.Text = "New List";
            this.btnNewNumbers.UseVisualStyleBackColor = true;
            this.btnNewNumbers.Click += new System.EventHandler(this.btnNewNumbers_Click);
            // 
            // btnSortHeroes
            // 
            this.btnSortHeroes.Location = new System.Drawing.Point(627, 54);
            this.btnSortHeroes.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortHeroes.Name = "btnSortHeroes";
            this.btnSortHeroes.Size = new System.Drawing.Size(67, 28);
            this.btnSortHeroes.TabIndex = 7;
            this.btnSortHeroes.Text = "Sort";
            this.btnSortHeroes.UseVisualStyleBackColor = true;
            this.btnSortHeroes.Click += new System.EventHandler(this.btnSortHeroes_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.Location = new System.Drawing.Point(660, 320);
            this.btnAddHero.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(61, 28);
            this.btnAddHero.TabIndex = 8;
            this.btnAddHero.Text = "Add";
            this.btnAddHero.UseVisualStyleBackColor = true;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // btnRemoveHero
            // 
            this.btnRemoveHero.Location = new System.Drawing.Point(660, 407);
            this.btnRemoveHero.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveHero.Name = "btnRemoveHero";
            this.btnRemoveHero.Size = new System.Drawing.Size(77, 28);
            this.btnRemoveHero.TabIndex = 9;
            this.btnRemoveHero.Text = "Remove";
            this.btnRemoveHero.UseVisualStyleBackColor = true;
            this.btnRemoveHero.Click += new System.EventHandler(this.btnRemoveHero_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(35, 431);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status: ";
            // 
            // lblNumbers
            // 
            this.lblNumbers.AutoSize = true;
            this.lblNumbers.Location = new System.Drawing.Point(171, 28);
            this.lblNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(65, 17);
            this.lblNumbers.TabIndex = 11;
            this.lblNumbers.Text = "Numbers";
            // 
            // lblHeroes
            // 
            this.lblHeroes.AutoSize = true;
            this.lblHeroes.Location = new System.Drawing.Point(579, 28);
            this.lblHeroes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeroes.Name = "lblHeroes";
            this.lblHeroes.Size = new System.Drawing.Size(54, 17);
            this.lblHeroes.TabIndex = 12;
            this.lblHeroes.Text = "Heroes";
            // 
            // lblNumRemove
            // 
            this.lblNumRemove.AutoSize = true;
            this.lblNumRemove.Location = new System.Drawing.Point(120, 270);
            this.lblNumRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumRemove.Name = "lblNumRemove";
            this.lblNumRemove.Size = new System.Drawing.Size(182, 17);
            this.lblNumRemove.TabIndex = 13;
            this.lblNumRemove.Text = "Select a number to remove.";
            // 
            // lblHeroAdd
            // 
            this.lblHeroAdd.AutoSize = true;
            this.lblHeroAdd.Location = new System.Drawing.Point(515, 287);
            this.lblHeroAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeroAdd.Name = "lblHeroAdd";
            this.lblHeroAdd.Size = new System.Drawing.Size(174, 17);
            this.lblHeroAdd.TabIndex = 14;
            this.lblHeroAdd.Text = "Enter a hero name to add:";
            // 
            // lblHeroRemove
            // 
            this.lblHeroRemove.AutoSize = true;
            this.lblHeroRemove.Location = new System.Drawing.Point(515, 370);
            this.lblHeroRemove.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeroRemove.Name = "lblHeroRemove";
            this.lblHeroRemove.Size = new System.Drawing.Size(302, 17);
            this.lblHeroRemove.TabIndex = 15;
            this.lblHeroRemove.Text = "Enter a hero name to remove (Case sensitive):";
            // 
            // txtAddHero
            // 
            this.txtAddHero.Location = new System.Drawing.Point(519, 324);
            this.txtAddHero.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddHero.Name = "txtAddHero";
            this.txtAddHero.Size = new System.Drawing.Size(132, 22);
            this.txtAddHero.TabIndex = 16;
            // 
            // txtRemoveHero
            // 
            this.txtRemoveHero.Location = new System.Drawing.Point(519, 411);
            this.txtRemoveHero.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemoveHero.Name = "txtRemoveHero";
            this.txtRemoveHero.Size = new System.Drawing.Size(132, 22);
            this.txtRemoveHero.TabIndex = 17;
            // 
            // grpSortBy
            // 
            this.grpSortBy.Controls.Add(this.radDescending);
            this.grpSortBy.Controls.Add(this.radAscending);
            this.grpSortBy.Location = new System.Drawing.Point(326, 90);
            this.grpSortBy.Name = "grpSortBy";
            this.grpSortBy.Size = new System.Drawing.Size(148, 84);
            this.grpSortBy.TabIndex = 18;
            this.grpSortBy.TabStop = false;
            this.grpSortBy.Text = "Sort in:";
            // 
            // radAscending
            // 
            this.radAscending.AutoSize = true;
            this.radAscending.Checked = true;
            this.radAscending.Location = new System.Drawing.Point(0, 21);
            this.radAscending.Name = "radAscending";
            this.radAscending.Size = new System.Drawing.Size(133, 21);
            this.radAscending.TabIndex = 0;
            this.radAscending.TabStop = true;
            this.radAscending.Text = "Ascending order";
            this.radAscending.UseVisualStyleBackColor = true;
            // 
            // radDescending
            // 
            this.radDescending.AutoSize = true;
            this.radDescending.Location = new System.Drawing.Point(0, 48);
            this.radDescending.Name = "radDescending";
            this.radDescending.Size = new System.Drawing.Size(142, 21);
            this.radDescending.TabIndex = 1;
            this.radDescending.Text = "Descending order";
            this.radDescending.UseVisualStyleBackColor = true;
            // 
            // chkToggleUpper
            // 
            this.chkToggleUpper.AutoSize = true;
            this.chkToggleUpper.Location = new System.Drawing.Point(518, 261);
            this.chkToggleUpper.Name = "chkToggleUpper";
            this.chkToggleUpper.Size = new System.Drawing.Size(182, 21);
            this.chkToggleUpper.TabIndex = 19;
            this.chkToggleUpper.Text = "Upper case hero names";
            this.chkToggleUpper.UseVisualStyleBackColor = true;
            this.chkToggleUpper.CheckedChanged += new System.EventHandler(this.chkToggleUpper_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 479);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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

