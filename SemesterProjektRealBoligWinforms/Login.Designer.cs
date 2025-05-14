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
            adminBrugernavnLable.Location = new Point(37, 38);
            adminBrugernavnLable.Name = "adminBrugernavnLable";
            adminBrugernavnLable.Size = new Size(216, 25);
            adminBrugernavnLable.TabIndex = 0;
            adminBrugernavnLable.Text = "Administrator Brugernavn";
            // 
            // adminPasswordLable
            // 
            adminPasswordLable.AutoSize = true;
            adminPasswordLable.Location = new Point(37, 78);
            adminPasswordLable.Name = "adminPasswordLable";
            adminPasswordLable.Size = new Size(201, 25);
            adminPasswordLable.TabIndex = 1;
            adminPasswordLable.Text = "Administrator Password";
            // 
            // adminBrugernavnTekstbox
            // 
            adminBrugernavnTekstbox.Location = new Point(296, 37);
            adminBrugernavnTekstbox.Margin = new Padding(3, 2, 3, 2);
            adminBrugernavnTekstbox.Name = "adminBrugernavnTekstbox";
            adminBrugernavnTekstbox.Size = new Size(173, 31);
            adminBrugernavnTekstbox.TabIndex = 2;
            // 
            // adminPasswordTekstbox
            // 
            adminPasswordTekstbox.Location = new Point(296, 77);
            adminPasswordTekstbox.Margin = new Padding(3, 2, 3, 2);
            adminPasswordTekstbox.Name = "adminPasswordTekstbox";
            adminPasswordTekstbox.Size = new Size(173, 31);
            adminPasswordTekstbox.TabIndex = 3;
            adminPasswordTekstbox.UseSystemPasswordChar = true;
            // 
            // ejendomsmæglerBrugernavnLable
            // 
            ejendomsmæglerBrugernavnLable.AutoSize = true;
            ejendomsmæglerBrugernavnLable.Location = new Point(37, 250);
            ejendomsmæglerBrugernavnLable.Name = "ejendomsmæglerBrugernavnLable";
            ejendomsmæglerBrugernavnLable.Size = new Size(246, 25);
            ejendomsmæglerBrugernavnLable.TabIndex = 4;
            ejendomsmæglerBrugernavnLable.Text = "Ejendomsmægler Brugernavn";
            // 
            // ejendomsmæglerPasswordLable
            // 
            ejendomsmæglerPasswordLable.AutoSize = true;
            ejendomsmæglerPasswordLable.Location = new Point(37, 292);
            ejendomsmæglerPasswordLable.Name = "ejendomsmæglerPasswordLable";
            ejendomsmæglerPasswordLable.Size = new Size(231, 25);
            ejendomsmæglerPasswordLable.TabIndex = 5;
            ejendomsmæglerPasswordLable.Text = "Ejendomsmægler Password";
            // 
            // ejendomsmæglerBrugernavnTekstbox
            // 
            ejendomsmæglerBrugernavnTekstbox.Location = new Point(296, 248);
            ejendomsmæglerBrugernavnTekstbox.Margin = new Padding(3, 2, 3, 2);
            ejendomsmæglerBrugernavnTekstbox.Name = "ejendomsmæglerBrugernavnTekstbox";
            ejendomsmæglerBrugernavnTekstbox.Size = new Size(173, 31);
            ejendomsmæglerBrugernavnTekstbox.TabIndex = 6;
            // 
            // EjendomsmæglerPasswordTekstbox
            // 
            EjendomsmæglerPasswordTekstbox.Location = new Point(296, 288);
            EjendomsmæglerPasswordTekstbox.Margin = new Padding(3, 2, 3, 2);
            EjendomsmæglerPasswordTekstbox.Name = "EjendomsmæglerPasswordTekstbox";
            EjendomsmæglerPasswordTekstbox.Size = new Size(173, 31);
            EjendomsmæglerPasswordTekstbox.TabIndex = 7;
            EjendomsmæglerPasswordTekstbox.UseSystemPasswordChar = true;
            // 
            // godkendAdminKnap
            // 
            godkendAdminKnap.Location = new Point(501, 77);
            godkendAdminKnap.Margin = new Padding(3, 2, 3, 2);
            godkendAdminKnap.Name = "godkendAdminKnap";
            godkendAdminKnap.Size = new Size(101, 33);
            godkendAdminKnap.TabIndex = 8;
            godkendAdminKnap.Text = "Godkend";
            godkendAdminKnap.UseVisualStyleBackColor = true;
            godkendAdminKnap.Click += godkendAdminKnap_Click;
            // 
            // ejendomsmæglerGodkendKanp
            // 
            ejendomsmæglerGodkendKanp.Location = new Point(501, 287);
            ejendomsmæglerGodkendKanp.Margin = new Padding(3, 2, 3, 2);
            ejendomsmæglerGodkendKanp.Name = "ejendomsmæglerGodkendKanp";
            ejendomsmæglerGodkendKanp.Size = new Size(101, 33);
            ejendomsmæglerGodkendKanp.TabIndex = 9;
            ejendomsmæglerGodkendKanp.Text = "Godkend";
            ejendomsmæglerGodkendKanp.UseVisualStyleBackColor = true;
            ejendomsmæglerGodkendKanp.MouseClick += ejendomsmæglerGodkendKanp_MouseClick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 365);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            TopMost = true;
            Load += Login_Load;
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