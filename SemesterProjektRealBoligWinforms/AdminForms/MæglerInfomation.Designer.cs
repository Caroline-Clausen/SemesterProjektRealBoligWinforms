namespace SemesterProjektRealBoligWinforms
{
    partial class MæglerInformation
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
            parswordMæglerLable = new Label();
            brugernavnMæglerLable = new Label();
            parswordMæglerTekstboks = new TextBox();
            brugernavnMæglerTekstboks = new TextBox();
            emailMæglerTekstboks = new TextBox();
            emailMæglerLable = new Label();
            telefonMæglerTekstboks = new TextBox();
            telefonMæglerLable = new Label();
            opretNyEjendomsmæglerLable = new Label();
            navnMæglerLable = new Label();
            navnMæglerTekstbox = new TextBox();
            mæglerInfoGemKnap = new Button();
            fortrydMæglerInfoKnap = new Button();
            SuspendLayout();
            // 
            // parswordMæglerLable
            // 
            parswordMæglerLable.AutoSize = true;
            parswordMæglerLable.Location = new Point(53, 199);
            parswordMæglerLable.Name = "parswordMæglerLable";
            parswordMæglerLable.Size = new Size(57, 15);
            parswordMæglerLable.TabIndex = 25;
            parswordMæglerLable.Text = "Password";
            // 
            // brugernavnMæglerLable
            // 
            brugernavnMæglerLable.AutoSize = true;
            brugernavnMæglerLable.Location = new Point(42, 159);
            brugernavnMæglerLable.Name = "brugernavnMæglerLable";
            brugernavnMæglerLable.Size = new Size(68, 15);
            brugernavnMæglerLable.TabIndex = 24;
            brugernavnMæglerLable.Text = "Brugernavn";
            // 
            // parswordMæglerTekstboks
            // 
            parswordMæglerTekstboks.Location = new Point(115, 191);
            parswordMæglerTekstboks.Name = "parswordMæglerTekstboks";
            parswordMæglerTekstboks.Size = new Size(226, 23);
            parswordMæglerTekstboks.TabIndex = 23;
            parswordMæglerTekstboks.TextChanged += Tekstbox_TextChanged;
            // 
            // brugernavnMæglerTekstboks
            // 
            brugernavnMæglerTekstboks.Location = new Point(115, 156);
            brugernavnMæglerTekstboks.Name = "brugernavnMæglerTekstboks";
            brugernavnMæglerTekstboks.Size = new Size(226, 23);
            brugernavnMæglerTekstboks.TabIndex = 22;
            brugernavnMæglerTekstboks.TextChanged += Tekstbox_TextChanged;
            // 
            // emailMæglerTekstboks
            // 
            emailMæglerTekstboks.Location = new Point(115, 118);
            emailMæglerTekstboks.Name = "emailMæglerTekstboks";
            emailMæglerTekstboks.Size = new Size(226, 23);
            emailMæglerTekstboks.TabIndex = 21;
            emailMæglerTekstboks.TextChanged += Tekstbox_TextChanged;
            // 
            // emailMæglerLable
            // 
            emailMæglerLable.AutoSize = true;
            emailMæglerLable.Location = new Point(30, 121);
            emailMæglerLable.Name = "emailMæglerLable";
            emailMæglerLable.Size = new Size(80, 15);
            emailMæglerLable.TabIndex = 20;
            emailMæglerLable.Text = "E-mailadresse";
            // 
            // telefonMæglerTekstboks
            // 
            telefonMæglerTekstboks.Location = new Point(115, 83);
            telefonMæglerTekstboks.Name = "telefonMæglerTekstboks";
            telefonMæglerTekstboks.Size = new Size(226, 23);
            telefonMæglerTekstboks.TabIndex = 19;
            telefonMæglerTekstboks.TextChanged += Tekstbox_TextChanged;
            telefonMæglerTekstboks.KeyPress += telefonMæglerTekstboks_KeyPress;
            // 
            // telefonMæglerLable
            // 
            telefonMæglerLable.AutoSize = true;
            telefonMæglerLable.Location = new Point(18, 86);
            telefonMæglerLable.Name = "telefonMæglerLable";
            telefonMæglerLable.Size = new Size(92, 15);
            telefonMæglerLable.TabIndex = 18;
            telefonMæglerLable.Text = "Telefonnummer";
            // 
            // opretNyEjendomsmæglerLable
            // 
            opretNyEjendomsmæglerLable.AutoSize = true;
            opretNyEjendomsmæglerLable.Location = new Point(34, 18);
            opretNyEjendomsmæglerLable.Name = "opretNyEjendomsmæglerLable";
            opretNyEjendomsmæglerLable.Size = new Size(220, 15);
            opretNyEjendomsmæglerLable.TabIndex = 17;
            opretNyEjendomsmæglerLable.Text = "Indtast oplysninger på ejendomsmægler";
            // 
            // navnMæglerLable
            // 
            navnMæglerLable.AutoSize = true;
            navnMæglerLable.Location = new Point(47, 52);
            navnMæglerLable.Name = "navnMæglerLable";
            navnMæglerLable.Size = new Size(63, 15);
            navnMæglerLable.TabIndex = 16;
            navnMæglerLable.Text = "Fuldt navn";
            // 
            // navnMæglerTekstbox
            // 
            navnMæglerTekstbox.Location = new Point(115, 49);
            navnMæglerTekstbox.Name = "navnMæglerTekstbox";
            navnMæglerTekstbox.Size = new Size(226, 23);
            navnMæglerTekstbox.TabIndex = 15;
            navnMæglerTekstbox.TextChanged += Tekstbox_TextChanged;
            // 
            // mæglerInfoGemKnap
            // 
            mæglerInfoGemKnap.DialogResult = DialogResult.OK;
            mæglerInfoGemKnap.Enabled = false;
            mæglerInfoGemKnap.Location = new Point(358, 185);
            mæglerInfoGemKnap.Name = "mæglerInfoGemKnap";
            mæglerInfoGemKnap.Size = new Size(70, 32);
            mæglerInfoGemKnap.TabIndex = 26;
            mæglerInfoGemKnap.Text = "Gem";
            mæglerInfoGemKnap.UseVisualStyleBackColor = true;
            mæglerInfoGemKnap.Click += mæglerInfoGemKnap_Click;
            // 
            // fortrydMæglerInfoKnap
            // 
            fortrydMæglerInfoKnap.DialogResult = DialogResult.Cancel;
            fortrydMæglerInfoKnap.Location = new Point(434, 185);
            fortrydMæglerInfoKnap.Name = "fortrydMæglerInfoKnap";
            fortrydMæglerInfoKnap.Size = new Size(70, 32);
            fortrydMæglerInfoKnap.TabIndex = 27;
            fortrydMæglerInfoKnap.Text = "Fortryd";
            fortrydMæglerInfoKnap.UseVisualStyleBackColor = true;
            fortrydMæglerInfoKnap.Click += fortrydMæglerInfoKnap_Click;
            // 
            // MæglerInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 237);
            Controls.Add(fortrydMæglerInfoKnap);
            Controls.Add(mæglerInfoGemKnap);
            Controls.Add(parswordMæglerLable);
            Controls.Add(brugernavnMæglerLable);
            Controls.Add(parswordMæglerTekstboks);
            Controls.Add(brugernavnMæglerTekstboks);
            Controls.Add(emailMæglerTekstboks);
            Controls.Add(emailMæglerLable);
            Controls.Add(telefonMæglerTekstboks);
            Controls.Add(telefonMæglerLable);
            Controls.Add(opretNyEjendomsmæglerLable);
            Controls.Add(navnMæglerLable);
            Controls.Add(navnMæglerTekstbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MæglerInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mægler information";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label parswordMæglerLable;
        private Label brugernavnMæglerLable;
        private TextBox parswordMæglerTekstboks;
        private TextBox brugernavnMæglerTekstboks;
        private TextBox emailMæglerTekstboks;
        private Label emailMæglerLable;
        private TextBox telefonMæglerTekstboks;
        private Label telefonMæglerLable;
        private Label opretNyEjendomsmæglerLable;
        private Label navnMæglerLable;
        private TextBox navnMæglerTekstbox;
        private Button mæglerInfoGemKnap;
        private Button fortrydMæglerInfoKnap;
    }
}