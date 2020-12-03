
namespace PresentationLayer
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxVets = new System.Windows.Forms.ListBox();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.textBoxYears = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.labelYears = new System.Windows.Forms.Label();
            this.buttonInsertVet = new System.Windows.Forms.Button();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.listBoxExp = new System.Windows.Forms.ListBox();
            this.textBoxYearsForComparation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 201);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // listBoxVets
            // 
            this.listBoxVets.FormattingEnabled = true;
            this.listBoxVets.Location = new System.Drawing.Point(24, 27);
            this.listBoxVets.Name = "listBoxVets";
            this.listBoxVets.Size = new System.Drawing.Size(738, 134);
            this.listBoxVets.TabIndex = 1;
            this.listBoxVets.SelectedIndexChanged += new System.EventHandler(this.listBoxVets_SelectedIndexChanged);
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.Location = new System.Drawing.Point(339, 201);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeciality.TabIndex = 2;
            // 
            // textBoxYears
            // 
            this.textBoxYears.Location = new System.Drawing.Point(606, 201);
            this.textBoxYears.Name = "textBoxYears";
            this.textBoxYears.Size = new System.Drawing.Size(100, 20);
            this.textBoxYears.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(60, 204);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Full Name";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Location = new System.Drawing.Point(281, 204);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(52, 13);
            this.labelSpeciality.TabIndex = 5;
            this.labelSpeciality.Text = "Speciality";
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(513, 204);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(87, 13);
            this.labelYears.TabIndex = 6;
            this.labelYears.Text = "YearsExperience";
            // 
            // buttonInsertVet
            // 
            this.buttonInsertVet.Location = new System.Drawing.Point(504, 244);
            this.buttonInsertVet.Name = "buttonInsertVet";
            this.buttonInsertVet.Size = new System.Drawing.Size(258, 32);
            this.buttonInsertVet.TabIndex = 7;
            this.buttonInsertVet.Text = "INSERT VET";
            this.buttonInsertVet.UseVisualStyleBackColor = true;
            this.buttonInsertVet.Click += new System.EventHandler(this.buttonInsertVet_Click);
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(275, 317);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(196, 26);
            this.buttonCompare.TabIndex = 8;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // listBoxExp
            // 
            this.listBoxExp.FormattingEnabled = true;
            this.listBoxExp.Location = new System.Drawing.Point(24, 300);
            this.listBoxExp.Name = "listBoxExp";
            this.listBoxExp.Size = new System.Drawing.Size(226, 43);
            this.listBoxExp.TabIndex = 9;
            // 
            // textBoxYearsForComparation
            // 
            this.textBoxYearsForComparation.Location = new System.Drawing.Point(24, 274);
            this.textBoxYearsForComparation.Name = "textBoxYearsForComparation";
            this.textBoxYearsForComparation.Size = new System.Drawing.Size(226, 20);
            this.textBoxYearsForComparation.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxYearsForComparation);
            this.Controls.Add(this.listBoxExp);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonInsertVet);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.labelSpeciality);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxYears);
            this.Controls.Add(this.textBoxSpeciality);
            this.Controls.Add(this.listBoxVets);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ListBox listBoxVets;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.TextBox textBoxYears;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.Button buttonInsertVet;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.ListBox listBoxExp;
        private System.Windows.Forms.TextBox textBoxYearsForComparation;
    }
}

