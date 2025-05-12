namespace SemesterProjektRealBoligWinforms
{
    partial class Login
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
            adminBrugernavnLable = new Label();
            adminPasswordLable = new Label();
            adminBrugernavnTekstbox = new TextBox();
            adminPasswordTekstbox = new TextBox();
            ejendomsmæglerBrugernavnLable = new Label();
            ejendomsmæglerPasswordLable = new Label();
            ejendomsmæglerBrugernavnTekstbox = new TextBox();
            EjendomsmæglerPasswordTekstbox = new TextBox();
            godkendAdminKnap = new Button();
            ejendomsmæglerGodkendKanp = new Button();
            SuspendLayout();
            // 
            // adminBrugernavnLable
            // 
            adminBrugernavnLable.AutoSize = true;
            adminBrugernavnLable.Location = new Point(49, 50);
            adminBrugernavnLable.Name = "adminBrugernavnLable";
            adminBrugernavnLable.Size = new Size(288, 32);
            adminBrugernavnLable.TabIndex = 0;
            adminBrugernavnLable.Text = "Administrator Brugernavn";
            // 
            // adminPasswordLable
            // 
            adminPasswordLable.AutoSize = true;
            adminPasswordLable.Location = new Point(49, 101);
            adminPasswordLable.Name = "adminPasswordLable";
            adminPasswordLable.Size = new Size(262, 32);
            adminPasswordLable.TabIndex = 1;
            adminPasswordLable.Text = "Administrator Password";
            // 
            // adminBrugernavnTekstbox
            // 
            adminBrugernavnTekstbox.Location = new Point(385, 47);
            adminBrugernavnTekstbox.Name = "adminBrugernavnTekstbox";
            adminBrugernavnTekstbox.Size = new Size(224, 39);
            adminBrugernavnTekstbox.TabIndex = 2;
            // 
            // adminPasswordTekstbox
            // 
            adminPasswordTekstbox.Location = new Point(385, 98);
            adminPasswordTekstbox.Name = "adminPasswordTekstbox";
            adminPasswordTekstbox.Size = new Size(224, 39);
            adminPasswordTekstbox.TabIndex = 3;
            // 
            // ejendomsmæglerBrugernavnLable
            // 
            ejendomsmæglerBrugernavnLable.AutoSize = true;
            ejendomsmæglerBrugernavnLable.Location = new Point(49, 321);
            ejendomsmæglerBrugernavnLable.Name = "ejendomsmæglerBrugernavnLable";
            ejendomsmæglerBrugernavnLable.Size = new Size(330, 32);
            ejendomsmæglerBrugernavnLable.TabIndex = 4;
            ejendomsmæglerBrugernavnLable.Text = "Ejendomsmægler Brugernavn";
            // 
            // ejendomsmæglerPasswordLable
            // 
            ejendomsmæglerPasswordLable.AutoSize = true;
            ejendomsmæglerPasswordLable.Location = new Point(49, 373);
            ejendomsmæglerPasswordLable.Name = "ejendomsmæglerPasswordLable";
            ejendomsmæglerPasswordLable.Size = new Size(304, 32);
            ejendomsmæglerPasswordLable.TabIndex = 5;
            ejendomsmæglerPasswordLable.Text = "Ejendomsmægler Password";
            // 
            // ejendomsmæglerBrugernavnTekstbox
            // 
            ejendomsmæglerBrugernavnTekstbox.Location = new Point(385, 318);
            ejendomsmæglerBrugernavnTekstbox.Name = "ejendomsmæglerBrugernavnTekstbox";
            ejendomsmæglerBrugernavnTekstbox.Size = new Size(224, 39);
            ejendomsmæglerBrugernavnTekstbox.TabIndex = 6;
            // 
            // EjendomsmæglerPasswordTekstbox
            // 
            EjendomsmæglerPasswordTekstbox.Location = new Point(385, 370);
            EjendomsmæglerPasswordTekstbox.Name = "EjendomsmæglerPasswordTekstbox";
            EjendomsmæglerPasswordTekstbox.Size = new Size(224, 39);
            EjendomsmæglerPasswordTekstbox.TabIndex = 7;
            // 
            // godkendAdminKnap
            // 
            godkendAdminKnap.Location = new Point(652, 99);
            godkendAdminKnap.Name = "godkendAdminKnap";
            godkendAdminKnap.Size = new Size(131, 43);
            godkendAdminKnap.TabIndex = 8;
            godkendAdminKnap.Text = "Godkend";
            godkendAdminKnap.UseVisualStyleBackColor = true;
            // 
            // ejendomsmæglerGodkendKanp
            // 
            ejendomsmæglerGodkendKanp.Location = new Point(652, 368);
            ejendomsmæglerGodkendKanp.Name = "ejendomsmæglerGodkendKanp";
            ejendomsmæglerGodkendKanp.Size = new Size(131, 43);
            ejendomsmæglerGodkendKanp.TabIndex = 9;
            ejendomsmæglerGodkendKanp.Text = "Godkend";
            ejendomsmæglerGodkendKanp.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 468);
            Controls.Add(ejendomsmæglerGodkendKanp);
            Controls.Add(godkendAdminKnap);
            Controls.Add(EjendomsmæglerPasswordTekstbox);
            Controls.Add(ejendomsmæglerBrugernavnTekstbox);
            Controls.Add(ejendomsmæglerPasswordLable);
            Controls.Add(ejendomsmæglerBrugernavnLable);
            Controls.Add(adminPasswordTekstbox);
            Controls.Add(adminBrugernavnTekstbox);
            Controls.Add(adminPasswordLable);
            Controls.Add(adminBrugernavnLable);
            Name = "Login";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label adminBrugernavnLable;
        private Label adminPasswordLable;
        private TextBox adminBrugernavnTekstbox;
        private TextBox adminPasswordTekstbox;
        private Label ejendomsmæglerBrugernavnLable;
        private Label ejendomsmæglerPasswordLable;
        private TextBox ejendomsmæglerBrugernavnTekstbox;
        private TextBox EjendomsmæglerPasswordTekstbox;
        private Button godkendAdminKnap;
        private Button ejendomsmæglerGodkendKanp;
    }
}