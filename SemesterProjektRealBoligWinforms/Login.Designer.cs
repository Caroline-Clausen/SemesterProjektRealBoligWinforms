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
            adminBrugernavnLable.Location = new Point(26, 23);
            adminBrugernavnLable.Margin = new Padding(2, 0, 2, 0);
            adminBrugernavnLable.Name = "adminBrugernavnLable";
            adminBrugernavnLable.Size = new Size(144, 15);
            adminBrugernavnLable.TabIndex = 0;
            adminBrugernavnLable.Text = "Administrator Brugernavn";
            // 
            // adminPasswordLable
            // 
            adminPasswordLable.AutoSize = true;
            adminPasswordLable.Location = new Point(26, 47);
            adminPasswordLable.Margin = new Padding(2, 0, 2, 0);
            adminPasswordLable.Name = "adminPasswordLable";
            adminPasswordLable.Size = new Size(133, 15);
            adminPasswordLable.TabIndex = 1;
            adminPasswordLable.Text = "Administrator Password";
            // 
            // adminBrugernavnTekstbox
            // 
            adminBrugernavnTekstbox.Location = new Point(207, 22);
            adminBrugernavnTekstbox.Margin = new Padding(2, 1, 2, 1);
            adminBrugernavnTekstbox.Name = "adminBrugernavnTekstbox";
            adminBrugernavnTekstbox.Size = new Size(122, 23);
            adminBrugernavnTekstbox.TabIndex = 2;
            // 
            // adminPasswordTekstbox
            // 
            adminPasswordTekstbox.Location = new Point(207, 46);
            adminPasswordTekstbox.Margin = new Padding(2, 1, 2, 1);
            adminPasswordTekstbox.Name = "adminPasswordTekstbox";
            adminPasswordTekstbox.Size = new Size(122, 23);
            adminPasswordTekstbox.TabIndex = 3;
            adminPasswordTekstbox.UseSystemPasswordChar = true;
            // 
            // ejendomsmæglerBrugernavnLable
            // 
            ejendomsmæglerBrugernavnLable.AutoSize = true;
            ejendomsmæglerBrugernavnLable.Location = new Point(26, 150);
            ejendomsmæglerBrugernavnLable.Margin = new Padding(2, 0, 2, 0);
            ejendomsmæglerBrugernavnLable.Name = "ejendomsmæglerBrugernavnLable";
            ejendomsmæglerBrugernavnLable.Size = new Size(164, 15);
            ejendomsmæglerBrugernavnLable.TabIndex = 4;
            ejendomsmæglerBrugernavnLable.Text = "Ejendomsmægler Brugernavn";
            // 
            // ejendomsmæglerPasswordLable
            // 
            ejendomsmæglerPasswordLable.AutoSize = true;
            ejendomsmæglerPasswordLable.Location = new Point(26, 175);
            ejendomsmæglerPasswordLable.Margin = new Padding(2, 0, 2, 0);
            ejendomsmæglerPasswordLable.Name = "ejendomsmæglerPasswordLable";
            ejendomsmæglerPasswordLable.Size = new Size(153, 15);
            ejendomsmæglerPasswordLable.TabIndex = 5;
            ejendomsmæglerPasswordLable.Text = "Ejendomsmægler Password";
            // 
            // ejendomsmæglerBrugernavnTekstbox
            // 
            ejendomsmæglerBrugernavnTekstbox.Location = new Point(207, 149);
            ejendomsmæglerBrugernavnTekstbox.Margin = new Padding(2, 1, 2, 1);
            ejendomsmæglerBrugernavnTekstbox.Name = "ejendomsmæglerBrugernavnTekstbox";
            ejendomsmæglerBrugernavnTekstbox.Size = new Size(122, 23);
            ejendomsmæglerBrugernavnTekstbox.TabIndex = 6;
            // 
            // EjendomsmæglerPasswordTekstbox
            // 
            EjendomsmæglerPasswordTekstbox.Location = new Point(207, 173);
            EjendomsmæglerPasswordTekstbox.Margin = new Padding(2, 1, 2, 1);
            EjendomsmæglerPasswordTekstbox.Name = "EjendomsmæglerPasswordTekstbox";
            EjendomsmæglerPasswordTekstbox.Size = new Size(122, 23);
            EjendomsmæglerPasswordTekstbox.TabIndex = 7;
            EjendomsmæglerPasswordTekstbox.UseSystemPasswordChar = true;
            // 
            // godkendAdminKnap
            // 
            godkendAdminKnap.Location = new Point(351, 46);
            godkendAdminKnap.Margin = new Padding(2, 1, 2, 1);
            godkendAdminKnap.Name = "godkendAdminKnap";
            godkendAdminKnap.Size = new Size(71, 20);
            godkendAdminKnap.TabIndex = 8;
            godkendAdminKnap.Text = "Godkend";
            godkendAdminKnap.UseVisualStyleBackColor = true;
            godkendAdminKnap.Click += godkendAdminKnap_Click;
            // 
            // ejendomsmæglerGodkendKanp
            // 
            ejendomsmæglerGodkendKanp.Location = new Point(351, 172);
            ejendomsmæglerGodkendKanp.Margin = new Padding(2, 1, 2, 1);
            ejendomsmæglerGodkendKanp.Name = "ejendomsmæglerGodkendKanp";
            ejendomsmæglerGodkendKanp.Size = new Size(71, 20);
            ejendomsmæglerGodkendKanp.TabIndex = 9;
            ejendomsmæglerGodkendKanp.Text = "Godkend";
            ejendomsmæglerGodkendKanp.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 219);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TopMost = true;
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