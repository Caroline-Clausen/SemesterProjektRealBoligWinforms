namespace SemesterProjektRealBoligWinforms
{
    partial class KundeBud
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
            okKnap = new Button();
            fortrydKnap = new Button();
            emailKundeTekstboks = new TextBox();
            emailLable = new Label();
            telefonKundeTekstboks = new TextBox();
            telefonLable = new Label();
            navnLable = new Label();
            navnKundeTekstbox = new TextBox();
            kundeTekst = new Label();
            boligLable = new Label();
            budLable = new Label();
            adresseLable = new Label();
            budPris = new Label();
            SuspendLayout();
            // 
            // okKnap
            // 
            okKnap.Location = new Point(259, 241);
            okKnap.Name = "okKnap";
            okKnap.Size = new Size(70, 32);
            okKnap.TabIndex = 0;
            okKnap.Text = "Ok";
            okKnap.UseVisualStyleBackColor = true;
            // 
            // fortrydKnap
            // 
            fortrydKnap.Location = new Point(103, 241);
            fortrydKnap.Name = "fortrydKnap";
            fortrydKnap.Size = new Size(70, 32);
            fortrydKnap.TabIndex = 39;
            fortrydKnap.Text = "Fortryd";
            fortrydKnap.UseVisualStyleBackColor = true;
            // 
            // emailKundeTekstboks
            // 
            emailKundeTekstboks.Location = new Point(103, 108);
            emailKundeTekstboks.Name = "emailKundeTekstboks";
            emailKundeTekstboks.Size = new Size(226, 23);
            emailKundeTekstboks.TabIndex = 33;
            // 
            // emailLable
            // 
            emailLable.AutoSize = true;
            emailLable.Location = new Point(18, 111);
            emailLable.Name = "emailLable";
            emailLable.Size = new Size(83, 15);
            emailLable.TabIndex = 32;
            emailLable.Text = "E-mailadresse:";
            // 
            // telefonKundeTekstboks
            // 
            telefonKundeTekstboks.Location = new Point(103, 73);
            telefonKundeTekstboks.Name = "telefonKundeTekstboks";
            telefonKundeTekstboks.Size = new Size(226, 23);
            telefonKundeTekstboks.TabIndex = 31;
            // 
            // telefonLable
            // 
            telefonLable.AutoSize = true;
            telefonLable.Location = new Point(6, 76);
            telefonLable.Name = "telefonLable";
            telefonLable.Size = new Size(95, 15);
            telefonLable.TabIndex = 30;
            telefonLable.Text = "Telefonnummer:";
            // 
            // navnLable
            // 
            navnLable.AutoSize = true;
            navnLable.Location = new Point(35, 42);
            navnLable.Name = "navnLable";
            navnLable.Size = new Size(66, 15);
            navnLable.TabIndex = 29;
            navnLable.Text = "Fuldt navn:";
            // 
            // navnKundeTekstbox
            // 
            navnKundeTekstbox.Location = new Point(103, 39);
            navnKundeTekstbox.Name = "navnKundeTekstbox";
            navnKundeTekstbox.Size = new Size(226, 23);
            navnKundeTekstbox.TabIndex = 28;
            // 
            // kundeTekst
            // 
            kundeTekst.AutoSize = true;
            kundeTekst.Location = new Point(12, 9);
            kundeTekst.Name = "kundeTekst";
            kundeTekst.Size = new Size(374, 15);
            kundeTekst.TabIndex = 40;
            kundeTekst.Text = "Indtast dine kontaktoplysninger og vi vil vende tilbage hurtigst muligt";
            // 
            // boligLable
            // 
            boligLable.AutoSize = true;
            boligLable.Location = new Point(64, 172);
            boligLable.Name = "boligLable";
            boligLable.Size = new Size(37, 15);
            boligLable.TabIndex = 41;
            boligLable.Text = "Bolig:";
            // 
            // budLable
            // 
            budLable.AutoSize = true;
            budLable.Location = new Point(70, 197);
            budLable.Name = "budLable";
            budLable.Size = new Size(31, 15);
            budLable.TabIndex = 42;
            budLable.Text = "Bud:";
            // 
            // adresseLable
            // 
            adresseLable.AutoSize = true;
            adresseLable.Location = new Point(107, 172);
            adresseLable.Name = "adresseLable";
            adresseLable.Size = new Size(46, 15);
            adresseLable.TabIndex = 43;
            adresseLable.Text = "adresse";
            // 
            // budPris
            // 
            budPris.AutoSize = true;
            budPris.Location = new Point(107, 197);
            budPris.Name = "budPris";
            budPris.Size = new Size(26, 15);
            budPris.TabIndex = 44;
            budPris.Text = "pris";
            // 
            // KundeBud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 285);
            Controls.Add(budPris);
            Controls.Add(adresseLable);
            Controls.Add(budLable);
            Controls.Add(boligLable);
            Controls.Add(kundeTekst);
            Controls.Add(fortrydKnap);
            Controls.Add(emailKundeTekstboks);
            Controls.Add(emailLable);
            Controls.Add(telefonKundeTekstboks);
            Controls.Add(telefonLable);
            Controls.Add(navnLable);
            Controls.Add(navnKundeTekstbox);
            Controls.Add(okKnap);
            Name = "KundeBud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kundeoplysninger ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okKnap;
        private Button fortrydKnap;
        private TextBox emailKundeTekstboks;
        private Label emailLable;
        private TextBox telefonKundeTekstboks;
        private Label telefonLable;
        private Label navnLable;
        private TextBox navnKundeTekstbox;
        private Label kundeTekst;
        private Label boligLable;
        private Label budLable;
        private Label adresseLable;
        private Label budPris;
    }
}