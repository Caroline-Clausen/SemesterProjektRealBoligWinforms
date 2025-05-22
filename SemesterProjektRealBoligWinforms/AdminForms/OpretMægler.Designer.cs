namespace SemesterProjektRealBoligWinforms
{
    partial class OpretMægler
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
            components = new System.ComponentModel.Container();
            ejendomsmaeglerBindingSource = new BindingSource(components);
            vistMæglerDataGridView = new DataGridView();
            opretMæglerKnap = new Button();
            fjernMæglerLable = new Label();
            fjernMæglerKnap = new Button();
            redigerMæglerLable = new Label();
            redigerMæglerKnap = new Button();
            afslutOpretMæglerKnap = new Button();
            listeMæglerLable = new Label();
            opdaterMæglerListeKnap = new Button();
            opretMæglerLable = new Label();
            ejendomsmaeglerIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            EjendomsmaeglerBrugernavn = new DataGridViewTextBoxColumn();
            EjendomsmaeglerPassword = new DataGridViewTextBoxColumn();
            Navn = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ejendomsmaeglerBindingSource
            // 
            ejendomsmaeglerBindingSource.DataSource = typeof(Projekt1Semester.Ejendomsmaegler);
            // 
            // vistMæglerDataGridView
            // 
            vistMæglerDataGridView.AllowUserToAddRows = false;
            vistMæglerDataGridView.AllowUserToDeleteRows = false;
            vistMæglerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vistMæglerDataGridView.AutoGenerateColumns = false;
            vistMæglerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            vistMæglerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vistMæglerDataGridView.Columns.AddRange(new DataGridViewColumn[] { ejendomsmaeglerIDDataGridViewTextBoxColumn, EjendomsmaeglerBrugernavn, EjendomsmaeglerPassword, Navn, Email, Telefon });
            vistMæglerDataGridView.DataSource = ejendomsmaeglerBindingSource;
            vistMæglerDataGridView.Location = new Point(594, 93);
            vistMæglerDataGridView.Margin = new Padding(6);
            vistMæglerDataGridView.MultiSelect = false;
            vistMæglerDataGridView.Name = "vistMæglerDataGridView";
            vistMæglerDataGridView.ReadOnly = true;
            vistMæglerDataGridView.RowHeadersWidth = 50;
            vistMæglerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            vistMæglerDataGridView.Size = new Size(843, 730);
            vistMæglerDataGridView.TabIndex = 7;
            // 
            // opretMæglerKnap
            // 
            opretMæglerKnap.Location = new Point(288, 151);
            opretMæglerKnap.Margin = new Padding(6);
            opretMæglerKnap.Name = "opretMæglerKnap";
            opretMæglerKnap.Size = new Size(288, 49);
            opretMæglerKnap.TabIndex = 8;
            opretMæglerKnap.Text = "Opret ny ejendomsmægler";
            opretMæglerKnap.UseVisualStyleBackColor = true;
            opretMæglerKnap.Click += opretMæglerKnap_Click;
            // 
            // fjernMæglerLable
            // 
            fjernMæglerLable.AutoSize = true;
            fjernMæglerLable.Location = new Point(37, 783);
            fjernMæglerLable.Margin = new Padding(6, 0, 6, 0);
            fjernMæglerLable.Name = "fjernMæglerLable";
            fjernMæglerLable.Size = new Size(261, 32);
            fjernMæglerLable.TabIndex = 9;
            fjernMæglerLable.Text = "Fjern ejendomsmægler";
            // 
            // fjernMæglerKnap
            // 
            fjernMæglerKnap.Location = new Point(288, 774);
            fjernMæglerKnap.Margin = new Padding(6);
            fjernMæglerKnap.Name = "fjernMæglerKnap";
            fjernMæglerKnap.Size = new Size(288, 49);
            fjernMæglerKnap.TabIndex = 10;
            fjernMæglerKnap.Text = "Fjern ejendomsmægler";
            fjernMæglerKnap.UseVisualStyleBackColor = true;
            fjernMæglerKnap.Click += fjernMæglerKnap_Click;
            // 
            // redigerMæglerLable
            // 
            redigerMæglerLable.AutoSize = true;
            redigerMæglerLable.Location = new Point(69, 471);
            redigerMæglerLable.Margin = new Padding(6, 0, 6, 0);
            redigerMæglerLable.Name = "redigerMæglerLable";
            redigerMæglerLable.Size = new Size(227, 32);
            redigerMæglerLable.TabIndex = 15;
            redigerMæglerLable.Text = "Rediger oplysninger";
            // 
            // redigerMæglerKnap
            // 
            redigerMæglerKnap.Location = new Point(288, 463);
            redigerMæglerKnap.Margin = new Padding(6);
            redigerMæglerKnap.Name = "redigerMæglerKnap";
            redigerMæglerKnap.Size = new Size(288, 49);
            redigerMæglerKnap.TabIndex = 16;
            redigerMæglerKnap.Text = "Rediger oplysninger";
            redigerMæglerKnap.UseVisualStyleBackColor = true;
            redigerMæglerKnap.Click += redigerMæglerKnap_Click;
            // 
            // afslutOpretMæglerKnap
            // 
            afslutOpretMæglerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            afslutOpretMæglerKnap.Location = new Point(1231, 866);
            afslutOpretMæglerKnap.Margin = new Padding(6);
            afslutOpretMæglerKnap.Name = "afslutOpretMæglerKnap";
            afslutOpretMæglerKnap.Size = new Size(199, 62);
            afslutOpretMæglerKnap.TabIndex = 17;
            afslutOpretMæglerKnap.Text = "Afslut";
            afslutOpretMæglerKnap.UseVisualStyleBackColor = true;
            afslutOpretMæglerKnap.Click += afslutOpretMæglerKnap_Click;
            // 
            // listeMæglerLable
            // 
            listeMæglerLable.AutoSize = true;
            listeMæglerLable.Location = new Point(849, 41);
            listeMæglerLable.Margin = new Padding(6, 0, 6, 0);
            listeMæglerLable.Name = "listeMæglerLable";
            listeMæglerLable.Size = new Size(393, 32);
            listeMæglerLable.TabIndex = 18;
            listeMæglerLable.Text = "Liste over aktive ejendomsmæglere";
            // 
            // opdaterMæglerListeKnap
            // 
            opdaterMæglerListeKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            opdaterMæglerListeKnap.Location = new Point(587, 866);
            opdaterMæglerListeKnap.Margin = new Padding(6);
            opdaterMæglerListeKnap.Name = "opdaterMæglerListeKnap";
            opdaterMæglerListeKnap.Size = new Size(199, 62);
            opdaterMæglerListeKnap.TabIndex = 19;
            opdaterMæglerListeKnap.Text = "Opdater liste";
            opdaterMæglerListeKnap.UseVisualStyleBackColor = true;
            opdaterMæglerListeKnap.Click += opdaterMæglerListeKnap_Click;
            // 
            // opretMæglerLable
            // 
            opretMæglerLable.AutoSize = true;
            opretMæglerLable.Location = new Point(30, 160);
            opretMæglerLable.Margin = new Padding(6, 0, 6, 0);
            opretMæglerLable.Name = "opretMæglerLable";
            opretMæglerLable.Size = new Size(269, 32);
            opretMæglerLable.TabIndex = 20;
            opretMæglerLable.Text = "Opret ejendomsmægler";
            // 
            // ejendomsmaeglerIDDataGridViewTextBoxColumn
            // 
            ejendomsmaeglerIDDataGridViewTextBoxColumn.DataPropertyName = "EjendomsmaeglerID";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.HeaderText = "Mægler ID";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            ejendomsmaeglerIDDataGridViewTextBoxColumn.Name = "ejendomsmaeglerIDDataGridViewTextBoxColumn";
            ejendomsmaeglerIDDataGridViewTextBoxColumn.ReadOnly = true;
            ejendomsmaeglerIDDataGridViewTextBoxColumn.Width = 172;
            // 
            // EjendomsmaeglerBrugernavn
            // 
            EjendomsmaeglerBrugernavn.DataPropertyName = "EjendomsmaeglerBrugernavn";
            EjendomsmaeglerBrugernavn.HeaderText = "Brugernavn";
            EjendomsmaeglerBrugernavn.MinimumWidth = 10;
            EjendomsmaeglerBrugernavn.Name = "EjendomsmaeglerBrugernavn";
            EjendomsmaeglerBrugernavn.ReadOnly = true;
            EjendomsmaeglerBrugernavn.Width = 182;
            // 
            // EjendomsmaeglerPassword
            // 
            EjendomsmaeglerPassword.DataPropertyName = "EjendomsmaeglerPassword";
            EjendomsmaeglerPassword.HeaderText = "Password";
            EjendomsmaeglerPassword.MinimumWidth = 10;
            EjendomsmaeglerPassword.Name = "EjendomsmaeglerPassword";
            EjendomsmaeglerPassword.ReadOnly = true;
            EjendomsmaeglerPassword.Width = 156;
            // 
            // Navn
            // 
            Navn.DataPropertyName = "Navn";
            Navn.HeaderText = "Navn";
            Navn.MinimumWidth = 10;
            Navn.Name = "Navn";
            Navn.ReadOnly = true;
            Navn.Width = 115;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 10;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 116;
            // 
            // Telefon
            // 
            Telefon.DataPropertyName = "Telefon";
            Telefon.HeaderText = "Telefon";
            Telefon.MinimumWidth = 10;
            Telefon.Name = "Telefon";
            Telefon.ReadOnly = true;
            Telefon.Width = 138;
            // 
            // OpretMægler
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 954);
            Controls.Add(opretMæglerLable);
            Controls.Add(opdaterMæglerListeKnap);
            Controls.Add(listeMæglerLable);
            Controls.Add(afslutOpretMæglerKnap);
            Controls.Add(redigerMæglerKnap);
            Controls.Add(redigerMæglerLable);
            Controls.Add(fjernMæglerKnap);
            Controls.Add(fjernMæglerLable);
            Controls.Add(opretMæglerKnap);
            Controls.Add(vistMæglerDataGridView);
            Margin = new Padding(6);
            MinimumSize = new Size(1449, 956);
            Name = "OpretMægler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opret mægler";
            Load += OpretMægler_Load;
            ((System.ComponentModel.ISupportInitialize)ejendomsmaeglerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vistMæglerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource ejendomsmaeglerBindingSource;
        private DataGridView vistMæglerDataGridView;
        private DataGridViewTextBoxColumn personNavnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personEmailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personTelefonDataGridViewTextBoxColumn;
        private Button opretMæglerKnap;
        private Label fjernMæglerLable;
        private Button fjernMæglerKnap;
        private Label redigerMæglerLable;
        private Button redigerMæglerKnap;
        private Button afslutOpretMæglerKnap;
        private Label listeMæglerLable;
        private Button opdaterMæglerListeKnap;
        private Label opretMæglerLable;
        private DataGridViewTextBoxColumn ejendomsmaeglerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn EjendomsmaeglerBrugernavn;
        private DataGridViewTextBoxColumn EjendomsmaeglerPassword;
        private DataGridViewTextBoxColumn Navn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefon;
    }
}